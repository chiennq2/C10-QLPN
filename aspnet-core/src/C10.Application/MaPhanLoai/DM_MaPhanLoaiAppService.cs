using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_MaPhanLoai;
using C10.MaPhanLoai.Dto;

namespace C10.MaPhanLoai
{
    public class DM_MaPhanLoaiAppService : AsyncCrudAppService<DM_MaPhanLoai, DM_MaPhanLoaiDto, int, PageDM_MaPhanLoaiResultDto, CreateDM_MaPhanLoaiDto, DM_MaPhanLoaiDto>, IDM_MaPhanLoaiAppService
    {
        public DM_MaPhanLoaiAppService(IRepository<DM_MaPhanLoai, int> repository) : base(repository)
        {
        }
    }
}
