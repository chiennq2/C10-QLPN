using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_DoTuoi
{
    public interface IDM_DoTuoiRepository : IRepository<DM_DoTuoi, int>
    {
        Task<IEnumerable<DM_DoTuoi>> Getspecial(string[] pars);
    }
}
