using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_XuLyBat
{
    [Table("DM_XU_LY_BAT")]

    public class DM_XuLyBat : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string XLB_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string XLB_Ma { get; set; }
        public int XLB_Trang_Thai { get; set; }
    }
}
