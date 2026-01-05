using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.PhamNhans;

[Table("DM_PHAM_NHAN")]
public class DanhMucPhamNhan : FullAuditedEntity<int>
{
    public const int MaxCodeLength = 10;
    public const int MaxNoiDungLength = 255;

    [Required]
    [StringLength(MaxCodeLength)]
    public string Code { get; set; }

    [Required]
    [StringLength(MaxNoiDungLength)]
    public string NoiDung { get; set; }

    public bool IsActive { get; set; }
}
