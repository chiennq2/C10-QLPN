using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_XuLyBat;

namespace C10.XuLyBat.Dto
{
    [AutoMapTo(typeof(DM_XuLyBat))]

    public class CreateDM_XuLyBatDto
    {
        public string XLB_NoiDung { get; set; }
        public string XLB_Code { get; set; }
        public bool XLB_IsActive { get; set; }
    }
}
