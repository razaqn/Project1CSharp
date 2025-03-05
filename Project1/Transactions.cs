using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project1
{
    internal class Transactions
    {
        private Koneksi koneksi;

        public Transactions()
        {
            koneksi = new Koneksi();
        }

        public DataSet SearchBooks(string searchTerm)
        {
            string query = "SELECT BookID, Title, Stock FROM items.book WHERE (BookID LIKE @search OR Title LIKE @search) AND Stock > 0";
            using (SqlCommand cmd = new SqlCommand(query, koneksi.con))
            {
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                DataSet dt = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt, "buku");
                return dt;
            }
        }

        public DataSet SearchMembers(string searchTerm)
        {
            string query = @"SELECT m.MemberID, m.MemberName 
                            FROM items.member m 
                            WHERE (m.MemberID LIKE @search OR m.MemberName LIKE @search)
                            AND NOT EXISTS (
                                SELECT 1 FROM transactions.header h
                                JOIN transactions.borrow b ON h.TransNumber = b.TransNumber
                                LEFT JOIN transactions.retur r ON b.TransNumber = r.TransNumber
                                WHERE h.MemberID = m.MemberID AND r.ReturnDate IS NULL
                            )";
            using (SqlCommand cmd = new SqlCommand(query, koneksi.con))
            {
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                DataSet dt = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt, "mmbr");
                return dt;
            }
        }

        public DataSet ReadBooks()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SELECT BookID, Title, Stock FROM items.book WHERE Stock > 0";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "buku");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet ReadMembers()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = @"SELECT m.MemberID, m.MemberName 
                            FROM items.member m 
                            WHERE NOT EXISTS (
                                SELECT 1 FROM transactions.header h
                                JOIN transactions.borrow b ON h.TransNumber = b.TransNumber
                                LEFT JOIN transactions.retur r ON b.TransNumber = r.TransNumber
                                WHERE h.MemberID = m.MemberID AND r.ReturnDate IS NULL
                            )";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "mmbr");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public bool SubmitBorrow(string bookId, string memberId, string empId, DateTime due, string trId)
        {
            try
            {
                DateTime borrowDate = DateTime.Now;
                koneksi.bukaKoneksi();
    
                string headerQuery = "INSERT INTO transactions.header VALUES (@transNumber, @empId, @memberId, @bookId)";
                string borrowQuery = "INSERT INTO transactions.borrow VALUES (@transNumber, @borrowDate, @dueDate)";
                string updateStockQuery = "UPDATE items.book SET Stock = Stock - 1 WHERE BookID = @bookId";
    
                using (SqlCommand headerCmd = new SqlCommand(headerQuery, koneksi.con))
                {
                    headerCmd.Parameters.AddWithValue("@transNumber", trId);
                    headerCmd.Parameters.AddWithValue("@empId", empId);
                    headerCmd.Parameters.AddWithValue("@memberId", memberId);
                    headerCmd.Parameters.AddWithValue("@bookId", bookId);
                    headerCmd.ExecuteNonQuery();
                }
    
                using (SqlCommand borrowCmd = new SqlCommand(borrowQuery, koneksi.con))
                {
                    borrowCmd.Parameters.AddWithValue("@transNumber", trId);
                    borrowCmd.Parameters.AddWithValue("@borrowDate", borrowDate);
                    borrowCmd.Parameters.AddWithValue("@dueDate", due);
                    borrowCmd.ExecuteNonQuery();
                }

                using (SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, koneksi.con))
                {
                    updateStockCmd.Parameters.AddWithValue("@bookId", bookId);
                    updateStockCmd.ExecuteNonQuery();
                }
    
                koneksi.tutupKoneksi();
                return true;
            }
            catch (Exception)
            {
                koneksi.tutupKoneksi();
                return false;
            }
        }

        public DataSet ReadReturn()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = @"SELECT h.TransNumber, b.BookID, b.Title, m.MemberID, m.MemberName,
                                br.BorrowDate, br.DueDate
                                FROM transactions.header h
                                JOIN items.book b ON h.BookID = b.BookID
                                JOIN items.member m ON h.MemberID = m.MemberID
                                JOIN transactions.borrow br ON h.TransNumber = br.TransNumber
                                LEFT JOIN transactions.retur rt ON h.TransNumber = rt.TransNumber
                                WHERE rt.ReturnDate IS NULL
                                ORDER BY h.TransNumber DESC";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "retur");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet ReadHistory()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = @"SELECT h.TransNumber, b.BookID, b.Title, m.MemberID, m.MemberName,
                                e.EmpName, br.BorrowDate, br.DueDate, rt.ReturnDate, rt.Fine
                                FROM transactions.header h
                                JOIN items.book b ON h.BookID = b.BookID
                                JOIN items.member m ON h.MemberID = m.MemberID
                                JOIN users.employee e ON h.EmpID = e.EmpID
                                JOIN transactions.borrow br ON h.TransNumber = br.TransNumber
                                LEFT JOIN transactions.retur rt ON h.TransNumber = rt.TransNumber
                                WHERE rt.ReturnDate IS NOT NULL
                                ORDER BY h.TransNumber DESC";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "hstr");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet SearchHistory(string searchTerm)
        {
            string query = @"SELECT h.TransNumber, b.BookID, b.Title, m.MemberID, m.MemberName,
                                e.EmpName, br.BorrowDate, br.DueDate, rt.ReturnDate, rt.Fine
                                FROM transactions.header h
                                JOIN items.book b ON h.BookID = b.BookID
                                JOIN items.member m ON h.MemberID = m.MemberID
                                JOIN users.employee e ON h.EmpID = e.EmpID
                                JOIN transactions.borrow br ON h.TransNumber = br.TransNumber
                                LEFT JOIN transactions.retur rt ON h.TransNumber = rt.TransNumber
                                WHERE rt.ReturnDate IS NOT NULL
                                AND (h.TransNumber LIKE @search 
                                OR b.Title LIKE @search 
                                OR m.MemberName LIKE @search
                                OR e.EmpName LIKE @search)
                                ORDER BY br.BorrowDate DESC";
            using (SqlCommand cmd = new SqlCommand(query, koneksi.con))
            {
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                DataSet dt = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt, "hstr");
                return dt;
            }
        }

        public DataSet SearchReturn(string searchTerm)
        {
            string query = @"SELECT h.TransNumber, b.BookID, b.Title, m.MemberID, m.MemberName,
                            br.BorrowDate, br.DueDate
                            FROM transactions.header h
                            JOIN items.book b ON h.BookID = b.BookID
                            JOIN items.member m ON h.MemberID = m.MemberID
                            JOIN transactions.borrow br ON h.TransNumber = br.TransNumber
                            LEFT JOIN transactions.retur rt ON h.TransNumber = rt.TransNumber
                            WHERE rt.ReturnDate IS NULL
                            AND (h.TransNumber LIKE @search 
                                OR b.Title LIKE @search 
                                OR m.MemberName LIKE @search)
                            ORDER BY br.DueDate DESC";
            using (SqlCommand cmd = new SqlCommand(query, koneksi.con))
            {
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                DataSet dt = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt, "retur");
                return dt;
            }
        }

        public bool ReturnBook(string transactionId, int fine)
        {
            try
            {
                koneksi.bukaKoneksi();
                string updateStockQuery = @"UPDATE items.book 
                                          SET Stock = Stock + 1 
                                          FROM items.book b
                                          JOIN transactions.header h ON b.BookID = h.BookID
                                          WHERE h.TransNumber = @transNumber";
                string returnQuery = "INSERT INTO transactions.retur VALUES (@transNumber, @returnDate, @fine)";

                using (SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, koneksi.con))
                {
                    updateStockCmd.Parameters.AddWithValue("@transNumber", transactionId);
                    updateStockCmd.ExecuteNonQuery();
                }

                using (SqlCommand returnCmd = new SqlCommand(returnQuery, koneksi.con))
                {
                    returnCmd.Parameters.AddWithValue("@transNumber", transactionId);
                    returnCmd.Parameters.AddWithValue("@returnDate", DateTime.Now);
                    returnCmd.Parameters.AddWithValue("@fine", fine);
                    returnCmd.ExecuteNonQuery();
                }

                koneksi.tutupKoneksi();
                return true;
            }
            catch (Exception)
            {
                koneksi.tutupKoneksi();
                return false;
            }
        }
    }
}
