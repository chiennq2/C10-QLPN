using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_CapToaXu;
using System.ComponentModel.DataAnnotations;

namespace C10.CapToaXu.Dto
{
    [AutoMapTo(typeof(DM_CapToaXu))]
    public class CreateDM_CapToaXuDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string CTX_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string CTX_Ma { get; set; }
        public int CTX_Trang_Thai { get; set; }
    }
}
