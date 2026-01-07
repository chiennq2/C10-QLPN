using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_HinhThucKhenThuong
{
    [Table("DM_HINH_THUC_KHEN_THUONG")]

    public class DM_HinhThucKhenThuong : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string HTKT_NoiDung { get; set; }
        [MaxLength(10)]
        public string HTKT_Code { get; set; }
        public bool HTKT_IsActive { get; set; }
    }
    
}
