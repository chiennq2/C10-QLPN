using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_DuocDacXa
{
    [Table("DM_DUOC_DAC_XA")]

    public class DM_DuocDacXa : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string DDX_NoiDung { get; set; }
        [MaxLength(10)]
        public string DDX_Code { get; set; }
        public bool DDX_IsActive { get; set; }
    }
}
