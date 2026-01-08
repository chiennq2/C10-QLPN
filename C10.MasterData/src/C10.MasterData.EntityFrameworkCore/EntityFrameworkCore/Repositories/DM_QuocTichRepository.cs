using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_QuocTich;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_QuocTichRepository : MasterDataRepositoryBase<DM_QuocTich, int>, IDM_QuocTichRepository
    {
        public DM_QuocTichRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_QuocTich>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
