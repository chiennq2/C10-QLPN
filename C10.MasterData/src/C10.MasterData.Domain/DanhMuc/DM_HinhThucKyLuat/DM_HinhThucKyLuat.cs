using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_HinhThucKyLuat
{
    [Table("DM_HINH_THUC_KY_LUAT")]

    public class DM_HinhThucKyLuat : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string HTKL_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string HTKL_Ma { get; set; }
        public int HTKL_Trang_Thai { get; set; }
    }
}
