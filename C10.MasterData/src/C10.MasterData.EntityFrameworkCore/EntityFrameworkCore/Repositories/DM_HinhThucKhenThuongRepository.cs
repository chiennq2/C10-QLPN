using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_HinhThucKhenThuong;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_HinhThucKhenThuongRepository : MasterDataRepositoryBase<DM_HinhThucKhenThuong, int>, IDM_HinhThucKhenThuongRepository
    {
        public DM_HinhThucKhenThuongRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_HinhThucKhenThuong>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
