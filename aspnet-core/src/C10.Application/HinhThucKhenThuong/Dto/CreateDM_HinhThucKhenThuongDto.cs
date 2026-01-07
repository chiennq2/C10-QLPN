using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_HinhThucKhenThuong;

namespace C10.HinhThucKhenThuong.Dto
{
    [AutoMapTo(typeof(DM_HinhThucKhenThuong))]

    public class CreateDM_HinhThucKhenThuongDto
    {
        public string HTKT_NoiDung { get; set; }
        public string HTKT_Code { get; set; }
        public bool HTKT_IsActive { get; set; }
    }
}
