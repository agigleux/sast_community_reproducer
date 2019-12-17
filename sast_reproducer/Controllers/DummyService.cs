using System.Data.SqlClient;

namespace sast_reproducer.Controllers
{
    internal class DummyService
    {
        public DummyService()
        {
        }
        internal void execute(string unsafeSql)
        {
            using (var conn = new SqlConnection("Server=.;Integrated Security=true"))
            {
                SqlCommand command = new SqlCommand(unsafeSql, conn);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }

        }
    }
}