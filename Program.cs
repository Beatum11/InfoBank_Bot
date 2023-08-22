using InfoBank_Bot;
using Microsoft.Extensions.Configuration;


var configurationBuilder = new ConfigurationBuilder()
      .AddUserSecrets<ProgramStarter>();

var configuration = configurationBuilder.Build();

ProgramStarter programStarter = new ProgramStarter(configuration);
await programStarter.StartProgram();
