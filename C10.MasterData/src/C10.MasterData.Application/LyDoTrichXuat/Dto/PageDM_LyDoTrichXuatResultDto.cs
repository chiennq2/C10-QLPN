using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoTrichXuat.Dto
{
    public class PageDM_LyDoTrichXuatResultDto : PagedResultRequestDto, IShouldNormalize
    {
        public string Keyword { get; set; }

        public string Sorting { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "LDTX_Ma";
            }

            Keyword = Keyword?.Trim();
        }
    }
}
