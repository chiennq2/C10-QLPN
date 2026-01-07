using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_LoaiQDTDT;

namespace C10.LoaiQDTDT.Dto
{
    [AutoMapTo(typeof(DM_LoaiQDTDT))]
    public class CreateDM_LoaiQDTDTDto
    {
        public string LQDTDT_NoiDung { get; set; }
        public string LQDTDT_Code { get; set; }
        public bool LQDTDT_IsActive { get; set; }
    }
}
