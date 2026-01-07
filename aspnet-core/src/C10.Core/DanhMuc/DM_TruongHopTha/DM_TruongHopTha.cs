using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_TruongHopTha
{
    [Table("DM_TRUONG_HOP_THA")]

    public class DM_TruongHopTha : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string THT_NoiDung { get; set; }
        [MaxLength(10)]
        public string THT_Code { get; set; }
        public bool THT_IsActive { get; set; }
    }
}
