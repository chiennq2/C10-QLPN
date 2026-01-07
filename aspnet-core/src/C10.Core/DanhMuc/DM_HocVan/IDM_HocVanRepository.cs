using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_HocVan
{
    public interface IDM_HocVanRepository : IRepository<DM_HocVan, int>
    {
        Task<IEnumerable<DM_HocVan>> Getspecial(string[] pars);
    }
}
