// ========================================================
// Disciplina: CBTPRDM - Programação de Dispositivos Móveis
// Trabalho Prático 01
// Dupla: Laryssa Barbosa e Isabela Salgueiro
// ========================================================

namespace TP01_WEB;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}
