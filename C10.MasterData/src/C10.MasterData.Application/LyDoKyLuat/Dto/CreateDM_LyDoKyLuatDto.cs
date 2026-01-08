using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LyDoKyLuat;
using System.ComponentModel.DataAnnotations;

namespace C10.LyDoKyLuat.Dto
{
    [AutoMapTo(typeof(DM_LyDoKyLuat))]

    public class CreateDM_LyDoKyLuatDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LDKL_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDKL_Ma { get; set; }
        public int LDKL_Trang_Thai { get; set; }
    }
}
