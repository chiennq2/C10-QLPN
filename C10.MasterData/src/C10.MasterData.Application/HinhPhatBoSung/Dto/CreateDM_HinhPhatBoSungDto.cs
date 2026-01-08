using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_HinhPhatBoSung;
using System.ComponentModel.DataAnnotations;

namespace C10.HinhPhatBoSung.Dto
{
    [AutoMapTo(typeof(DM_HinhPhatBoSung))]

    public class CreateDM_HinhPhatBoSungDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string HPBS_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string HPBS_Ma { get; set; }
        public int HPBS_Trang_Thai { get; set; }
    }
}
