using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_v39_Monday_Ovningar
{
    class Settings
    {
        public bool IsDarkMode { get; init; }
        public bool IsVerticleLayout { get; init; }
        public bool IsPowerUser { get; init; }

        public void ShowCurrentSettings()
        {
            Console.WriteLine($"Darkmode       : {IsDarkMode}");
            Console.WriteLine($"Power User     : {IsPowerUser}");
            Console.WriteLine($"Verticle Layout: {IsVerticleLayout}");
        }
    }


}
