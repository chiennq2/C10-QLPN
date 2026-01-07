using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoAnGiam.Dto
{
    public class DM_LyDoAnGiamDto : EntityDto<int>
    {
        public string LDAG_NoiDung { get; set; }
        public string LDAG_Code { get; set; }
        public bool LDAG_IsActive { get; set; }
    }
}
