using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_QuocTich;
using C10.QuocTich.Dto;

namespace C10.QuocTich
{
    public class DM_QuocTichAppService : AsyncCrudAppService<DM_QuocTich, DM_QuocTichDto, int, PageDM_QuocTichResultDto, CreateDM_QuocTichDto, DM_QuocTichDto>, IDM_QuocTichAppService
    {
        public DM_QuocTichAppService(IRepository<DM_QuocTich, int> repository) : base(repository)
        {
        }
    }
}
