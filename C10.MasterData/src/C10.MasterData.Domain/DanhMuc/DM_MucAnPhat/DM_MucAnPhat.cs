using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_MucAnPhat
{
    [Table("DM_MUC_AN_PHAT")]
    public class DM_MucAnPhat : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string MAP_Ten { get; set; }

        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string MAP_Ma { get; set; }
        public int? MAP_Tu_Muc_An { get; set; }
        public int? MAP_Den_Muc_An { get; set; }
        public int MAP_Trang_Thai { get; set; }
    }
}
