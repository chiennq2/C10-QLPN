using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_HinhThucKyLuat;
using System.ComponentModel.DataAnnotations;

namespace C10.HinhThucKyLuat.Dto
{
    [AutoMapTo(typeof(DM_HinhThucKyLuat))]

    public class CreateDM_HinhThucKyLuatDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string HTKL_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string HTKL_Ma { get; set; }
        public int HTKL_Trang_Thai { get; set; }
    }
}
