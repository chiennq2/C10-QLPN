using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LoaiPhamNhan;
using System.ComponentModel.DataAnnotations;

namespace C10.PhamNhans.Dto;

public class CreateDM_LoaiPhamNhanDto
{
    [Required]
    [StringLength(MasterDataConsts.MaxMaLength)]
    public string LPN_Ma { get; set; }

    [Required]
    [StringLength(MasterDataConsts.MaxTenLength)]
    public string LPN_Ten { get; set; }

    public int LPN_Trang_Thai { get; set; }
}
