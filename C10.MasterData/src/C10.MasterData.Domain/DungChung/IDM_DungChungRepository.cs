using Abp.Domain.Repositories;

namespace C10.MasterData.DungChung;

public interface IDM_DungChungRepository : IRepository<DM_DungChung, Guid>
{
    Task<IEnumerable<DM_DungChung>> Getspecial(string[] pars);
}

