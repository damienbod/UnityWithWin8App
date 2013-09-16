using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class File1Repository : IFile1Repository
    {
        public string GetFileNameTest()
        {
            return "File name...";
        }
    }
}
