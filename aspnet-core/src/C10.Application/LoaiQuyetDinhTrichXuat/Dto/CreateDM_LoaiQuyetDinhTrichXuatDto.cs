using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_LoaiQuyetDinhTrichXuat;

namespace C10.LoaiQuyetDinhTrichXuat.Dto
{
    [AutoMapTo(typeof(DM_LoaiQuyetDinhTrichXuat))]

    public class CreateDM_LoaiQuyetDinhTrichXuatDto
    {
        public string LQDTX_NoiDung { get; set; }
        public string LQDTX_Code { get; set; }
        public bool LQDTX_IsActive { get; set; }
    }
}
