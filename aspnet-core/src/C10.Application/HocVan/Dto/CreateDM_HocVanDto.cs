using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_HocVan;

namespace C10.HocVan.Dto
{
    [AutoMapTo(typeof(DM_HocVan))]
    public class CreateDM_HocVanDto
    {
        public string HV_NoiDung { get; set; }
        public string HV_Code { get; set; }
        public bool HV_IsActive { get; set; }
    }
}
