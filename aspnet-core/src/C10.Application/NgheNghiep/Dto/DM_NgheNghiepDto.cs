using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.NgheNghiep.Dto
{
    public class DM_NgheNghiepDto : EntityDto<int>
    {
        public string NN_NoiDung { get; set; }
        public string NN_Code { get; set; }
        public bool NN_IsActive { get; set; }
    }
}
