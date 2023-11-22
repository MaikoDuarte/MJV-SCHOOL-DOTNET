// using Microsoft.Data.SqlClient;
// using mjv_aula_11.Models;
//
// namespace mjv_aula_11.Dal;
//
// public class SqlDAL
// {
//     public SqlDAL()
//     {
//         
//     }
//
//     public void TesteConectar()
//     {
//        
//         
//         string strConnection = "Server=localhost;Database=mjv;Uid=sa;Pwd=sa";
//         SqlConnection conn = new SqlConnection(strConnection);
//         conn.Open();
//         Console.WriteLine("Abrir a conexao");
//         
//
//         SqlCommand sqlCommand = new SqlCommand();
//         sqlCommand.CommandText = "select * from Aulas.Alunos";
//         sqlCommand.CommandType = System.Data.CommandType.Text;
//         sqlCommand.Connection = conn;
//
//         SqlDataReader reader = sqlCommand.ExecuteReader();
//         
//         while (reader.Read())
//         {
//             Aluno = new Alunos();
//             if (!reader.IsDBNull(1))
//                 Aluno.Nome = reader.GetString(1);
//             Console.Write(reader.GetString(1));
//             Console.Write(" " + reader.GetString(2));
//             
//             // Console.WriteLine(reader["nome"]);
//             // Console.WriteLine(reader["sobrenome"]);
//             Console.WriteLine("");
//             
//         }
//         
//         conn.Close();
//
//     }
// }