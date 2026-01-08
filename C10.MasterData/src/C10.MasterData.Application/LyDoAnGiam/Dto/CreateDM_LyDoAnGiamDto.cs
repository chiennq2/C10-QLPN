using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LyDoAnGiam;
using System.ComponentModel.DataAnnotations;

namespace C10.LyDoAnGiam.Dto
{
    [AutoMapTo(typeof(DM_LyDoAnGiam))]

    public class CreateDM_LyDoAnGiamDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LDAG_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDAG_Ma { get; set; }
        public int LDAG_Trang_Thai { get; set; }
    }
}
