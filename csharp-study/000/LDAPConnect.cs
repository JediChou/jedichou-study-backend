using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;

namespace LDAPConnect
{
    public class Program
    {
        string ldapUrl = "LDAP://127.0.0.1/o=sa, c=org";
        string ldapUserName = "cn=root, o=sa, c=org";
        string ldapPassword = "root";

        public Program(string ldap_url, string ladp_user, string ldap_password)
        {
            ldapUrl = ldap_url;
            ldapUserName = ladp_user;
            ldapPassword = ldap_password;
        }

        public bool login()
        {
            DirectoryEntry root = null;

            try
            {
                root = new DirectoryEntry(ldapUrl, ldapUserName, ldapPassword);
                string strName = root.Name;
                root.Close();
                root = null;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        static void Main(string[] args)
        {
            var LdapConn = new Program("LDAP://10.150.4.160", "F3231698", "KEKEHUcomeon14");
            Console.WriteLine(LdapConn.login());
        }
    }
}
