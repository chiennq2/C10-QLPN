using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_MucAnPhat
{
    public interface IDM_MucAnPhatRepository : IRepository<DM_MucAnPhat, int>
    {
        Task<IEnumerable<DM_MucAnPhat>> Getspecial(string[] pars);
    }
}
