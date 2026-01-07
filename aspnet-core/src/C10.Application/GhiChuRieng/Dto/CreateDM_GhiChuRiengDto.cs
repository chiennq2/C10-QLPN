using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_GhiChuRieng;


namespace C10.GhiChuRieng.Dto
{
    [AutoMapTo(typeof(DM_GhiChuRieng))]

    public class CreateDM_GhiChuRiengDto
    {
        public string GCR_NoiDung { get; set; }
        public string GCR_Code { get; set; }
        public bool GCR_IsActive { get; set; }
    }
}
