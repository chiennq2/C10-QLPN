using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LoaiPhanLoai.Dto
{
    public class DM_LoaiPhanLoaiDto : EntityDto<int>
    {
        public string LPL_NoiDung { get; set; }
        public string LPL_Code { get; set; }
        public bool LPL_IsActive { get; set; }
    }
}
