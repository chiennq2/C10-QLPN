using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_GhiChuRieng;
using System.ComponentModel.DataAnnotations;


namespace C10.GhiChuRieng.Dto
{
    [AutoMapTo(typeof(DM_GhiChuRieng))]

    public class CreateDM_GhiChuRiengDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string GCR_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string GCR_Ma { get; set; }
        public int GCR_Trang_Thai { get; set; }
    }
}
