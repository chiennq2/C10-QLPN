using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_TinhTrangConTheoMeVaoTrai
{
    [Table("DM_TINH_TRANG_CON_THEO_ME_VAO_TRAI")]

    public class DM_TinhTrangConTheoMeVaoTrai : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string TTCTMVT_NoiDung { get; set; }
        [MaxLength(10)]
        public string TTCTMVT_Code { get; set; }
        public bool TTCTMVT_IsActive { get; set; }
    }
}
