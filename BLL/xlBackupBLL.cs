using Hotel_Management.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.BLL
{
    class xlBackupBLL
    {
        public int xlBackup(string path)
        {

            BackupDAL xl = new BackupDAL();
            return xl.xlBackup(path);

        }
    }
}
