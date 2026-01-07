using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.XepLoaiCaiTao.Dto
{
    public class DM_KyXepLoaiCaiTaoDto : EntityDto<int>
    {
        public string XLCT_NoiDung { get; set; }
        public string XLCT_Code { get; set; }
        public int XLCT_Year { get; set; }
        public DateTime? XLCT_FromDate { get; set; }
        public DateTime? XLCT_ToDate { get; set; }
        public bool XLCT_IsActive { get; set; }
    }
}
