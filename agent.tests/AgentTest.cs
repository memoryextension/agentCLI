namespace AgentCLI;

  public class AgentTest
  {
      [Fact]
      public void AgentVersionTest()
      {
        Assert.Equal("1.1",Agent.CLIVersion());
        Assert.NotEqual("not a version",Agent.CLIVersion());

      }
  }

