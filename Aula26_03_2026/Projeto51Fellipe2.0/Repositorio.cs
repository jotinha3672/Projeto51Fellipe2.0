using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;


namespace Projeto51Fellipe2._0
{
    class Repositorio
    {
        public DataTable BuscarPorIngredientes(List<string> ingredientes, int? categoriaId)
        {
            var conn = Db.Conecta();
            conn.Open();

            DataTable dt = new DataTable();

            // 🔹 CASO NÃO TENHA INGREDIENTES
            if (ingredientes.Count == 0)
            {
                string query = @"
                SELECT r.id_receita, r.Nome_Receita, r.Descricao, 
                       r.Tempo_Preparo, r.Foto, c.tipo
                FROM receita r
                INNER JOIN categoria c ON r.Tipo = c.id_categoria
                WHERE (@categoriaId IS NULL OR r.Tipo = @categoriaId)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@categoriaId", (object)categoriaId ?? DBNull.Value);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }

            // 🔥 FILTRO DE INGREDIENTES (modo inteligente = precisa ter TODOS)
            string filtro = string.Join(" OR ", ingredientes.Select((i, index) =>
                $"i.nome_ingrediente LIKE @ing{index}"));

            string query2 = $@"
            SELECT r.id_receita, r.Nome_Receita, r.Descricao, 
                   r.Tempo_Preparo, r.Foto, c.tipo
            FROM receita r
            INNER JOIN categoria c ON r.Tipo = c.id_categoria
            INNER JOIN receitaIgr ri ON r.id_receita = ri.id_receita
            INNER JOIN ingrediente i ON ri.id_ingrediente = i.id_ingrediente
            WHERE ({filtro})
            AND (@categoriaId IS NULL OR r.Tipo = @categoriaId)
            AND (@tempoMin IS NULL OR r.Tempo_Preparo >= @tempoMin)
            AND (@tempoMax IS NULL OR r.Tempo_Preparo <= @tempoMax)
            GROUP BY r.id_receita
            HAVING COUNT(DISTINCT i.id_ingrediente) >= @total";

            MySqlCommand cmd2 = new MySqlCommand(query2, conn);

            for (int i = 0; i < ingredientes.Count; i++)
            {
                cmd2.Parameters.AddWithValue($"@ing{i}", "%" + ingredientes[i] + "%");
            }

            cmd2.Parameters.AddWithValue("@categoriaId", (object)categoriaId ?? DBNull.Value);
            cmd2.Parameters.AddWithValue("@total", ingredientes.Count);

            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt);

            return dt;
        }

        //public DataTable BuscarAvancado(List<string> ingredientes, int? categoriaId, List<int> restricoes, int? tempoMin, int? tempoMax)
        //{
        //    using (var conn = Db.Conecta())
        //    {
        //        conn.Open();

        //        DataTable dt = new DataTable();

        //        //Filtro de ingredientes
        //        string filtroIngredientes = ingredientes.Count > 0
        //            ? string.Join(" OR ", ingredientes.Select((i, index) => $"i.nome_ingrediente LIKE @ing{index}"))
        //            : "1=1";

        //        //QUERY BASE
        //        string query = $@"
        //            SELECT r.id_receita, r.Nome_Receita, r.Descricao, 
        //                   r.Tempo_Preparo, r.Foto, c.tipo
        //            FROM receita r
        //            INNER JOIN categoria c ON r.Tipo = c.id_categoria
        //            LEFT JOIN receitaIgr ri ON r.id_receita = ri.id_receita
        //            LEFT JOIN ingrediente i ON ri.id_ingrediente = i.id_ingrediente
        //            WHERE 1=1
        //            AND (@categoriaId IS NULL OR r.Tipo = @categoriaId)
        //            AND (@tempoMin IS NULL OR r.Tempo_Preparo >= @tempoMin)
        //            AND (@tempoMax IS NULL OR r.Tempo_Preparo <= @tempoMax)
        //            AND ({filtroIngredientes})
        //            ";

        //        //FILTRO DE RESTRIÇÕES (CORRETO)
        //        if (restricoes != null && restricoes.Count > 0)
        //        {
        //            for (int i = 0; i < restricoes.Count; i++)
        //            {
        //                query += $@"
        //                AND NOT EXISTS (
        //                    SELECT 1 
        //                    FROM receitaRestricao rr
        //                    WHERE rr.id_receita = r.id_receita
        //                    AND rr.id_restricao = @res{i}
        //                )";
        //            }
        //        }

        //        //FINALIZAÇÃO (GROUP BY para evitar duplicidade)
        //        query += @"
        //        GROUP BY r.id_receita, r.Nome_Receita, r.Descricao, 
        //         r.Tempo_Preparo, r.Foto, c.tipo";

        //        //  COMANDO
        //        MySqlCommand cmd = new MySqlCommand(query, conn);

        //        //  Parâmetros ingredientes
        //        for (int i = 0; i < ingredientes.Count; i++)
        //        {
        //            cmd.Parameters.AddWithValue($"@ing{i}", "%" + ingredientes[i] + "%");
        //        }

        //        //Categoria
        //        cmd.Parameters.AddWithValue("@categoriaId", (object)categoriaId ?? DBNull.Value);

        //        //Tempo max e min
        //        cmd.Parameters.AddWithValue("@tempoMin", (object)tempoMin ?? DBNull.Value);
        //        cmd.Parameters.AddWithValue("@tempoMax", (object)tempoMax ?? DBNull.Value);
        //        //Parâmetros restrições
        //        if (restricoes != null)
        //        {
        //            for (int i = 0; i < restricoes.Count; i++)
        //            {
        //                cmd.Parameters.AddWithValue($"@res{i}", restricoes[i]);
        //            }
        //        }

        //        //EXECUÇÃO
        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //        da.Fill(dt);

        //        return dt;
        //    }
        //}

        public DataTable BuscarAvancado(List<string> ingredientes, int? categoriaId, List<int> restricoes, int? tempoMin, int? tempoMax)
        {
            using (var conn = Db.Conecta())
            {
                conn.Open();

                DataTable dt = new DataTable();

                // BASE DA QUERY
                string query = @"
                    SELECT r.id_receita, r.Nome_Receita, r.Descricao, 
                       r.Tempo_Preparo, r.Foto, r.calorias, c.tipo
                    FROM receita r
                    INNER JOIN categoria c ON r.Tipo = c.id_categoria
                    LEFT JOIN receitaIgr ri ON r.id_receita = ri.id_receita
                    LEFT JOIN ingrediente i ON ri.id_ingrediente = i.id_ingrediente
                    WHERE 1=1
                    AND (@categoriaId IS NULL OR r.Tipo = @categoriaId)
                    AND (@tempoMin IS NULL OR r.Tempo_Preparo >= @tempoMin)
                    AND (@tempoMax IS NULL OR r.Tempo_Preparo <= @tempoMax)
                    ";

                // 🔥 INGREDIENTES (SÓ SE TIVER)
                if (ingredientes.Count > 0)
                {
                    string filtroIngredientes = string.Join(" OR ", ingredientes.Select((i, index) =>
                        $"i.nome_ingrediente LIKE @ing{index}"));

                    query += $" AND ({filtroIngredientes})";
                }

                // 🔥 RESTRIÇÕES (NOT EXISTS)
                if (restricoes != null && restricoes.Count > 0)
                {
                    for (int i = 0; i < restricoes.Count; i++)
                    {
                        query += $@"
                AND NOT EXISTS (
                    SELECT 1 
                    FROM receitaRestricao rr
                    WHERE rr.id_receita = r.id_receita
                    AND rr.id_restricao = @res{i}
                )";
                    }
                }

                // 🔥 GROUP BY (necessário por causa dos JOINs)
                query += @"
        GROUP BY r.id_receita, r.Nome_Receita, r.Descricao, 
                 r.Tempo_Preparo, r.Foto, c.tipo
        ";

                // 🔥 HAVING (AND lógico dos ingredientes)
                if (ingredientes.Count > 0)
                {
                    query += " HAVING COUNT(DISTINCT i.id_ingrediente) >= @total";
                }

                // COMANDO
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // 🔹 INGREDIENTES
                for (int i = 0; i < ingredientes.Count; i++)
                {
                    cmd.Parameters.AddWithValue($"@ing{i}", "%" + ingredientes[i] + "%");
                }

                if (ingredientes.Count > 0)
                {
                    cmd.Parameters.AddWithValue("@total", ingredientes.Count);
                }

                // 🔹 CATEGORIA
                cmd.Parameters.AddWithValue("@categoriaId", (object)categoriaId ?? DBNull.Value);

                // 🔹 TEMPO
                cmd.Parameters.AddWithValue("@tempoMin", (object)tempoMin ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@tempoMax", (object)tempoMax ?? DBNull.Value);

                // 🔹 RESTRIÇÕES
                if (restricoes != null)
                {
                    for (int i = 0; i < restricoes.Count; i++)
                    {
                        cmd.Parameters.AddWithValue($"@res{i}", restricoes[i]);
                    }
                }

                // EXECUTA
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
        }
        public List<IngredienteReceita> BuscarIngredientes(int idReceita)
        {
            List<IngredienteReceita> lista = new List<IngredienteReceita>();

            using (var conn = Db.Conecta())
            {
                conn.Open();

                string query = @"
                SELECT i.nome_ingrediente, ri.quantidade, ri.unidade
                FROM receitaIgr ri
                JOIN ingrediente i ON ri.id_ingrediente = i.id_ingrediente
                WHERE ri.id_receita = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idReceita);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new IngredienteReceita
                        {
                            Nome = reader["nome_ingrediente"].ToString(),
                            Quantidade = reader["quantidade"].ToString(),
                            Unidade = reader["unidade"].ToString()
                        });
                    }
                }
            }

            return lista;
        }
        //Query do Botão ver mais que exibe a receita
        public Receita BuscarReceitaPorId(int id)
        {
            Receita r = new Receita();

            using (var conn = Db.Conecta())
            {
                conn.Open();

                string sql = @"SELECT r.nome_receita, r.descricao, r.tempo_preparo, 
                              r.modo_preparo, r.foto, r.calorias, c.tipo AS categoria
                       FROM receita r
                       INNER JOIN categoria c ON r.Tipo = c.id_categoria
                       WHERE r.id_receita = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    r.Nome = reader["nome_receita"].ToString();
                    r.Descricao = reader["descricao"].ToString();
                    r.Tempo = reader["tempo_preparo"].ToString();
                    r.ModoPreparo = reader["modo_preparo"].ToString();
                    r.Imagem = reader["foto"] as byte[];
                    r.Categoria = reader["categoria"].ToString();
                    r.Calorias = reader["calorias"] != DBNull.Value
                    ? Convert.ToInt32(reader["calorias"])
                    : 0;
                }
            }

            return r;
        }
        public List<Receita> BuscarPorCategoriaSimples(int categoriaId)
        {
            var lista = new List<Receita>();

            using (var conn = Db.Conecta())
            {
                conn.Open();

                string sql = @"SELECT id_receita, nome_receita, calorias 
                       FROM receita
                       WHERE tipo = @cat";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@cat", categoriaId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Receita
                            {
                                Id = reader.GetInt32("id_receita"),
                                Nome = reader.GetString("nome_receita"),
                                Calorias = reader["calorias"] != DBNull.Value
                                ? Convert.ToInt32(reader["calorias"])
                                : 0
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}
