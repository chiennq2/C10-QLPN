using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_LyDoKhen
{
    [Table("DM_LY_DO_KHEN")]
    public class DM_LyDoKhen : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDK_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDK_Ma { get; set; }
        public int LDK_Trang_Thai { get; set; }
    }
}
