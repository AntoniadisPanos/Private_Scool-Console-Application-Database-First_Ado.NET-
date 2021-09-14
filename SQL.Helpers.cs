using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Scool_Assignment_PartB_
{
    public static class SQLHelpers
    {
        private const string connectionString = "Data Source=.; Initial Catalog=Private_School; Integrated Security=true;";
        
        
        public static SqlDataReader GetExecuteDataReader(string queryString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);

            connection.Open();

            return command.ExecuteReader();
        }

        public static string ReaderStringPadding(object dataReader, int stringLength)
        {
            
            string strPadding = dataReader.ToString();
            strPadding = strPadding.PadRight(stringLength).Substring(0, stringLength);
            return strPadding;
        }

        public static string ColNameStrPadding(string dbString, int strToPad)
        {
           

            dbString = dbString.PadRight(strToPad).Substring(0, strToPad);
            return dbString;


        }

        public static string StringValidation(string validationInput)
        {
             
            while (true)
            {

                if (validationInput.Any(char.IsDigit) || string.IsNullOrEmpty(validationInput))
                {
                    Console.Clear();
                    Console.Write("Please Enter a valid Name: ");
                    validationInput = Console.ReadLine();
                }
                else
                    break;
               

                
            }
            return validationInput;
        }
       
    }
}
