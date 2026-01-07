using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_SinhConTheoMeVaoTrai
{
    [Table("DM_SINH_CON_THEO_ME_VAO_TRAI")]

    public class DM_SinhConTheoMeVaoTrai : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string SCTMVT_NoiDung { get; set; }
        [MaxLength(10)]
        public string SCTMVT_Code { get; set; }
        public bool SCTMVT_IsActive { get; set; }
    }
}
