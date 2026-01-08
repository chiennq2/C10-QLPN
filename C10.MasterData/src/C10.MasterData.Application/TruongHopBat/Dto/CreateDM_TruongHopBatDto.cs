using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_TruongHopBat;
using System.ComponentModel.DataAnnotations;

namespace C10.TruongHopBat.Dto
{
    [AutoMapTo(typeof(DM_TruongHopBat))]

    public class CreateDM_TruongHopBatDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string THB_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string THB_Ma { get; set; }
        public int THB_Trang_Thai { get; set; }
    }
}
