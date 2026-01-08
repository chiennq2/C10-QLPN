using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LyDoGiamRPN;
using System.ComponentModel.DataAnnotations;

namespace C10.LyDoGiamRPN.Dto
{
    [AutoMapTo(typeof(DM_LyDoGiamRPN))]

    public class CreateDM_LyDoGiamRPNDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LDRGPN_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDRGPN_Ma { get; set; }
        public int LDRGPN_Trang_Thai { get; set; }
    }
}
