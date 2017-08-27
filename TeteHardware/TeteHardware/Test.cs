using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TeteHardware
{
    public class Test
    {
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root");
        public void ChangeLog(string table, string field, string oldVal)
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("INSERT INTO tbl_changelog(empID, changeDate, changeTable, changeField, oldVal) VALUES('" + TeteHardware.Properties.Settings.Default.loginID + "','" + DateTime.Now.ToString() + "','" + table + "', '" + field + "', '" + oldVal + "')", conn);
                query.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Changelog() :" + x.ToString());
                conn.Close();
            }
        }

        public bool IsFloat(string input)
        {
            float test;
            return float.TryParse(input, out test);
        }

        public bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }
    }
}
