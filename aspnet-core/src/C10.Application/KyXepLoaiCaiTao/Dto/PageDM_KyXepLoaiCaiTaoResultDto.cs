using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.XepLoaiCaiTao.Dto
{
    public class PageDM_KyXepLoaiCaiTaoResultDto : PagedResultRequestDto, IShouldNormalize
    {
        public string Keyword { get; set; }
        public DateTime? XLCT_FromDate { get; set; }
        public DateTime? XLCT_ToDate { get; set; }
        public bool? XLCT_IsActive { get; set; }
        public string Sorting { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "XLCT_Code";
            }

            Keyword = Keyword?.Trim();
        }
    }
}
