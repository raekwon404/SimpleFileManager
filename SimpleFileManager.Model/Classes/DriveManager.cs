using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SimpleFileManager.Model.Classes
{
    public static class DriveManager
    {
        public static IEnumerable<DriveInfo> GetAllDrives() => DriveInfo.GetDrives();
    }
}
