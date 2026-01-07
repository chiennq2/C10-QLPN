using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LoaiQuyetDinhTrichXuat.Dto
{
    public class DM_LoaiQuyetDinhTrichXuatDto : EntityDto<int>
    {
        public string LQDTX_NoiDung { get; set; }
        public string LQDTX_Code { get; set; }
        public bool LQDTX_IsActive { get; set; }
    }
}
