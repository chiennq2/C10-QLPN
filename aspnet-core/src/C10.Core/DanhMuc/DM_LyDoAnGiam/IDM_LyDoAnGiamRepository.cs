using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_LyDoAnGiam
{
    public interface IDM_LyDoAnGiamRepository : IRepository<DM_LyDoAnGiam, int>
    {
        Task<IEnumerable<DM_LyDoAnGiam>> Getspecial(string[] pars);
    }
}
