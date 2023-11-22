using MySql.Data.MySqlClient;

namespace mjv_aula_11.Dal;

public class MySqlDAL

{
    public MySqlDAL()
    {
        
        
    }

    public void TesteConectar()
    {
        string strConnection = "Server=localhost;Database=mjv;Uid=root;Pwd=root";
        MySqlConnection conn = new MySqlConnection();
        conn.Open();
        Console.WriteLine("Abrir a conexao");
        
        conn.Close();
    }

}