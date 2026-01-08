using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_LoaiQDTDC;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LoaiQDTDTRepository : MasterDataRepositoryBase<DM_LoaiQDTDC, int>, IDM_LoaiQDTDCRepository
    {
        public DM_LoaiQDTDTRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LoaiQDTDC>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
