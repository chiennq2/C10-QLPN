using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_LyDoKhen;

namespace C10.LyDoKhen.Dto
{
    [AutoMapTo(typeof(DM_LyDoKhen))]
    public class CreateDM_LyDoKhenDto
    {
        public string LDK_NoiDung { get; set; }
        public string LDK_Code { get; set; }
        public bool LDK_IsActive { get; set; }
    }
}
