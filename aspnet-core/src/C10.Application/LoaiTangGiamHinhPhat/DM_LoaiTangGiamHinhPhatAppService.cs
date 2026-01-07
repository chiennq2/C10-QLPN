using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_LoaiTangGiamHinhPhat;
using C10.LoaiTangGiamHinhPhat.Dto;

namespace C10.LoaiTangGiamHinhPhat
{
    public class DM_LoaiTangGiamHinhPhatAppService : AsyncCrudAppService<DM_LoaiTangGiamHinhPhat, DM_LoaiTangGiamHinhPhatDto, int, PageDM_LoaiTangGiamHinhPhatResultDto, CreateDM_LoaiTangGiamHinhPhatDto, DM_LoaiTangGiamHinhPhatDto>, IDM_LoaiTangGiamHinhPhatAppService
    {
        public DM_LoaiTangGiamHinhPhatAppService(IRepository<DM_LoaiTangGiamHinhPhat, int> repository) : base(repository)
        {
        }
    }
}
