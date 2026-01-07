using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_LoaiTangGiamHinhPhat
{
    [Table("DM_LOAI_TANG_GIAM_HINH_PHAT")]

    public class DM_LoaiTangGiamHinhPhat : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string LTGHP_NoiDung { get; set; }

        [MaxLength(10)]
        public string LTGHP_Code { get; set; }
        public bool LTGHP_IsActive { get; set; }
    }
}
