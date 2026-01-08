using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_CapToaXu
{
    public interface IDM_CapToaXuRepository : IRepository<DM_CapToaXu, int>
    {
        Task<IEnumerable<DM_CapToaXu>> Getspecial(string[] pars);
    }
}
