using Q101.ConsoleNetCoreTetris.Application.Configurations.Abstract;
using Q101.ConsoleNetCoreTetris.Application.Configurations.Concrete.Sections;

namespace Q101.ConsoleNetCoreTetris.Application.Configurations.Concrete
{
    /// <inheritdoc />
    public class ApplicationConfig : IApplicationConfig
    {
        /// <inheritdoc />
        public FieldSettings FieldSettings { get; private set; }
    }
}
