/*
 * Successor of SUAN .THH format sequence
 ***********************************************
 * SSTフォーマット（オレオレMIDIフォーマット）に準拠した
 * シーケンスおよびイベントの定義。
 */

using System;
using System.Collections.Generic;

namespace DAWforPMD.STT {
  public class SSTSequence {
    // 1秒あたりのティック数（曲のテンポにあたる数）
    private uint ticks_per_second;
    private uint tick_count = 0;
    private uint deltaTime  = 0;

    private Queue<SSTTrackEvent> events;

    private Queue<SSTTrackEvent>   trackEventQueue = new Queue<SSTTrackEvent>();
    private Queue<SSTTrackEvent>[] eventQueue      = new Queue<SSTTrackEvent>[16];

    public SSTSequence(IEnumerable<SSTTrackEvent> events) {
      this.events = new Queue<SSTTrackEvent>(events);
    }

    public void NextTick() {
      deltaTime++;
      tick_count++;

      //  イベントリスト内のイベントをすべて処理する
      var nextEvent = events.SafePeek();

      while (nextEvent              != null
             && nextEvent.DeltaTime <= deltaTime) {
        // 時間を満たすイベントを取り出し、チャンネル毎に割り当てる 
        events.Dequeue();

        if (nextEvent.IsTargetTrack) {
          eventQueue[nextEvent.Channel].Enqueue(nextEvent);
        } else {
          trackEventQueue.Enqueue(nextEvent);
        }

        nextEvent = events.SafePeek();
        deltaTime = 0;
      }
    }

    public SSTTrackEvent NextEvent(uint channel) {
      // チャンネル毎のイベントを取得
      return eventQueue[channel].SafeDequeue();
    }
  }

  public enum SSTEventType {
    Ch_KeyOn  = 0x00,
    Ch_KeyOff = 0x01,
    Ch_Contol = 0x02,

    Ch_Kill  = 0x10,
    Ch_Reset = 0x11,

    Tr_Kill = 0x30,
  }

  public class SSTTrackEvent {
    /// <summary>
    /// イベントターゲット。
    /// </summary>
    /// .SST ファイルのイベントターゲットは、 byte値で表される。 <br/>
    /// RCCCCooo                       <br/>
    /// R    -> 1: チャンネルイベント／ 0: トラックイベント <br/>
    /// R = 0 のとき、 CCCCooo = 0 となる。
    /// また、R = 1 のとき
    /// CCCC -> チャンネル番号 (0 - 15)  <br/>
    ///  ooo -> オペレータ番号           <br/>
    /// である。
    public UInt8 Target { get; set; }

    /// <summary>
    /// 相対時間
    /// </summary>
    /// 直前のイベントから次のイベントまでの時間を表します。
    /// 単位はティック。（トラックで指定）
    public UInt16 DeltaTime { get; set; }

    /// <summary>
    /// 絶対時間
    /// </summary>
    /// 0ティックからイベントまでの時間を表します。
    /// 単位はティック。（トラックで指定）
    /// .SSTフォーマット自体は絶対時間を持ちませんので、
    /// DAWでのローディング時に算出することになります。 
    public UInt16 AbsTime { get; set; }

    /// <summary>
    /// イベントの種類。
    /// </summary>
    public SSTEventType EventType;

    /// <summary>
    ///  イベント値
    /// </summary>
    public UInt16 Value;

    // Targetへのアクセサー
    public UInt8 Channel {
      get => (Target >> 3) & 0x0F;
      set => Target = Target & 0x0F | value;
    }

    public UInt8 Operator {
      get => Target & 0x07;
      set => Target = Target & 0x0F | value;
    }

    public bool IsTargetTrack => Target >> 7;
  }

  static class _QueueExtensions {
    public static T SafePeek<T>(this Queue<T> self) {
      if (self.Count > 0)
        return self.Peek();
      else
        return default(T);
    }

    public static T SafeDequeue<T>(this Queue<T> self) {
      if (self.Count > 0)
        return self.Dequeue();
      else
        return default(T);
    }
  }
}
