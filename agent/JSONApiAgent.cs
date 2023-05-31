using System;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace AgentCLI
{
  
  public class JSONServerVersion
  {
    	public int Version  {get;set;}
      public string Subversion {get;set;}
      public string Codename {get;set;}
  }
  
  public class JSONServerUtils
  {
  
    public static JSONServerVersion getVersion(string url="http://localhost:8090/version/")
    {
      
      using (WebClient wc = new WebClient())
      {
        var jsonString = wc.DownloadString(url);
        JSONServerVersion version= JsonSerializer.Deserialize<JSONServerVersion>(jsonString);
        
          return version;
        
        /*
        return new JSONServerVersion(){
            Version   = 0,
            Subversion= "0",
            Codename  = "API not working"};
            */
      }
    }
  }
  
  
}