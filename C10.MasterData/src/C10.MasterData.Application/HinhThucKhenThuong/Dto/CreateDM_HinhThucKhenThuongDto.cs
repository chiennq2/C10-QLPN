using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_HinhThucKhenThuong;
using System.ComponentModel.DataAnnotations;

namespace C10.HinhThucKhenThuong.Dto
{
    [AutoMapTo(typeof(DM_HinhThucKhenThuong))]

    public class CreateDM_HinhThucKhenThuongDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string HTKT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string HTKT_Ma { get; set; }
        public int HTKT_Trang_Thai { get; set; }
    }
}
