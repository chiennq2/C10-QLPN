using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.GioiTinh.Dto
{
    public class DM_GioiTinhDto : EntityDto<int>
    {
        public string GT_NoiDung { get; set; }
        public string GT_Code { get; set; }
        public bool GT_IsActive { get; set; }
    }
}
