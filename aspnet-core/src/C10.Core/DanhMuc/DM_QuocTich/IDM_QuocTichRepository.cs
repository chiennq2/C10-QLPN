using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_QuocTich
{
    public interface IDM_QuocTichRepository : IRepository<DM_QuocTich, int>
    {
        Task<IEnumerable<DM_QuocTich>> Getspecial(string[] pars);
    }
}
