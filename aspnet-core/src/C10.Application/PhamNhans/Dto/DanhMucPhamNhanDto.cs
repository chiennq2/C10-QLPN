using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;
using C10.PhamNhans;

namespace C10.PhamNhans.Dto;

public class DanhMucPhamNhanDto : EntityDto<int>
{
    [Required]
    [StringLength(DanhMucPhamNhan.MaxCodeLength)]
    public string Code { get; set; }

    [Required]
    [StringLength(DanhMucPhamNhan.MaxNoiDungLength)]
    public string NoiDung { get; set; }

    public bool IsActive { get; set; }
}
