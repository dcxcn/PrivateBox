using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace PrivateBox.Model
{
    class DBSource
    {
        public static string connectionString_pbox;
        public static string connectionString_pdata;
        private static string adminName;
        private static Boolean isAdmin;
        public static string ConnectionStringPBox
        {
            get
            {
                return connectionString_pbox;
            }
            set
            {
                connectionString_pbox = value;
            }
        }

        public static string ConnectionStringPData
        {
            get
            {
                return connectionString_pdata;
            }
            set
            {
                connectionString_pdata = value;
            }
        }
        public static string AdminName
        {
            get
            {
                return adminName;
            }
            set
            {
                adminName = value;
            }
        }
        public static Boolean ISAdmin
        {
            get
            {
                return isAdmin;
            }
            set
            {
                isAdmin = value;
            }
        }
    }
}
