using Microsoft.EntityFrameworkCore;

namespace TodoApp.Data
{
    public static class AutoMigration 
    {
        public static void Automigrate(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope()) //making a database if there is no one
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<TodoDbContext>())
                {
                    try
                    {
                        appContext.Database.Migrate(); //migration are there in the assembly update them on the database
                    }
                    catch (Exception ex)
                    {
                        //log errors or do anything you think it's needed
                        throw;
                    }
                }
            }
        }
    }
}