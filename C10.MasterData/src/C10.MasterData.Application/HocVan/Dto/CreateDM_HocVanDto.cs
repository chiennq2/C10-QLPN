using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_HocVan;
using System.ComponentModel.DataAnnotations;

namespace C10.HocVan.Dto
{
    [AutoMapTo(typeof(DM_HocVan))]
    public class CreateDM_HocVanDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string HV_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string HV_Ma { get; set; }
        public int HV_Trang_Thai { get; set; }
    }
}
