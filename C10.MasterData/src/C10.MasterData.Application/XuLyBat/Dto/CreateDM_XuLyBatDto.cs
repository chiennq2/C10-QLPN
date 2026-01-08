using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_XuLyBat;
using System.ComponentModel.DataAnnotations;

namespace C10.XuLyBat.Dto
{
    [AutoMapTo(typeof(DM_XuLyBat))]

    public class CreateDM_XuLyBatDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string XLB_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string XLB_Ma { get; set; }
        public int XLB_Trang_Thai { get; set; }
    }
}
