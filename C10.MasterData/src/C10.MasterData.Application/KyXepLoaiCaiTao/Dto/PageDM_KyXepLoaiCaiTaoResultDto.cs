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
        public DateTime? KXLCT_Tu_Ngay { get; set; }
        public DateTime? KXLCT_Den_Ngay { get; set; }
        public bool? KXLCT_Trang_Thai { get; set; }
        public string Sorting { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "KXLCT_Ma";
            }

            Keyword = Keyword?.Trim();
        }
    }
}
