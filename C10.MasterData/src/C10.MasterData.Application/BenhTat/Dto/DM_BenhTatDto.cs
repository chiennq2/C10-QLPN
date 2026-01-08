using Abp.Application.Services.Dto;
using C10.MasterData;
using System.ComponentModel.DataAnnotations;

namespace C10.BenhTat.Dto
{
    public class DM_BenhTatDto : EntityDto<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string BT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string BT_Ma { get;set; } 
        public int BT_Trang_Thai { get; set; }
    }
}
