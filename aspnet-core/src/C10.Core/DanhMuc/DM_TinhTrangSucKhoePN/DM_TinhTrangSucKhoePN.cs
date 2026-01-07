using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_TinhTrangSucKhoePN
{
    [Table("DM_TINH_TRANG_SUC_KHOE_PHAM_NHAN")]

    public class DM_TinhTrangSucKhoePN : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string TTSKPN_NoiDung { get; set; }
        [MaxLength(10)]
        public string TTSKPN_Code { get; set; }
        public bool TTSKPN_IsActive { get; set; }
    }
}
