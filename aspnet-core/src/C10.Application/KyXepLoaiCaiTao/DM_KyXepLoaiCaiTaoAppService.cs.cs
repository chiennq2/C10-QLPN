using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_KyXepLoaiCaiTao;
using C10.XepLoaiCaiTao.Dto;

namespace C10.XepLoaiCaiTao
{
    public class DM_KyXepLoaiCaiTaoAppService : AsyncCrudAppService<DM_KyXepLoaiCaiTao, DM_KyXepLoaiCaiTaoDto, int, PageDM_KyXepLoaiCaiTaoResultDto, CreateDM_KyXepLoaiCaiTaoDto, DM_KyXepLoaiCaiTaoDto>, IDM_KyXepLoaiCaiTaoAppService
    {
        public DM_KyXepLoaiCaiTaoAppService(IRepository<DM_KyXepLoaiCaiTao, int> repository) : base(repository)
        {
        }
    }
}
