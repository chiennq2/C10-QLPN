using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.GhiChuRieng.Dto
{
    public class PageDM_GhiChuRiengResultDto : PagedResultRequestDto, IShouldNormalize  
    {
        public string Keyword { get; set; }

        public string Sorting { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "GCR_Ma";
            }

            Keyword = Keyword?.Trim();
        }
    }
}
