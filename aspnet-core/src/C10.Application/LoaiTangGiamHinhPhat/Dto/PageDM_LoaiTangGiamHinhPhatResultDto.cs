using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LoaiTangGiamHinhPhat.Dto
{
    public class PageDM_LoaiTangGiamHinhPhatResultDto : PagedResultRequestDto, IShouldNormalize
    {
        public string Keyword { get; set; }

        public string Sorting { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "LTGHP_Code";
            }

            Keyword = Keyword?.Trim();
        }
    }
}
