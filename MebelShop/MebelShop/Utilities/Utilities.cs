using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MebelShop.Utilities
{
    public static class Utilities
    {
        public static void RemoveFile(string root,string file)
        {
            var pathfull = Path.Combine(root, "images", file);
            if (File.Exists(pathfull))
            {
                File.Delete(pathfull);
            }
        }
    }
}
