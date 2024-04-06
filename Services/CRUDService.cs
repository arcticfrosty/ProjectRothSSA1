using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectRothSSA1.Models.Data;
using System.Data;

namespace ProjectRothSSA1.Services {
    public class CRUDService {
        public static DataTable? execCRUD(Ssa1bikeStoreContext _context , string cmdTxt , string[,] sp_par) {
            var dt = new DataTable();
            try {
                using (var cmd = _context.Database.GetDbConnection().CreateCommand()) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = cmdTxt;

                    int arrIndex = sp_par.GetLength(0);
                    for (int i = 0; i < arrIndex; i++) {
                        cmd.Parameters.Add(new SqlParameter("@" + sp_par[i , 0] , sp_par[i , 1]));
                    }

                    _context.Database.OpenConnection();
                    using (var result = cmd.ExecuteReader()) {
                        dt.Load(result);
                    };
                };
                return dt;
            } catch (Exception ex) {
                MessageBox.Show("Something Went Wrong!\n" + ex);
                return null;
            }
        }
    }
}
