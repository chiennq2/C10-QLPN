using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_TruongHopMienHinhPhat
{
    [Table("DM_TRUONG_HOP_MIEN_HINH_PHAT")]

    public class DM_TruongHopMienHinhPhat : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string THMHP_NoiDung { get; set; }
        [MaxLength(10)]
        public string THMHP_Code { get; set; }
        public bool THMHP_IsActive { get; set; }
    }
}
