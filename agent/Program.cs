using System;
using CommandLine;

namespace AgentCLI
{
    public class Agent
    {
        public class Options
        {
            [Option('v', "version", Required = false, HelpText = "Returns Version of the program.")]
            public bool Version { get; set; }
        }
        
        public static string CLIVersion()
        {
          return "1.1";
        }

        static void Main(string[] args)
        {
          var parser = new Parser(with=> {with.AutoVersion = false;with.HelpWriter = Console.Out;}); 
          parser.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                     
                      Console.WriteLine("Agent");
                      
                      if(o.Version) 
                      {
                        
                        Console.WriteLine("CLI: version "+CLIVersion());
                        var jsonVersion = JSONServerUtils.getVersion();
                        Console.WriteLine("JSONAPI: version "+jsonVersion.Version+"-"+jsonVersion.Subversion+" ("+jsonVersion.Codename+")");
                        
                      }
                    });
        }
    }
}