using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_GioiTinh
{
    [Table("DM_GIOI_TINH")]
    public class DM_GioiTinh : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string GT_Ten { get; set; }

        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string GT_Ma { get; set; }
        public int GT_Trang_Thai { get; set; }
    }
}
