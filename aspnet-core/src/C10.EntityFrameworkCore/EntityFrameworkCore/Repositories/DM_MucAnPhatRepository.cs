using Abp.EntityFrameworkCore;
using C10.Domain.DanhMuc.DM_MaPhanLoai;
using C10.Core.DanhMuc.DM_MucAnPhat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_MucAnPhatRepository : C10RepositoryBase<DM_MucAnPhat, int>, IDM_MucAnPhatRepository
    {
        public DM_MucAnPhatRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_MucAnPhat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
