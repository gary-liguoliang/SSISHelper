using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace SSISHelper.com.liguoliang.ssis.util
{
    class FileUtils
    {
        /**
         * Get all DTSx packages.
         */
        public static String[] GetAllDtsPkgs(String pathRoot)
        {
            String[] dtsFiles = Directory.GetFiles(pathRoot, "*dtsx", SearchOption.AllDirectories);
           return dtsFiles;
        }

        public static Boolean IsDirectory(String path)
        {
            return Directory.Exists(path);
        }

        public static Boolean IsFile(String path) 
        {
            return !IsDirectory(path);
        }


        // Should use Directory.GetFiles(path, "*", SearchOption.AllDirectories);
        private static void GenerateAllFileNames(String path, ArrayList fileNames)
        {

            String[] pathSubs = Directory.GetFiles(path);
            foreach (string pathSub in pathSubs)
            {
                fileNames.Add(pathSub);
               // getAllFileNames(pathSub, fileNames);
            }

            String[] subFolders = Directory.GetDirectories(path);
            foreach (String subFolder in subFolders)
            {
                GenerateAllFileNames(subFolder, fileNames);
            }
        }
   }
    
}
