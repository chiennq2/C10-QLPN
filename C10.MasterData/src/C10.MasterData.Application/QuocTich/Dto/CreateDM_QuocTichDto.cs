using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_QuocTich;
using System.ComponentModel.DataAnnotations;

namespace C10.QuocTich.Dto
{
    [AutoMapTo(typeof(DM_QuocTich))]

    public class CreateDM_QuocTichDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string QT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string QT_Ma { get; set; }
        public int QT_Trang_Thai { get; set; }
    }
}
