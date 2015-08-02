using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileManager.Model.Classes
{
    public static class DriveManager
    {
        public static IEnumerable<DriveInfo> GetAllDrives() => DriveInfo.GetDrives();
    }
}
