using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LoaiPhanLoai;
using System.ComponentModel.DataAnnotations;

namespace C10.LoaiPhanLoai.Dto
{
    [AutoMapTo(typeof(DM_LoaiPhanLoai))]
    public class CreateDM_LoaiPhanLoaiDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LPL_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LPL_Ma { get; set; }
        public int LPL_Trang_Thai { get; set; }
    }
}
