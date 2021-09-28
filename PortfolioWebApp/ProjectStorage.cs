using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioWebApp
{
    public static class ProjectStorage
    {
        public static List<Project> Projects { get; private set; } = new List<Project>()
        {
            new Project
            {
                Name = "2048WinFormsApp",
                Link = "https://github.com/MarinaEfremova78/WinFormsApps/tree/master/2048WinFormsApp",
                Description = "Игра 2048"
            },
            new Project
            {
                Name = "BallGamesWindowsFormsApp",
                Link = "https://github.com/MarinaEfremova78/WinFormsApps/tree/master/BallGamesWindowsFormsApp",
                Description = "Игры с шариками"
            }
        };

        public static void RemoveByName(string name)
        {
            Projects.RemoveAll(x => x.Name == name);
        }

        public static void Add(Project project)
        {
            Projects.Add(project);
        }
    }
}
