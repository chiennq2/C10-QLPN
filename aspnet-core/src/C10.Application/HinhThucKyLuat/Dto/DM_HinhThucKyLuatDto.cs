using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.HinhThucKyLuat.Dto
{
    public class DM_HinhThucKyLuatDto : EntityDto<int>
    {
        public string HTKL_NoiDung { get; set; }
        public string HTKL_Code { get; set; }
        public bool HTKL_IsActive { get; set; }
    }
}
