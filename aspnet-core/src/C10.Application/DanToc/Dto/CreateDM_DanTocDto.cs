using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_DanToc;

namespace C10.DanToc.Dto
{
    [AutoMapTo(typeof(DM_DanToc))]
    public class CreateDM_DanTocDto
    {
        public string DT_NoiDung { get; set; }
        public string DT_Code { get; set; }
        public bool DT_IsActive { get; set; }
    }
}
