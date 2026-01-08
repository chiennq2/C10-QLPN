using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_GhiChuRieng
{
    [Table("DM_GHI_CHU_RIENG")]
    public class DM_GhiChuRieng : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string GCR_Ten { get; set; }

        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string GCR_Ma { get; set; }
        public int GCR_Trang_Thai { get; set; }

    }

}
