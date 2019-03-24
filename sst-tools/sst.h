/**
 * @file   sst.h
 * @author 3c1u (Hikaru Terazono)
 * @brief  .SST (The successor of SUAN .THH format)のなんとやら
 * @copyright Copyright (c) 2019 Hikaru Terazono
 */

#ifndef _SST_H
#define _SST_H

#include <stdint.h>

#ifdef _cplusplus
extern "C" {
#endif

typedef struct _sst_header_t {
    /**
     * @brief .SSTヘッダーセクションのマジックナンバー。
     * 'S', 'U', 'A', 'N'
     */
    char     magic[4];

    /**
     * @brief ヘッダの先頭から数えた、次のセクション（おそらくデータセクション）へのオフセット値。
     * もし次のセクションが存在しない場合は、oが入ります
     */
    uint16_t section_offset;

    /**
     * @brief １秒あたりのティック数。
     */
    uint16_t ticks_per_seconds;


} sst_header_t;

typedef struct _sst_data_t {
    char magic[4]; // "data"
    uint16_t section_offset;
    sst_mnemonic_t data[];
} sst_data_t;

typedef union _sst_mnemonic_t {
    uint32_t _;
    struct {
        struct {
            uint8_t is_track_event :1;
            uint8_t target_channel :4;
            uint8_t target_operator:3;
        } target;
        uint8_t  type;
        uint16_t value;
    } event;
} sst_mnemonic_t;

#ifdef _cplusplus
}
#endif

#endif // _SST_H

