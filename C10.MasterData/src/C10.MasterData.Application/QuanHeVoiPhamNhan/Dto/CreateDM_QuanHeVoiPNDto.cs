using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_QuanHeVoiPN;
using System.ComponentModel.DataAnnotations;

namespace C10.QuanHeVoiPhamNhan.Dto
{
    [AutoMapTo(typeof(DM_QuanHeVoiPN))]

    public class CreateDM_QuanHeVoiPNDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string QHVPN_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string QHVPN_Ma { get; set; }
        public int QHVPN_Trang_Thai { get; set; }
    }
}
