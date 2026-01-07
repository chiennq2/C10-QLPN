using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.BenhTat.Dto
{
    public class DM_BenhTatDto : EntityDto<int>
    {
        public string BT_NoiDung { get; set; }
        public string BT_Code { get;set; } 
        public bool BT_IsActive { get; set; }
    }
}
