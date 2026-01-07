using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_NgheNghiep;
using C10.NgheNghiep.Dto;

namespace C10.NgheNghiep
{
    public class DM_NgheNghiepAppService : AsyncCrudAppService<DM_NgheNghiep, DM_NgheNghiepDto, int, PageDM_NgheNghiepResultDto, CreateDM_NgheNghiepDto, DM_NgheNghiepDto>, IDM_NgheNghiepAppService
    {
        public DM_NgheNghiepAppService(IRepository<DM_NgheNghiep, int> repository) : base(repository)
        {
        }
    }
}
