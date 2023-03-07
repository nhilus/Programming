using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Migrations;

namespace ProjetoFinal.Web.Blazor.Shared.Utilities
{
    public class SyncfusionDatabaseUtilities
    {
        public IDbContextFactory<PfaDbContext> DbFactory;

        public SyncfusionDatabaseUtilities(IDbContextFactory<PfaDbContext> dbFactory)
        {
            DbFactory = dbFactory;
        }

        public async Task SyncfusionDatabaseActionAsync<T>(T entity, string action)
        {
            PfaDbContext dbContext = await DbFactory.CreateDbContextAsync();

            switch (action)
            {
                case null:
                case "":
                    return;

                case "Add":
                    await dbContext.AddAsync(entity);
                    break;

                case "Edit":
                    dbContext.Update(entity);
                    break;

                case "Delete":
                    dbContext.Remove(entity);
                    break;

                default:
                    throw new Exception("Action not supported. Supported actions: 'Add' and 'Edit'.");
            }

            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}