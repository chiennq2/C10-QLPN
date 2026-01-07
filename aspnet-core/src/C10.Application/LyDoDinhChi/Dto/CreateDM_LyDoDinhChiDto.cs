using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_LyDoDinhChi;

namespace C10.LyDoDinhChi.Dto
{
    [AutoMapTo(typeof(DM_LyDoDinhChi))]
    public class CreateDM_LyDoDinhChiDto
    {
        public string LDDC_NoiDung { get; set; }
        public string LDDC_Code { get; set; }
        public bool LDDC_IsActive { get; set; }
    }
}
