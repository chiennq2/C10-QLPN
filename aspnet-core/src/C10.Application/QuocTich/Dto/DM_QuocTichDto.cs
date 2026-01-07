using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.QuocTich.Dto
{
    public class DM_QuocTichDto : EntityDto<int>
    {
        public string QT_NoiDung { get; set; }
        public string QT_Code { get; set; }
        public bool QT_IsActive { get; set; }
    }
}
