using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_MucAnPhat;
using C10.MucAnPhat.Dto;

namespace C10.MucAnPhat
{
    public class DM_MucAnPhatAppService : AsyncCrudAppService<DM_MucAnPhat, DM_MucAnPhatDto, int, PageDM_MucAnPhatResultDto, CreateDM_MucAnPhatDto, DM_MucAnPhatDto>, IDM_MucAnPhatAppService
    {
        public DM_MucAnPhatAppService(IRepository<DM_MucAnPhat, int> repository) : base(repository)
        {
        }
    }
}
