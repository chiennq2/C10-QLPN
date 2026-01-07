using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MucAnPhat.Dto
{
    public class DM_MucAnPhatDto : EntityDto<int>
    {
        public string MAP_NoiDung { get; set; }
        public string MAP_Code { get; set; }
        public int MAP_TuMucAn { get; set; }
        public int MAP_DenMucAn { get; set; }
        public bool MAP_IsActive { get; set; }
    }
}
