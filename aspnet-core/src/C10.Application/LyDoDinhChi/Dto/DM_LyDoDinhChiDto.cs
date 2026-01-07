using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoDinhChi.Dto
{
    public class DM_LyDoDinhChiDto : EntityDto<int>
    {
        public string LDDC_NoiDung { get; set; }
        public string LDDC_Code { get; set; }
        public bool LDDC_IsActive { get; set; }
    }
}
