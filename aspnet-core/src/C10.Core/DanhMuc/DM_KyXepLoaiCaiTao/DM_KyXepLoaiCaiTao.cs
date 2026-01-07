using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_KyXepLoaiCaiTao
{
    [Table("DM_KY_XEP_LOAI_CAI_TAO")]
    public class DM_KyXepLoaiCaiTao : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string XLCT_NoiDung { get; set; }
        [MaxLength(10)]
        public string XLCT_Code { get; set; }
        public int XLCT_Year { get; set; }
        public DateTime? XLCT_FromDate { get; set; }
        public DateTime? XLCT_ToDate { get; set; }
        public bool XLCT_IsActive { get; set; }
    } 
}
