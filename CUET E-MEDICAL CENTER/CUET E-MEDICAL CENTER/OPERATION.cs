using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CUET_E_MEDICAL_CENTER
{
    class OPERATION
    {
             public MySqlConnection connection =
            new MySqlConnection("Server=localhost; Database=cuet_e-medicalcenter; Uid=root; Pwd=;");
        public void insertstudentinf(string s_id,string s_name,string s_pas)
        {
            try
            {
                connection.Open();
                string ss;
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText =
                    "INSERT INTO student_info(STUDENT_ID,STUDENT_NAME,STUDENT_PAS.) VALUES(@STUDENT_ID,@STUDENT_NAME,@STUDENT_PAS.)";
                cmd.Parameters.AddWithValue("@STUDENT_ID", s_id);
                cmd.Parameters.AddWithValue("@STUDENT_NAME", s_name);
                cmd.Parameters.AddWithValue("@STUDENT_PAS.", s_pas);
                ss = cmd.CommandText;
                MessageBox.Show(ss);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
                MessageBox.Show("Data Inserted");
            }
        }
    }
}
