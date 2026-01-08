using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_KyXepLoaiCaiTao;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_KyXepLoaiCaiTaoRepository : MasterDataRepositoryBase<DM_KyXepLoaiCaiTao, int>, IDM_KyXepLoaiCaiTaoRepository
    {
        public DM_KyXepLoaiCaiTaoRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_KyXepLoaiCaiTao>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
