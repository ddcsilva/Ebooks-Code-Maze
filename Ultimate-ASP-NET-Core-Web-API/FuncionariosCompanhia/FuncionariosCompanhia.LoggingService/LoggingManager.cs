using FuncionariosCompanhia.Contracts;
using NLog;

namespace FuncionariosCompanhia.LoggingService;

public class LoggingManager : ILoggerManager
{
    private static ILogger logger = LogManager.GetCurrentClassLogger();

    public LoggingManager() {}

    public void LogAdvertencia(string messagem) => logger.Warn(messagem);

    public void LogDepuracao(string messagem) => logger.Debug(messagem);

    public void LogErro(string messagem) => logger.Error(messagem);

    public void LogInformativo(string messagem) => logger.Info(messagem);
}
