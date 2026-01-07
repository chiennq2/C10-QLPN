using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_TruongHopChet
{
    [Table("DM_TRUONG_HOP_CHET")]
    public class DM_TruongHopChet : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string THC_NoiDung { get; set; }
        [MaxLength(10)]
        public string THC_Code { get; set; }
        public bool THC_IsActive { get; set; }
    }
}
