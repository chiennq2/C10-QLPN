using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LyDoDinhChi;
using System.ComponentModel.DataAnnotations;

namespace C10.LyDoDinhChi.Dto
{
    [AutoMapTo(typeof(DM_LyDoDinhChi))]
    public class CreateDM_LyDoDinhChiDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LDDC_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDDC_Ma { get; set; }
        public int LDDC_Trang_Thai { get; set; }
    }
}
