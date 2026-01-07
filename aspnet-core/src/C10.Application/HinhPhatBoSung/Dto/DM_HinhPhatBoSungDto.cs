using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.HinhPhatBoSung.Dto
{
    public class DM_HinhPhatBoSungDto : EntityDto<int>
    {
        public string HPBS_NoiDung { get; set; }
        public string HPBS_Code { get; set; }
        public bool HPBS_IsActive { get; set; }
    }
    
}
