using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_DoTuoi;

namespace C10.DoTuoi.Dto
{
    [AutoMapTo(typeof(DM_DoTuoi))]

    public class CreateDM_DoTuoiDto
    {
        public string DT_NoiDung { get; set; }
        public string DT_Code { get; set; }
        public int DT_TuDoTuoi { get; set; }
        public int DT_DenDoTuoi { get; set; }
        public bool DT_IsActive { get; set; }
    }
}
