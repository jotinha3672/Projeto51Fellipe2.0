using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using System.Data.SqlClient;

namespace Projeto51Fellipe2._0
{
    class Repositorio
    {
        public DataTable BuscarPorIngredientes(List<string> ingredientes)
        {
            var conn = Db.Conecta();
            conn.Open();

            DataTable dt = new DataTable();

            
            if (ingredientes.Count == 0)
            {
                string query = @"SELECT id_receita, Nome_Receita, Descricao, Tempo_Preparo, foto
                FROM receita";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);

                return dt;
            }

            // SE EXISTIREM INGREDIENTES
            string filtro = string.Join(" OR ", ingredientes.Select((i, index) =>
                $"i.nome_ingrediente LIKE @ing{index}"));

            string query2 = $@"
            SELECT DISTINCT r.id_receita, r.Nome_Receita, r.Descricao, r.Tempo_Preparo, r.foto
            FROM receita r
            INNER JOIN receitaIgr ri ON r.id_receita = ri.id_receita
            INNER JOIN ingrediente i ON ri.id_ingrediente = i.id_ingrediente
            WHERE {filtro}";

            MySqlCommand cmd = new MySqlCommand(query2, conn);

            for (int i = 0; i < ingredientes.Count; i++)
            {
                cmd.Parameters.AddWithValue($"@ing{i}", "%" + ingredientes[i] + "%");
            }

            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
            da2.Fill(dt);

            return dt;
        }


        //public DataTable buscarpornomes(string termo)

        //{
        //    var conn = Db.Conecta();
        //    conn.Open();

        //    string query = @"
        //    SELECT DISTINCT r.id_receita, r.Nome_Receita, r.Descricao, r.Tempo_Preparo
        //    FROM receita r
        //    INNER JOIN receitaIgr ri ON r.id_receita = ri.id_receita
        //    INNER JOIN ingrediente i ON ri.id_ingrediente = i.id_ingrediente
        //    WHERE i.nome_ingrediente LIKE @nomeIngrediente;";

        //    MySqlCommand cmd = new MySqlCommand(query, conn);
        //    cmd.Parameters.AddWithValue("@nomeIngrediente", "%" + termo + "%");

        //    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    return dt;
        //}

    }
}
