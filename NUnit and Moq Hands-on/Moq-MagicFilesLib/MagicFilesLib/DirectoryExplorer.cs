using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace MagicFilesLib
{
    public class DirectoryExplorer : IDirectoryExplorer
    {

        IDirectoryExplorer d;

        public DirectoryExplorer(IDirectoryExplorer d)
        {
            this.d = d;
        }
        public ICollection<string> GetFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            
            return files;
        }
    }
}