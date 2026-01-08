using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_MaPhanLoai;
using System.ComponentModel.DataAnnotations;

namespace C10.MaPhanLoai.Dto
{
    [AutoMapTo(typeof(DM_MaPhanLoai))]

    public class CreateDM_MaPhanLoaiDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string MPL_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string MPL_Ma { get; set; }
        public int MPL_Trang_Thai { get; set; }
    }
}
