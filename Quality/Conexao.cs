using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Quality
{
    public class Conexao
    {
        private int db;

        public int Db { get; set; }

        public SqlConnection c = new SqlConnection();

        public int Conectar()
        {
            try
            {

                if (Db == 0)
                {
                    c.ConnectionString = @"Server=HENRIQUE-PC;Database=DB_QUALITY;UID=sa;PWD=itpadm";
                    c.Open();
                    return 0;
                }
                else
                {
                    c.ConnectionString = @"Server=HENRIQUE-PC;Database=DB_QUALITY_teste;UID=sa;PWD=itpadm";
                    c.Open();
                    return 1;
                }
                
            }
            catch
            {
                return 2;
            }
            
        }

        public void Desconectar()
        {
            if (c.State == ConnectionState.Open)
            {
                c.Close();
                c.Dispose();
            }
        }

    }
}
