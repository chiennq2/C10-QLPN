using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoKhen.Dto
{
    public class DM_LyDoKhenDto : EntityDto<int>
    {
        public string LDK_NoiDung { get; set; }
        public string LDK_Code { get; set; }
        public bool LDK_IsActive { get; set; }
    }
}
