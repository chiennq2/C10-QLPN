using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_LyDoKhongXetGiam
{
    [Table("DM_LY_DO_KHONG_XET_GIAM")]

    public class DM_LyDoKhongXetGiam : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDKXG_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDKXG_Ma { get; set; }
        public int LDKXG_Trang_Thai { get; set; }
    }
}
