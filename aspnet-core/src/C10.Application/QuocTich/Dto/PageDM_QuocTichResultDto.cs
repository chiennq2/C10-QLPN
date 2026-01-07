using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.QuocTich.Dto
{
    public class PageDM_QuocTichResultDto : PagedResultRequestDto, IShouldNormalize
    {
        public string Keyword { get; set; }

        public string Sorting { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "QT_Code";
            }

            Keyword = Keyword?.Trim();
        }
    }
}
