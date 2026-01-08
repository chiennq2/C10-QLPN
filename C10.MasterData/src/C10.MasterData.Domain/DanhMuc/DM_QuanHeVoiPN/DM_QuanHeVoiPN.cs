using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_QuanHeVoiPN
{
    [Table("DM_QUAN_HE_VOI_PHAM_NHAN")]
    public class DM_QuanHeVoiPN : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string QHVPN_Ma { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string QHVPN_Ten { get; set; }
        public int QHVPN_Trang_Thai { get; set; }
    }
}
