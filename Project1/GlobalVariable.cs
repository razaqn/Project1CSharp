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

        public static string memberid()
        {
            Koneksi con = new Koneksi();
            string query = "SELECT TOP 1 MemberID FROM items.member ORDER BY MemberID DESC";
            SqlCommand cmd = new SqlCommand(query, con.con);
            con.bukaKoneksi();
            object result = cmd.ExecuteScalar();
            con.tutupKoneksi();

            int lastSequence = 0;
            if (result != null)
            {
                string lastMemberId = result.ToString();
                if (lastMemberId.Length >= 3)
                {
                    string seqPart = lastMemberId.Substring(1);
                    int.TryParse(seqPart, out lastSequence);
                }
            }

            string memberId = $"M{(lastSequence + 1):D3}";
            return memberId;
        }

        public static string bookid()
        {
            Koneksi con = new Koneksi();
            string query = "SELECT TOP 1 BookID FROM items.book ORDER BY BookID DESC";
            SqlCommand cmd = new SqlCommand(query, con.con);
            con.bukaKoneksi();
            object result = cmd.ExecuteScalar();
            con.tutupKoneksi();

            int lastSequence = 0;
            if (result != null)
            {
                string lastBookId = result.ToString();
                if (lastBookId.Length >= 3)
                {
                    string seqPart = lastBookId.Substring(1);
                    int.TryParse(seqPart, out lastSequence);
                }
            }

            string bookId = $"B{(lastSequence + 1):D3}";
            return bookId;
        }

        public static string empid()
        {
            Koneksi con = new Koneksi();
            string query = "SELECT TOP 1 EmpID FROM users.employee ORDER BY EmpID DESC";
            SqlCommand cmd = new SqlCommand(query, con.con);
            con.bukaKoneksi();
            object result = cmd.ExecuteScalar();
            con.tutupKoneksi();

            int lastSequence = 0;
            if (result != null)
            {
                string lastEmpId = result.ToString();
                if (lastEmpId.Length >= 3)
                {
                    string seqPart = lastEmpId.Substring(1);
                    int.TryParse(seqPart, out lastSequence);
                }
            }

            string empId = $"E{(lastSequence + 1):D3}";
            return empId;
        }
    }
}
