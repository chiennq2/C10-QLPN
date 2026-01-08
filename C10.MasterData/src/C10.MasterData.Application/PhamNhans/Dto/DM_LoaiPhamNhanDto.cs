using Abp.Application.Services.Dto;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LoaiPhamNhan;
using C10.PhamNhans;
using System.ComponentModel.DataAnnotations;

namespace C10.PhamNhans.Dto;

public class DM_LoaiPhamNhanDto : EntityDto<int>
{
    [Required]
    [StringLength(MasterDataConsts.MaxMaLength)]
    public string LPN_Ma { get; set; }

    [Required]
    [StringLength(MasterDataConsts.MaxTenLength)]
    public string LPN_Ten { get; set; }

    public int LPN_Trang_Thai { get; set; }
}
