using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_HinhThucKhenThuong
{
    [Table("DM_HINH_THUC_KHEN_THUONG")]

    public class DM_HinhThucKhenThuong : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string HTKT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string HTKT_Ma { get; set; }
        public int HTKT_Trang_Thai { get; set; }
    }
    
}
