using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_MucAnPhat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MucAnPhat.Dto
{
    [AutoMapTo(typeof(DM_MucAnPhat))]
    public class CreateDM_MucAnPhatDto
    {
        public string MAP_NoiDung { get; set; }
        public string MAP_Code { get; set; }
        public int MAP_TuMucAn { get; set; }
        public int MAP_DenMucAn { get; set; }
        public bool MAP_IsActive { get; set; }
    }
}
