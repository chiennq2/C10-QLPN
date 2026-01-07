using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanhMuc.DM_XepLoaiCaiTao
{
    [Table("DM_XEP_LOAI_CAI_TAO")]

    public class DM_XepLoaiCaiTao : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string XLCT_NoiDung { get; set; }
        [MaxLength(10)]
        public string XLCT_Code { get; set; }
        public bool XLCT_IsActive { get; set; }
    }
}
