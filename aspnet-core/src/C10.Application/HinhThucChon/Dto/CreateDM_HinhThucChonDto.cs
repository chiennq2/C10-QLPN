using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_HinhThucChon;

namespace C10.HinhThucChon.Dto
{
    [AutoMapTo(typeof(DM_HinhThucChon))]

    public class CreateDM_HinhThucChonDto
    {
        public string HTC_NoiDung { get; set; }
        public string HTC_Code { get; set; }
        public bool HTC_IsActive { get; set; }
    }
}
