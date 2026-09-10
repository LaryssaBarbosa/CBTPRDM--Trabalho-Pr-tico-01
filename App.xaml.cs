// ========================================================
// Disciplina: CBTPRDM - Programação de Dispositivos Móveis
// Trabalho Prático 01
// Dupla: Laryssa Barbossa e Isabela Salgueiro
// ========================================================
namespace TP01_WEB;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void OnResume()
    {
        base.OnResume();
    }

    protected override void OnSleep()
    {
        base.OnSleep();
    }
}