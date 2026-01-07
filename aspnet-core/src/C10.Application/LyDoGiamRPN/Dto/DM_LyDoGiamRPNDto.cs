using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoGiamRPN.Dto
{
    public class DM_LyDoGiamRPNDto : EntityDto<int>
    {
        public string LDRGPN_NoiDung { get; set; }
        public string LDRGPN_Code { get; set; }
        public bool LDRGPN_IsActive { get; set; }
    }
}
