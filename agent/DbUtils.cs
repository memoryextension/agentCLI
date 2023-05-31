using Npgsql;
using Dapper;


namespace AgentCLI
{
  
  public class DBUtils
  {
    
    private NpgsqlConnection connection;
    public DBUtils()
    {
      connection = new NpgsqlConnection(connectionString: "Server=localhost;Port=5435;User Id=postgres;Password=pgpwd;Database=carthage;");
      connection.Open();
    }
    public async Task<IEnumerable<Client>>  getClients()
    {
      
      return await connection.QueryAsync<Client>($"SELECT * FROM {Client.TABLE_NAME}");
    }
  }
  
}