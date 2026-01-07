using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoKyLuat.Dto
{
    public class DM_LyDoKyLuatDto : EntityDto<int>
    {
        public string LDKL_NoiDung { get; set; }
        public string LDKL_Code { get; set; }
        public bool LDKL_IsActive { get; set; }
    }
}
