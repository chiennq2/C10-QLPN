using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_LoaiQuyetDinhTrichXuat
{
    [Table("DM_LOAI_QUYET_DINH_TRICH_XUAT")]

    public class DM_LoaiQuyetDinhTrichXuat : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string LQDTX_NoiDung { get; set; }
        [MaxLength(10)]
        public string LQDTX_Code { get; set; }
        public bool LQDTX_IsActive { get; set; }
    }
}
