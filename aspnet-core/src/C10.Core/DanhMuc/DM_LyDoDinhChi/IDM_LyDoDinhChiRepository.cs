using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_LyDoDinhChi
{
    public interface IDM_LyDoDinhChiRepository : IRepository<DM_LyDoDinhChi, int>
    {
        Task<IEnumerable<DM_LyDoDinhChi>> Getspecial(string[] pars);
    }
}
