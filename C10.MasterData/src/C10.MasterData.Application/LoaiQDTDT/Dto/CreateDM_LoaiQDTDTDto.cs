using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LoaiQDTDT;
using System.ComponentModel.DataAnnotations;

namespace C10.LoaiQDTDT.Dto
{
    [AutoMapTo(typeof(DM_LoaiQDTDT))]
    public class CreateDM_LoaiQDTDTDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LQDTDT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LQDTDT_Ma { get; set; }
        public int LQDTDT_Trang_Thai { get; set; }
    }
}
