using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_QuanHeVoiPN;

namespace C10.QuanHeVoiPhamNhan.Dto
{
    [AutoMapTo(typeof(DM_QuanHeVoiPN))]

    public class CreateDM_QuanHeVoiPNDto
    {
        public string QHVPN_NoiDung { get; set; }
        public string QHVPN_Code { get; set; }
        public int? QHVPN_GioiTinhId { get; set; }
        public bool QHVPN_IsActive { get; set; }
    }
}
