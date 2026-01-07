using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_TruongHopBat;

namespace C10.TruongHopBat.Dto
{
    [AutoMapTo(typeof(DM_TruongHopBat))]

    public class CreateDM_TruongHopBatDto
    {
        public string THB_NoiDung { get; set; }
        public string THB_Code { get; set; }
        public bool THB_IsActive { get; set; }
    }
}
