using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_NgheNghiep;
using System.ComponentModel.DataAnnotations;

namespace C10.NgheNghiep.Dto
{
    [AutoMapTo(typeof(DM_NgheNghiep))]

    public class CreateDM_NgheNghiepDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string NN_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string NN_Ma { get; set; }
        public int NN_Trang_Thai { get; set; }
    }
}
