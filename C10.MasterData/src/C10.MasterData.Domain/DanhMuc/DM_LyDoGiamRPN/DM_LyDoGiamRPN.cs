using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_LyDoGiamRPN
{
    [Table("DM_LY_DO_RIENG_GIAM_PHAM_NHAN")]
    public class DM_LyDoGiamRPN : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LDRGPN_Ten { get; set; }

        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDRGPN_Ma { get; set; }
        public int LDRGPN_Trang_Thai { get; set; }
    }
}
