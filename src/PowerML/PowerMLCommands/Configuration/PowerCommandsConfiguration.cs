namespace PowerMLCommands.Configuration
{
    public class PowerCommandsConfiguration : CommandsConfiguration
    {
        //Here is the placeholder for your custom configuration, you need to add the change to the PowerCommandsConfiguration.yaml file as well
        public string DefaultGitRepositoryPath { get; set; } = string.Empty;
        public string PathToDockerDesktop { get; set; } = string.Empty;
        public string GoFireflyioAiacDockerImage { get; set; } = string.Empty;
    }
}