using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_HinhThucChon
{
    [Table("DM_HINH_THUC_CHON")]

    public class DM_HinhThucChon : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string HTC_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string HTC_Ma { get; set; }
        public int HTC_Trang_Thai { get; set; }
    }
}
