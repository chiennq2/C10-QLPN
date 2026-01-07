using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_LyDoGiamRPN;
using C10.LyDoGiamRPN.Dto;

namespace C10.LyDoGiamRPN
{
    public class DM_LyDoGiamRPNAppService : AsyncCrudAppService<DM_LyDoGiamRPN, DM_LyDoGiamRPNDto, int, PageDM_LyDoGiamRPNResultDto, CreateDM_LyDoGiamRPNDto, DM_LyDoGiamRPNDto>, IDM_LyDoGiamRPNAppService
    {
        public DM_LyDoGiamRPNAppService(IRepository<DM_LyDoGiamRPN, int> repository) : base(repository)
        {
        }
    }
}
