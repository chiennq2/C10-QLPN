using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_LyDoKyLuat
{
    [Table("DM_LY_DO_KY_LUAT")]
    public class DM_LyDoKyLuat : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDKL_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDKL_Ma { get; set; }
        public int LDKL_Trang_Thai { get; set; }
    }
}
