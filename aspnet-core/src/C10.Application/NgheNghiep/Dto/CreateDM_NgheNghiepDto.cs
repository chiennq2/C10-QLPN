using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_NgheNghiep;

namespace C10.NgheNghiep.Dto
{
    [AutoMapTo(typeof(DM_NgheNghiep))]

    public class CreateDM_NgheNghiepDto
    {
        public string NN_NoiDung { get; set; }
        public string NN_Code { get; set; }
        public bool NN_IsActive { get; set; }
    }
}
