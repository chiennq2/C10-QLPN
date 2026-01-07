using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_HinhThucChon;
using C10.HinhThucChon.Dto;

namespace C10.HinhThucChon
{
    public class DM_HinhThucChonAppService : AsyncCrudAppService<DM_HinhThucChon, DM_HinhThucChonDto, int, PageDM_HinhThucChonResultDto, CreateDM_HinhThucChonDto, DM_HinhThucChonDto>, IDM_HinhThucChonAppService
    {
        public DM_HinhThucChonAppService(IRepository<DM_HinhThucChon, int> repository) : base(repository)
        {
        }
    }
}
