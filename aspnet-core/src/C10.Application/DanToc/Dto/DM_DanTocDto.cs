using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanToc.Dto
{
    public class DM_DanTocDto : EntityDto<int>
    {
        public string DT_NoiDung { get; set; }
        public string DT_Code { get; set; }
        public bool DT_IsActive { get; set; }
    }
    
}
