using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LoaiQDTDC;
using System.ComponentModel.DataAnnotations;

namespace C10.LoaiQDTDC.Dto
{
    [AutoMapTo(typeof(DM_LoaiQDTDC))]
    public class CreateDM_LoaiQDTDCDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LQDTDC_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LQDTDC_Ma { get; set; }
        public int LQDTDC_Trang_Thai { get; set; }
    }
}
