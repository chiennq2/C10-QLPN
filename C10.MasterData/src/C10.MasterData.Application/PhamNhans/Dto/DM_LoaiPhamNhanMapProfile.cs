using AutoMapper;
using C10.MasterData.Domain.DanhMuc.DM_LoaiPhamNhan;

namespace C10.PhamNhans.Dto;

public class DM_LoaiPhamNhanMapProfile : Profile
{
    public DM_LoaiPhamNhanMapProfile()
    {
        CreateMap<DM_LoaiPhamNhan, DM_LoaiPhamNhanDto>();
        CreateMap<CreateDM_LoaiPhamNhanDto, DM_LoaiPhamNhan>();
        CreateMap<DM_LoaiPhamNhanDto, DM_LoaiPhamNhan>();
    }
}
