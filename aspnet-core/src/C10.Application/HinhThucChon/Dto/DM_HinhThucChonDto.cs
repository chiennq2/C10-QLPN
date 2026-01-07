using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.HinhThucChon.Dto
{
    public class DM_HinhThucChonDto : EntityDto<int>
    {
        public string HTC_NoiDung { get; set; }
        public string HTC_Code { get; set; }
        public bool HTC_IsActive { get; set; }
    }
}
