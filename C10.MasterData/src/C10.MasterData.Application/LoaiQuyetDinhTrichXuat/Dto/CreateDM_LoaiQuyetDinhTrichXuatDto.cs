using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_LoaiQuyetDinhTrichXuat;
using System.ComponentModel.DataAnnotations;

namespace C10.LoaiQuyetDinhTrichXuat.Dto
{
    [AutoMapTo(typeof(DM_LoaiQuyetDinhTrichXuat))]

    public class CreateDM_LoaiQuyetDinhTrichXuatDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LQDTX_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LQDTX_Ma { get; set; }
        public int LQDTX_Trang_Thai { get; set; }
    }
}
