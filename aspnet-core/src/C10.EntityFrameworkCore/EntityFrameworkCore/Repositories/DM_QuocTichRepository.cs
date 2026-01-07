using Abp.EntityFrameworkCore;
using C10.Domain.DanhMuc.DM_QuanHeVoiPN;
using C10.Core.DanhMuc.DM_QuocTich;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_QuocTichRepository : C10RepositoryBase<DM_QuocTich, int>, IDM_QuocTichRepository
    {
        public DM_QuocTichRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_QuocTich>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
