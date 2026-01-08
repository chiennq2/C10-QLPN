using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;

namespace C10.MasterData.DungChung.Dto
{
    public class PagedDM_DungChungResultDto : PagedResultRequestDto, IShouldNormalize
    {
        public string Keyword { get; set; }
        public int? Status { get; set; }

        public string Sorting { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Title";
            }

            Keyword = Keyword?.Trim();
        }
    }
}
