using Abp.AutoMapper;
using C10.Domain.DanhMuc.DM_CapToaXu;
using C10.Core.DanhMuc.DM_LyDoKhongXetGiam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoKhongXetGiam.Dto
{
    [AutoMapTo(typeof(DM_LyDoKhongXetGiam))]
    public class CreateDM_LyDoKhongXetGiamDto
    {
        public string LDKXG_NoiDung { get; set; }
        public string LDKXG_Code { get; set; }
        public bool LDKXG_IsActive { get; set; }
    }
}
