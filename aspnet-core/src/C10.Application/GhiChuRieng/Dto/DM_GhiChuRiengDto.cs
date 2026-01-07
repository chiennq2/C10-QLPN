using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.GhiChuRieng.Dto
{
    public class DM_GhiChuRiengDto : EntityDto<int>
    {
        public string GCR_NoiDung { get; set; }
        public string GCR_Code { get; set; }
        public bool GCR_IsActive { get; set; }
    }
}
