namespace Flow.Launcher.Plugin.AwsToolkit
{
    /// <summary>
    /// A data class for information about an AWS Console service
    /// </summary>
    public class ConsoleService
    {
        /// <summary>
        /// The name of the service (lowercase)
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// A short description of the service
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The AWS Console URL for the service
        /// </summary>
        public string Url { get; set; }
    }
}
