using System;
using System.IO;

namespace SSISHelper.Util
{
    public class FileUtils
    {
        public static String[] GetDTSFileList(String path)
        {
            if (Directory.Exists(path))
            {
                return Directory.GetFiles(path, "*.dtsx", SearchOption.AllDirectories);
            }
            else if (File.Exists(path) && Path.GetExtension(path) == "dtsx")
            {
                return new String[] { path };
            }
            else
            {
                return new String[]{};
            }

        }
    }
}
