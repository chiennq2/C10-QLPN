using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_LoaiTangGiamHinhPhat;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LoaiTangGiamHinhPhatRepository : C10RepositoryBase<DM_LoaiTangGiamHinhPhat, int>, IDM_LoaiTangGiamHinhPhatRepository
    {
        public DM_LoaiTangGiamHinhPhatRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LoaiTangGiamHinhPhat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
