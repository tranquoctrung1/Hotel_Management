using Hotel_Management.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.BLL
{
    class xlRetoreBLL
    {
        public int xlRetore(string path)
        {
            RetoreDAL retore = new RetoreDAL();
            return retore.xlRetore(path);
        }
    }
}
