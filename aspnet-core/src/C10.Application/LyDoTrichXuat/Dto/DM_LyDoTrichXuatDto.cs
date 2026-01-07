using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoTrichXuat.Dto
{
    public class DM_LyDoTrichXuatDto : EntityDto<int>
    {
        public string LDTX_NoiDung { get; set; }
        public string LDTX_Code { get; set; }
        public bool LDTX_IsActive { get; set; }
    }
}
