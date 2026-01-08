using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_BenhTat;
using System.ComponentModel.DataAnnotations;

namespace C10.BenhTat.Dto
{
    [AutoMapTo(typeof(DM_BenhTat))]
    public class CreateDM_BenhTatDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string BT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string BT_Ma { get; set; }   
        public bool BT_Trang_Thai { get; set; }
    }
}
