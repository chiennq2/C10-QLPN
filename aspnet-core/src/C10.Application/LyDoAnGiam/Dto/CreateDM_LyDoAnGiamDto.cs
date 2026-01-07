using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_LyDoAnGiam;

namespace C10.LyDoAnGiam.Dto
{
    [AutoMapTo(typeof(DM_LyDoAnGiam))]

    public class CreateDM_LyDoAnGiamDto
    {
        public string LDAG_NoiDung { get; set; }
        public string LDAG_Code { get; set; }
        public bool LDAG_IsActive { get; set; }
    }
}
