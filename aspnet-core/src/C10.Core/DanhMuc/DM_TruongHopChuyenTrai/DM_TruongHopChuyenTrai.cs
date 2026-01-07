using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_TruongHopChuyenTrai
{
    [Table("DM_TRUONG_HOP_CHUYEN_TRAI")]

    public class DM_TruongHopChuyenTrai : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string THCT_NoiDung { get; set; }
        [MaxLength(10)]
        public string THCT_Code { get; set; }
        public bool THCT_IsActive { get; set; }
    }
}
