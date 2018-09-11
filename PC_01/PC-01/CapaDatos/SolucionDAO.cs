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
    public class SolucionDAO
    {
        Conexion ObjCn = new Conexion();
        SqlConnection Cn = new SqlConnection();

        public DataTable ListarSolucion(int id)
        {
            Cn = ObjCn.getConecta();
            Cn.Open();
            using (SqlTransaction tr = Cn.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_LISTASOLUCION", Cn, tr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ProblemaId", SqlDbType.Int).Value = id;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public int NuevaSolucion(Solucion solucion)
        {

            Cn = ObjCn.getConecta();
            Cn.Open();

            using (SqlTransaction tr = Cn.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_NUEVASOLUCION", Cn, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@IPR", SqlDbType.Int).Value = solucion.ObjProblema.IdProblema;
                cmd.Parameters.Add("@DES", SqlDbType.VarChar).Value = solucion.Descripcion;

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
