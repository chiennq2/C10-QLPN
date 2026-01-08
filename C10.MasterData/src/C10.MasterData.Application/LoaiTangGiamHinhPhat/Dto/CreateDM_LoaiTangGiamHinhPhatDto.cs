using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LoaiTangGiamHinhPhat;
using System.ComponentModel.DataAnnotations;

namespace C10.LoaiTangGiamHinhPhat.Dto
{
    [AutoMapTo(typeof(DM_LoaiTangGiamHinhPhat))]
    public class CreateDM_LoaiTangGiamHinhPhatDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LTGHP_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LTGHP_Ma { get; set; }
        public int LTGHP_Trang_Thai { get; set; }
    }
}
