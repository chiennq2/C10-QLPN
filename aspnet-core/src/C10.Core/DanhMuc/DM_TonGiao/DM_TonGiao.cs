using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_TonGiao
{
    [Table("DM_TON_GIAO")]

    public class DM_TonGiao : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string TG_NoiDung { get; set; }
        [MaxLength(10)]
        public string TG_Code { get; set; }
        public bool TG_IsActive { get; set; }
    }
}
