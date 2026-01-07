using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_TruongHopBat
{
    public interface IDM_TruongHopBatRepository : IRepository<DM_TruongHopBat, int>
    {
        Task<IEnumerable<DM_TruongHopBat>> Getspecial(string[] pars);
    }
}
