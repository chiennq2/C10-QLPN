using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_LyDoTrichXuat;

namespace C10.LyDoTrichXuat.Dto
{
    [AutoMapTo(typeof(DM_LyDoTrichXuat))]

    public class CreateDM_LyDoTrichXuatDto
    {
        public string LDTX_NoiDung { get; set; }
        public string LDTX_Code { get; set; }
        public bool LDTX_IsActive { get; set; }
    }
}
