using Abp.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.MasterData.DungChung;

public class DM_DungChungRepository : MasterDataRepositoryBase<DM_DungChung, Guid>, IDM_DungChungRepository
{
    public DM_DungChungRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public Task<IEnumerable<DM_DungChung>> Getspecial(string[] pars)
    {
        throw new NotImplementedException();
    }
}
