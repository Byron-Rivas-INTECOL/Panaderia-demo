using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InterfazImpresora.Datos
{
    public class ObtenerDb
    {
        public static int id_tipo_producto;
        public static String ObtenerParametro(string parametroint)
        {
            //string parametro = "";
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConexionBd.builder.ConnectionString))
                    {
                        Console.WriteLine("Conexion a base de datos");
                        Console.WriteLine("==============");
                        string query = "select Valor from [DbMult].[dbo].[Parametros] where [Parametro]='" + parametroint + "'";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                reader.Read();
                                string lectura = reader.GetString(0);
                                return lectura;

                            }
                        }



                    }
                }
                catch (Exception)
                {


                }
                return "";
            }
        }

        public static List<Int64> ImportarCodigos(Int64 lote)
        {
            List<Int64> codigos = new List<Int64>();
            {
                try
                {
                    Form1.i_list = 0;
                    using (SqlConnection connection = new SqlConnection(ConexionBd.builder.ConnectionString))
                    {
                        Console.WriteLine("Conexion a base de datos");
                        Console.WriteLine("==============");


                        string query = "SELECT id_producto FROM [INDUMIL].[dbo].[Hist_Mult] WHERE orden_produccion =" + lote + "AND id_estado =0";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    codigos.Add(Convert.ToInt64(reader.GetValue(0)));
                                }
                                //reader.Read();
                                //var lectura = (reader.GetString(0));
                                //id_tipo_producto=1;
                            }
                        }


                        query = "SELECT TOP 1 id_tipo_producto FROM [INDUMIL].[dbo].[Hist_Mult] WHERE orden_produccion =" + Convert.ToString(lote);
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                //while (reader.Read())
                                //{
                                id_tipo_producto = 0;
                                id_tipo_producto = Convert.ToInt32(reader.GetValue(0));
                                //}
                            }
                        }
                        Form1.SetImpresora(id_tipo_producto);

                    }
                    return codigos;
                }
                catch (Exception)
                {

                    return codigos;

                }
            }

        }

        public static List<Int64> ImportarOP()
        {
            List<Int64> codigos = new List<Int64>();




            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConexionBd.builder.ConnectionString))
                    {
                        Console.WriteLine("Conexion a base de datos");
                        Console.WriteLine("==============");


                        string query = "SELECT lote FROM [INDUMIL].[produccion].[ordenes_trabajo] WHERE id_ultimo_estado < 3 AND 1=1 order by id_ultimo_estado asc";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    codigos.Add(Convert.ToInt64(reader.GetValue(0)));
                                }
                                return codigos;
                            }
                        }



                    }
                }
                catch (Exception)
                {

                    return codigos;

                }
            }

        }

        public static void ActualizarEstado(string id_producto)//Byron
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConexionBd.builder.ConnectionString))
                    {
                        Console.WriteLine("Conexion a base de datos");
                        Console.WriteLine("==============");
                        string query = "UPDATE[INDUMIL].[dbo].[Hist_Mult] SET id_estado = 1 WHERE id_producto = " + id_producto + " select * from [INDUMIL].[dbo].[Hist_Mult] where id_producto<0";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                reader.Read();
                                string lectura = reader.GetString(0);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        public static List<string> LeerCajas()
        {
            {
                string result;
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(ConexionBd.builder.ConnectionString))
                        {
                            Console.WriteLine("Conexion a base de datos");
                            Console.WriteLine("==============");
                            string query = "SELECT TOP (1) *  FROM [INDUMIL].[dbo].[Hist_Cajas]";
                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                connection.Open();
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    List<string> lista = new List<string>();
                                    int i = 0;
                                    reader.Read();
                                    while (i<=11)
                                    {
                                        lista.Add(Convert.ToString(reader.GetValue(i)));
                                        i++;
                                    }
                                    return lista;

                                }
                            }



                        }
                    }
                        catch (Exception ex)
                    {
                        List<String> vacia = new List<String>();
                        return vacia;

                    }
                }



            }


        }
        public static List<string> LeerCajasV2()
        {
            {
                string result;
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(ConexionBd.builder.ConnectionString))
                        {
                            Console.WriteLine("Conexion a base de datos");
                            Console.WriteLine("==============");
                            string query = "EXEC[INDUMIL].[DBO].[usp_Obtener_Diccionario] 'Hist_Cajas'; ";
                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                connection.Open();
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    List<string> lista = new List<string>();
                                    int i = 0;
                                    reader.Read();
                                    while (i<=10)
                                    {
                                        lista.Add(Convert.ToString(reader.GetValue(i)));
                                        i++;
                                    }
                                    return lista;

                                }
                            }



                        }
                    }
                        catch (Exception ex)
                    {

                        return null;

                    }
                }



            }


        }
    }
}
    
