using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_DanToc;
using System.ComponentModel.DataAnnotations;

namespace C10.DanToc.Dto
{
    [AutoMapTo(typeof(DM_DanToc))]
    public class CreateDM_DanTocDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string DT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string DT_Ma { get; set; }
        public int DT_Trang_Thai { get; set; }
    }
}
