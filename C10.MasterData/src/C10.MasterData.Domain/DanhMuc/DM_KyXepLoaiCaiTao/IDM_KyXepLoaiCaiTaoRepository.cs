using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_KyXepLoaiCaiTao
{
    public interface IDM_KyXepLoaiCaiTaoRepository : IRepository<DM_KyXepLoaiCaiTao, int>
    {
        Task<IEnumerable<DM_KyXepLoaiCaiTao>> Getspecial(string[] pars);
    }
}
