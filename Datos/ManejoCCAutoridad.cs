﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class ManejoCCAutoridad
    {
        private string strconn = ConexionSql.sqlConn;

        public int AgregarRegistroCCAutoridad(ComunicacionesControladorAutoridad cca)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    string query = "Insert into ComunicacionesControladorAutoridad(ControladorID, AutoridadID, Mensaje, FechaHora)"
                        + " Values(@contolador, @autoridad, @mensaje, @fecha)";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@controlador", cca.ControladorID);
                        command.Parameters.AddWithValue("@autoridad", cca.AutoridadID);
                        command.Parameters.AddWithValue("@mensaje", cca.Mensaje);
                        command.Parameters.AddWithValue("@fecha", cca.FechaHora);

                        conn.Open();
                        int row = command.ExecuteNonQuery();
                        return row;
                    }
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
