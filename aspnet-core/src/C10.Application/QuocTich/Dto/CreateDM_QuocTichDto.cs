using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_QuocTich;

namespace C10.QuocTich.Dto
{
    [AutoMapTo(typeof(DM_QuocTich))]

    public class CreateDM_QuocTichDto
    {
        public string QT_NoiDung { get; set; }
        public string QT_Code { get; set; }
        public bool QT_IsActive { get; set; }
    }
}
