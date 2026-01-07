using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.HocVan.Dto
{
    public class DM_HocVanDto : EntityDto<int>
    {
        public string HV_NoiDung { get; set; }
        public string HV_Code { get; set; }
        public bool HV_IsActive { get; set; }
    }
    
}
