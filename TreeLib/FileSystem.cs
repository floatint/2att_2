using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLib
{
    //base class
    internal class FileSystemObject
    {
        public string Name;

        public FileSystemObject(string name)
        {
            Name = name;
        }
    }

    //file object
    internal class FileObject : FileSystemObject
    {
        public long LastAccessDate;

        public FileObject(string name, long accessDate) : base(name)
        {
            LastAccessDate = accessDate;
        }
    }

    //just inherit
    internal class FolderObject : FileSystemObject
    {
        public FolderObject(string name) : base(name)
        { }
    }
}
