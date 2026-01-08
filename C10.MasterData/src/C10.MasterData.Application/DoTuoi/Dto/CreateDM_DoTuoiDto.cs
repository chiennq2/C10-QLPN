using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_DoTuoi;
using System.ComponentModel.DataAnnotations;

namespace C10.DoTuoi.Dto
{
    [AutoMapTo(typeof(DM_DoTuoi))]

    public class CreateDM_DoTuoiDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string DTU_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string DTU_Ma { get; set; }
        [MaxLength(10)]
        public int? DTU_Tu_Tuoi { get; set; }
        [MaxLength(10)]
        public int? DTU_Den_Tuoi { get; set; }
        public int DTU_Trang_Thai { get; set; }
    }
}
