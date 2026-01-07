using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_TaiPham
{
    [Table("DM_TAI_PHAM")]

    public class DM_TaiPham : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string TP_NoiDung { get; set; }
        [MaxLength(10)]
        public string TP_Code { get; set; }
        public bool TP_IsActive { get; set; }
    }
}
