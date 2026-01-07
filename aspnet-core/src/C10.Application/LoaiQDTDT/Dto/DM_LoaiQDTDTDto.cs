using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LoaiQDTDT.Dto
{
    public class DM_LoaiQDTDTDto : EntityDto<int>
    {
        public string LQDTDT_NoiDung { get; set; }
        public string LQDTDT_Code { get; set; }
        public bool LQDTDT_IsActive { get; set; }
    }
}
