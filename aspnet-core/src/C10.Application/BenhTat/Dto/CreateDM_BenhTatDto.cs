using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_BenhTat;

namespace C10.BenhTat.Dto
{
    [AutoMapTo(typeof(DM_BenhTat))]
    public class CreateDM_BenhTatDto
    {
        public string BT_NoiDung { get; set; }
        public string BT_Code { get; set; }   
        public bool BT_IsActive { get; set; }
    }
}
