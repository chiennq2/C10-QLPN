using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_DanToc
{
    public interface IDM_DanTocRepository : IRepository<DM_DanToc, int>
    {
        Task<IEnumerable<DM_DanToc>> Getspecial(string[] pars);
    }
}
