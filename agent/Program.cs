using System;
namespace AgentCLI
{
    class Program
    {

        static async Task Main(string[] args)
        {
          
          var dbUtils=new DBUtils();
          var clients = await dbUtils. getClients();
          foreach(var c in clients)
          {
            Console.WriteLine(c.id+": "+c.name+" (created on "+c.created_at.ToString()+")");
          }
        }
    }
}