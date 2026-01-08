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
        public string LQDTX_Ten { get; set; }
        public string LQDTX_Ma { get; set; }
        public bool LQDTX_Trang_Thai { get; set; }
    }
}
