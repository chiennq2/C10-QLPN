using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.HinhThucKhenThuong.Dto
{
    public class DM_HinhThucKhenThuongDto : EntityDto<int>
    {
        public string HTKT_NoiDung { get; set; }
        public string HTKT_Code { get; set; }
        public bool HTKT_IsActive { get; set; }
    }
}
