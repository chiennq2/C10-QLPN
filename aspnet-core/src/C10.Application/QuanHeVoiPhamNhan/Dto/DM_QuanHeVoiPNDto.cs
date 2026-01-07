using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.QuanHeVoiPhamNhan.Dto
{
    public class DM_QuanHeVoiPNDto : EntityDto<int>
    {
        public string QHVPN_NoiDung { get; set; }
        public string QHVPN_Code { get; set; }
        public string QHVPN_TenGioiTinh { get; set; }
        public bool QHVPN_IsActive { get; set; }
    }
}
