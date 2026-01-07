using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_LoaiTangGiamHinhPhat;

namespace C10.LoaiTangGiamHinhPhat.Dto
{
    [AutoMapTo(typeof(DM_LoaiTangGiamHinhPhat))]
    public class CreateDM_LoaiTangGiamHinhPhatDto
    {
        public string LTGHP_NoiDung { get; set; }
        public string LTGHP_Code { get; set; }
        public bool LTGHP_IsActive { get; set; }
    }
}
