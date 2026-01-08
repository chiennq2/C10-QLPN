using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_LyDoTrichXuat
{
    [Table("DM_LY_DO_TRICH_XUAT")]

    public class DM_LyDoTrichXuat : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDTX_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDTX_Ma { get; set; }
        public int LDTX_Trang_Thai { get; set; }
    }
}
