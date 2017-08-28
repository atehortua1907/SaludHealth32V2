using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludHealth32.Common.BE;
using System.Data.SqlClient;
using System.Data;

namespace SaludHealth32.BackEnd.DAC
{
    public class PacientesDAC
    {
        static PacienteList currentList;

        static PacientesDAC()
        {
            currentList = new PacienteList();
            PacienteBE p = new PacienteBE();
        }

        public static PacienteList Validacion(Guid? id)
        {
            PacienteList listaFiltrada = new PacienteList();
            try
            {
                using (SqlConnection cnn = new SqlConnection(CommonConstants.CnnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.Epiron.Paciente_s", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PacienteBE itemPersona = new PacienteBE();
                                itemPersona.Numref = int.Parse(reader["id"].ToString());

                                if (reader["IdPaciente"] != DBNull.Value)
                                    itemPersona.Numref = Convert.ToInt32(reader["IdPaciente"]);
                                    listaFiltrada.Add(itemPersona);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }
            return listaFiltrada;
        }

        public static void CrearPaciente(PacienteBE pacienteBE)
        {
            
            try
            {
                using (SqlConnection cnn = new SqlConnection(CommonConstants.CnnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.Epiron.Paciente_i", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", pacienteBE.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", pacienteBE.Apellidos);
                        cmd.Parameters.AddWithValue("@TipoDocumento", pacienteBE.Documento);
                        cmd.Parameters.AddWithValue("@NroDocumento", pacienteBE.NumDocumento);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", pacienteBE.FechaIngreso);
                        //cmd.Parameters.AddWithValue("@Nombre", pacienteBE.EstadoCivil);
                        cmd.Parameters.AddWithValue("@Sexo", pacienteBE.Sexo); 

                        cmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@ID",
                            SqlDbType = SqlDbType.UniqueIdentifier,
                            Direction = ParameterDirection.Output
                        });

                        var i = cmd.ExecuteNonQuery();

                        //Leemos los params de salida (Output)
                        pacienteBE.Numref = int.Parse(cmd.Parameters["@ID"].SqlValue.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

        }
        //Faltante
        public static void EliminarPaciente(PacienteBE pacienteBE)
        { 
            
        }

        public static PacienteBE ObtenerPacienteId(Guid id) 
        {
            PacienteBE itemPaciente = null;
            try
            {
                using (SqlConnection cnn = new SqlConnection(CommonConstants.CnnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.Epiron.Paciente_g", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                itemPaciente = new PacienteBE();
                                itemPaciente.Numref = int.Parse(reader["IdPaciente"].ToString());
                                itemPaciente.Apellidos = Convert.ToString(reader["Apellido"]);
                                itemPaciente.Nombre = Convert.ToString(reader["Nombre"]);
                                if (reader["IdPaciente"] != DBNull.Value)
                                    itemPaciente.Numref = Convert.ToInt32(reader["IdPaciente"]);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

             return itemPaciente;
        }

        public static void ActualizarPaciente(PacienteBE pacienteBE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(CommonConstants.CnnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo..Epiron.Paciente_u", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@IdPaciente", pacienteBE.Numref);
                        cmd.Parameters.AddWithValue("@Apellido", pacienteBE.Apellidos);
                        cmd.Parameters.AddWithValue("@Nombre", pacienteBE.Nombre);
                        var i = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }
        }

        public static PacienteList BuscarPacientes(string nombre, string apellido, Guid? id)
        {
            PacienteList listaFiltrada = new PacienteList();
            try
            {
                using (SqlConnection cnn = new SqlConnection(CommonConstants.CnnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.Epiron.Paciente_s", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Apellido", apellido);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PacienteBE itemPersona = new PacienteBE();
                                itemPersona.Numref = int.Parse(reader["Id"].ToString());
                                itemPersona.Apellidos = Convert.ToString(reader["Apellido"]);
                                itemPersona.Nombre = Convert.ToString(reader["Nombre"]);
                                listaFiltrada.Add(itemPersona);
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

            return listaFiltrada;
        }
    }
}
