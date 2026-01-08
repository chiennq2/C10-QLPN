using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LyDoKhen;
using System.ComponentModel.DataAnnotations;

namespace C10.LyDoKhen.Dto
{
    [AutoMapTo(typeof(DM_LyDoKhen))]
    public class CreateDM_LyDoKhenDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LDK_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDK_Ma { get; set; }
        public int LDK_Trang_Thai { get; set; }
    }
}
