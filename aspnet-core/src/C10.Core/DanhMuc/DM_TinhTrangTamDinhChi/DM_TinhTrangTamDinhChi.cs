using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_TinhTrangTamDinhChi
{
    [Table("DM_TINH_TRANG_TAM_DINH_CHI")]

    public class DM_TinhTrangTamDinhChi : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string TTTDC_NoiDung { get; set; }
        [MaxLength(10)]
        public string TTTDC_Code { get; set; }
        public bool TTTDC_IsActive { get; set; }
    }
}
