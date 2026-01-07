using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_LyDoGiamRPN;

namespace C10.LyDoGiamRPN.Dto
{
    [AutoMapTo(typeof(DM_LyDoGiamRPN))]

    public class CreateDM_LyDoGiamRPNDto
    {
        public string LDRGPN_NoiDung { get; set; }
        public string LDRGPN_Code { get; set; }
        public bool LDRGPN_IsActive { get; set; }
    }
}
