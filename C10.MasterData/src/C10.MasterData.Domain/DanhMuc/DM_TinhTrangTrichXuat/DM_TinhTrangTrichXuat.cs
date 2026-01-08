using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_TinhTrangTrichXuat
{
    [Table("DM_TINH_TRANG_TRICH_XUAT")]

    public class DM_TinhTrangTrichXuat : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string TTTX_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string TTTX_Ma { get; set; }
        public int TTTX_Trang_Thai { get; set; }
    }
}
