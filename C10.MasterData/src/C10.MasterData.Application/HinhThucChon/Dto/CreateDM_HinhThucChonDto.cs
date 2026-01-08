using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_HinhThucChon;
using System.ComponentModel.DataAnnotations;

namespace C10.HinhThucChon.Dto
{
    [AutoMapTo(typeof(DM_HinhThucChon))]

    public class CreateDM_HinhThucChonDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string HTC_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string HTC_Ma { get; set; }
        public int HTC_Trang_Thai { get; set; }
    }
}
