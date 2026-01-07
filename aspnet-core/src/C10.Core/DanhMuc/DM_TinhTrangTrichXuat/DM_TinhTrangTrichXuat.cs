using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_TinhTrangTrichXuat
{
    [Table("DM_TINH_TRANG_TRICH_XUAT")]

    public class DM_TinhTrangTrichXuat : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string TTTX_NoiDung { get; set; }
        [MaxLength(10)]
        public string TTTX_Code { get; set; }
        public bool TTTX_IsActive { get; set; }
    }
}
