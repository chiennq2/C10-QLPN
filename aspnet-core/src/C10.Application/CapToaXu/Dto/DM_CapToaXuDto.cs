using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.CapToaXu.Dto
{
    public class DM_CapToaXuDto : EntityDto<int>
    {
        public string CTX_NoiDung { get; set; }
        public string CTX_Code { get; set; }
        public bool CTX_IsActive { get; set; }
    }
}
