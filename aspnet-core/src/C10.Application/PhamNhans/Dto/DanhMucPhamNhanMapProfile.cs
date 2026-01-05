using AutoMapper;
using C10.PhamNhans;

namespace C10.PhamNhans.Dto;

public class DanhMucPhamNhanMapProfile : Profile
{
    public DanhMucPhamNhanMapProfile()
    {
        CreateMap<DanhMucPhamNhan, DanhMucPhamNhanDto>();
        CreateMap<CreateDanhMucPhamNhanDto, DanhMucPhamNhan>();
        CreateMap<DanhMucPhamNhanDto, DanhMucPhamNhan>();
    }
}
