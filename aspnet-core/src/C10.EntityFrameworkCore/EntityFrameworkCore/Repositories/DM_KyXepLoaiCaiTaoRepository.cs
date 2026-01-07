using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_KyXepLoaiCaiTao;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_KyXepLoaiCaiTaoRepository : C10RepositoryBase<DM_KyXepLoaiCaiTao, int>, IDM_KyXepLoaiCaiTaoRepository
    {
        public DM_KyXepLoaiCaiTaoRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_KyXepLoaiCaiTao>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
