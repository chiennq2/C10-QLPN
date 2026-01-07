using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_TinhTrangTron
{
    [Table("DM_TINH_TRANG_TRON")]

    public class DM_TinhTrangTron : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string TTT_NoiDung { get; set; }
        [MaxLength(10)]
        public string TTT_Code { get; set; }
        public bool TTT_IsActive { get; set; }
    }
}
