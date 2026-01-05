namespace C10.EntityFrameworkCore.Seed.Host;

public class InitialHostDbBuilder
{
    private readonly C10DbContext _context;

    public InitialHostDbBuilder(C10DbContext context)
    {
        _context = context;
    }

    public void Create()
    {
        new DefaultEditionCreator(_context).Create();
        new DefaultLanguagesCreator(_context).Create();
        new HostRoleAndUserCreator(_context).Create();
        new DefaultSettingsCreator(_context).Create();

        _context.SaveChanges();
    }
}
