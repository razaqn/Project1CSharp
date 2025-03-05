using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class GlobalVariable
    {
        public static string kode;
        public static string name;
        public static string email;
        public static int role;

        private static int sequence = 1;

        public static string trid()
        {
            Koneksi con = new Koneksi();
            string query = "SELECT TOP 1 TransNumber FROM transactions.header ORDER BY TransNumber DESC";
            SqlCommand cmd = new SqlCommand(query, con.con);
            con.bukaKoneksi();
            object result = cmd.ExecuteScalar();
            con.tutupKoneksi();

            string empNumericPart = kode.Substring(1);
            int lastSequence = 0;

            if (result != null)
            {
                string lastTransactionId = result.ToString();
                if (lastTransactionId.Length >= 5)
                {
                    string seqPart = lastTransactionId.Substring(lastTransactionId.Length - 5);
                    int.TryParse(seqPart, out lastSequence);
                }
            }

            string transactionId = $"TR{empNumericPart}{(lastSequence + 1):D5}";
            return transactionId;
        }
    }
}
