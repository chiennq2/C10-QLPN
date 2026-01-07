using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_LyDoKyLuat;

namespace C10.LyDoKyLuat.Dto
{
    [AutoMapTo(typeof(DM_LyDoKyLuat))]

    public class CreateDM_LyDoKyLuatDto
    {
        public string LDKL_NoiDung { get; set; }
        public string LDKL_Code { get; set; }
        public bool LDKL_IsActive { get; set; }
    }
}
