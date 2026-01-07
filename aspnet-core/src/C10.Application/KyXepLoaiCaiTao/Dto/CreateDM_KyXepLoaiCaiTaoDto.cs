using Abp.AutoMapper;
using C10.Core.DanhMuc.DM_KyXepLoaiCaiTao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.XepLoaiCaiTao.Dto
{
    [AutoMapTo(typeof(DM_KyXepLoaiCaiTao))]

    public class CreateDM_KyXepLoaiCaiTaoDto
    {
        public string XLCT_NoiDung { get; set; }
        public string XLCT_Code { get; set; }
        public int XLCT_Year { get; set; }
        public DateTime? XLCT_FromDate { get; set; }
        public DateTime? XLCT_ToDate { get;set; }
        public bool XLCT_IsActive { get; set; }
    }
}
