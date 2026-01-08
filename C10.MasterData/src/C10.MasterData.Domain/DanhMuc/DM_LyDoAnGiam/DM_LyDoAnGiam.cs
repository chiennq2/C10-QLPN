using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_LyDoAnGiam
{
    [Table("DM_LY_DO_AN_GIAM")]

    public class DM_LyDoAnGiam : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDAG_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDAG_Ma { get; set; }
        public int LDAG_Trang_Thai { get; set; }
    }
}
