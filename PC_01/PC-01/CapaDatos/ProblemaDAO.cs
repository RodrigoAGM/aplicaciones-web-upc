using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class ProblemaDAO
    {
        Conexion ObjCn = new Conexion();
        SqlConnection Cn = new SqlConnection();

        public DataTable ListarProblemas()
        {
            Cn = ObjCn.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAPROBLEMA", Cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int NuevoProblema(Problema problema)
        {
            Cn = ObjCn.getConecta();
            Cn.Open();

            using (SqlTransaction tr = Cn.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_NUEVOPROBLEMA", Cn, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DES", SqlDbType.VarChar).Value = problema.Descripcion;
                cmd.Parameters.Add("@TIP", SqlDbType.VarChar).Value = problema.Tipo;

                try
                {
                    int n = cmd.ExecuteNonQuery();
                    tr.Commit();
                    return n;
                }
                catch (Exception e)
                {
                    tr.Rollback();
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}
