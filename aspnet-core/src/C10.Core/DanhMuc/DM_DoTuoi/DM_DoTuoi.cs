using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_DoTuoi
{
    [Table("DM_DO_TUOI")]
    public class DM_DoTuoi : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string DT_NoiDung { get; set; }

        [MaxLength(10)]
        public string DT_Code { get; set; }
   
        public int DT_TuDoTuoi { get; set; }

        public int DT_DenDoTuoi { get; set; }

        public bool DT_IsActive { get; set; }

    }
}
