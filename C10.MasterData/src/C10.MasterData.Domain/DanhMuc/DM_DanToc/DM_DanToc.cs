using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_DanToc
{
    [Table("DM_DAN_TOC")]
    public class DM_DanToc : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string DT_Ten { get; set; }

        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string DT_Ma { get; set; }
        public int DT_Trang_Thai { get; set; }
    }
}
