using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_CapToaXu;

namespace C10.CapToaXu.Dto
{
    [AutoMapTo(typeof(DM_CapToaXu))]
    public class CreateDM_CapToaXuDto
    {
        public string CTX_NoiDung { get; set; }
        public string CTX_Code { get; set; }
        public bool CTX_IsActive { get; set; }
    }
}
