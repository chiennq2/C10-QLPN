using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_CapToaXu
{
    [Table("DM_CAP_TOA_XU")]
    public class DM_CapToaXu : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string CTX_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string CTX_Ma { get; set; }
        public int CTX_Trang_Thai { get; set; }
    }
}
