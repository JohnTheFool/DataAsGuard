using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAsGuard.PermissionMethods
{
    class Permissions
    {
        public Boolean CheckIfUserCanRead()
        {
            return false;
        }

        public Boolean CheckIfUserCanWrite()
        {
            return false;
        }

        public Boolean CheckIfUserCanDownload()
        {
            return false;
        }
    }
}
