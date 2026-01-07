using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_GioiTinh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.GioiTinh.Dto
{
    [AutoMapTo(typeof(DM_GioiTinh))]
    public class CreateDM_GioiTinhDto
    {
        public string GT_NoiDung { get; set; }
        public string GT_Code { get; set; }
        public bool GT_IsActive { get; set; }
    }
}
