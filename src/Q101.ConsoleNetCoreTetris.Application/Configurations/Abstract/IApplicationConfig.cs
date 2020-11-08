using Q101.ConsoleNetCoreTetris.Application.Configurations.Concrete.Sections;

namespace Q101.ConsoleNetCoreTetris.Application.Configurations.Abstract
{
    /// <summary>
    /// Application configuration
    /// </summary>
    public interface IApplicationConfig
    { 
        /// <summary>
        /// Game field settings
        /// </summary>
        FieldSettings FieldSettings { get; }
    }
}
