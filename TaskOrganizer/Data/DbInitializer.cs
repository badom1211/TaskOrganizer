using TaskOrganizer.Models;

namespace TaskOrganizer.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.Projects.Any()) return; // Baza već popunjena

            var projects = new Project[]
            {
                new Project { Name = "Glavni projekt", StartDate = DateTime.Now },
                new Project { Name = "Sekundarni projekt", StartDate = DateTime.Now }
            };

            context.Projects.AddRange(projects);
            context.SaveChanges();
        }
    }
}