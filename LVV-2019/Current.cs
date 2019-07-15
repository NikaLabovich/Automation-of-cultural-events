using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVV_2019
{
    public static class Current
    {
        private static Users user;
        public static Users Users
        {
            get { return user; }
            set { user = value; }
        }
    }
}
