using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;

namespace Loja.Class
{
    internal class Marcas
    {
        private int id;
        private string marca;

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }

        public static string salvar(Marcas m)
        {
            try
            {
                string sql = m.Id == 0 ?
                    "INSERT INTO marcas VALUES (null, @marca)" :
                    "UPDATE marcas SET marca = @marca WHERE id = @id";

                MySqlConnection conn = Conexao.obterConexao();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@marca", m.marca);
                cmd.Parameters.AddWithValue("@id", m.Id);
                cmd.ExecuteNonQuery();
                return "salvo com sucesso";
            }
            catch (Exception e)
            {
                return "erro: " + e.Message;
            }
        }

        public static string listar()
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM marcas";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();
            string lista = "Lista de marcas \n";
            if (res.HasRows)
            {
                while (res.Read())
                {
                    lista += "ID: " + res["id"].ToString();
                    lista += " - Marca: " + res["marca"].ToString();
                    lista += "\n";
                }
            }
            return lista;
        }

        public static MySqlDataReader carregar()
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM marcas";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();

            return res;
        }

        public static Boolean pesquisar(Marcas m)
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM marcas WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", m.Id);
            MySqlDataReader res = cmd.ExecuteReader();
            Boolean verificar = false;
            if (res.HasRows)
            {
                if (res.Read())
                {
                    m.Id = Int32.Parse(res["id"].ToString());
                    m.Marca = res["marca"].ToString();
                    verificar = true;
                }
            }
            return verificar;
        }

        public string excluir(string id)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "DELETE FROM marcas WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                return "excluído";
            }
            catch (Exception e)
            {
                return "erro: " + e.Message;
            }
        }

        public static string editar(Marcas m)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "UPDATE marcas SET marca = @marca WHERE id = @id";
                //string sql = "UPDATE categoria SET nome = @nome, email = @email WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", m.Id);
                cmd.Parameters.AddWithValue("@marca", m.Marca);
                //cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.ExecuteNonQuery();
                return "editado com sucesso";
            }
            catch (Exception e)
            {
                return "erro: " + e.Message;
            }
        }
    }
}
