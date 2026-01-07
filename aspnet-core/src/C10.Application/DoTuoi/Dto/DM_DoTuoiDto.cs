using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DoTuoi.Dto
{
    public class DM_DoTuoiDto : EntityDto<int>
    {
        public string DT_NoiDung { get; set; }
        public string DT_Code { get; set; }
        public int DT_TuDoTuoi { get; set; }
        public int DT_DenDoTuoi { get; set; }
        public bool DT_IsActive { get; set; }
    }
}
