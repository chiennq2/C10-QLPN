using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.XuLyBat.Dto
{
    public class DM_XuLyBatDto : EntityDto<int>
    {
        public string XLB_NoiDung { get; set; }
        public string XLB_Code { get; set; }
        public bool XLB_IsActive { get; set; }
    }
}
