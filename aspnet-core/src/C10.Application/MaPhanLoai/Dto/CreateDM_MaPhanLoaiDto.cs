using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_MaPhanLoai;

namespace C10.MaPhanLoai.Dto
{
    [AutoMapTo(typeof(DM_MaPhanLoai))]

    public class CreateDM_MaPhanLoaiDto
    {
        public string MPL_NoiDung { get; set; }
        public string MPL_Code { get; set; }
        public bool MPL_IsActive { get; set; }
    }
}
