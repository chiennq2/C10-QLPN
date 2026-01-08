using Abp.Application.Services;
using C10.LoaiTangGiamHinhPhat.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LoaiTangGiamHinhPhat
{
    public interface IDM_LoaiTangGiamHinhPhatAppService : IAsyncCrudAppService<DM_LoaiTangGiamHinhPhatDto, int, PageDM_LoaiTangGiamHinhPhatResultDto, CreateDM_LoaiTangGiamHinhPhatDto, DM_LoaiTangGiamHinhPhatDto>
    {
    }
}
