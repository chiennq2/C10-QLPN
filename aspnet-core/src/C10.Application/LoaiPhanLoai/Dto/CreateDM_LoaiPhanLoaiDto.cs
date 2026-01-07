using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_LoaiPhanLoai;

namespace C10.LoaiPhanLoai.Dto
{
    [AutoMapTo(typeof(DM_LoaiPhanLoai))]
    public class CreateDM_LoaiPhanLoaiDto
    {
        public string LPL_NoiDung { get; set; }
        public string LPL_Code { get; set; }
        public bool LPL_IsActive { get; set; }
    }
}
