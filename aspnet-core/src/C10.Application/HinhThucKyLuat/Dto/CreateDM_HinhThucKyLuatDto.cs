using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_HinhThucKyLuat;

namespace C10.HinhThucKyLuat.Dto
{
    [AutoMapTo(typeof(DM_HinhThucKyLuat))]

    public class CreateDM_HinhThucKyLuatDto
    {
        public string HTKL_NoiDung { get; set; }
        public string HTKL_Code { get; set; }
        public bool HTKL_IsActive { get; set; }
    }
}
