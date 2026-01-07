using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.TruongHopBat.Dto
{
    public class DM_TruongHopBatDto : EntityDto<int>
    {
        public string THB_NoiDung { get; set; }
        public string THB_Code { get; set; }
        public bool THB_IsActive { get; set; }
    }
}
