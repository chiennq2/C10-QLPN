using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_HinhPhatBoSung;

namespace C10.HinhPhatBoSung.Dto
{
    [AutoMapTo(typeof(DM_HinhPhatBoSung))]

    public class CreateDM_HinhPhatBoSungDto
    {
        public string HPBS_NoiDung { get; set; }
        public string HPBS_Code { get; set; }
        public bool HPBS_IsActive { get; set; }
    }
}
