using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoKhongXetGiam.Dto
{
    public class DM_LyDoKhongXetGiamDto : EntityDto<int>
    {
        public string LDKXG_NoiDung { get; set; }
        public string LDKXG_Code { get; set; }
        public bool LDKXG_IsActive { get; set; }
    }
}
