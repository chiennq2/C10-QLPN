using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MaPhanLoai.Dto
{
    public class DM_MaPhanLoaiDto : EntityDto<int>
    {
        public string MPL_NoiDung { get; set; }
        public string MPL_Code { get; set; }
        public bool MPL_IsActive { get; set; }
    }
}
