using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LyDoTrichXuat;
using System.ComponentModel.DataAnnotations;

namespace C10.LyDoTrichXuat.Dto
{
    [AutoMapTo(typeof(DM_LyDoTrichXuat))]

    public class CreateDM_LyDoTrichXuatDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LDTX_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDTX_Ma { get; set; }
        public int LDTX_Trang_Thai { get; set; }
    }
}
