using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_LoaiTangGiamHinhPhat;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LoaiTangGiamHinhPhatRepository : MasterDataRepositoryBase<DM_LoaiTangGiamHinhPhat, int>, IDM_LoaiTangGiamHinhPhatRepository
    {
        public DM_LoaiTangGiamHinhPhatRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LoaiTangGiamHinhPhat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
