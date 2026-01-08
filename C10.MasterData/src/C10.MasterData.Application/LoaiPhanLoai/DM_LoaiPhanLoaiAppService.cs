using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.MasterData.Domain.DanhMuc.DM_LoaiPhanLoai;
using C10.LoaiPhanLoai.Dto;

namespace C10.LoaiPhanLoai
{
    public class DM_LoaiPhanLoaiAppService : AsyncCrudAppService<DM_LoaiPhanLoai, DM_LoaiPhanLoaiDto, int, PageDM_LoaiPhanLoaiResultDto, CreateDM_LoaiPhanLoaiDto, DM_LoaiPhanLoaiDto>, IDM_LoaiPhanLoaiAppService
    {
        public DM_LoaiPhanLoaiAppService(IRepository<DM_LoaiPhanLoai, int> repository) : base(repository)
        {
        }
    }
}
