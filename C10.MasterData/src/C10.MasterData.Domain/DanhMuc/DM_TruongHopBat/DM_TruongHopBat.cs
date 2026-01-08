using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_TruongHopBat
{
    [Table("DM_TRUONG_HOP_BAT")]

    public class DM_TruongHopBat : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string THB_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string THB_Ma { get; set; }
        public int THB_Trang_Thai { get; set; }
    }
}
