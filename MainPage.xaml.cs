// ========================================================
// Disciplina: CBTPRDM - Programação de Dispositivos Móveis
// Trabalho Prático 01
// Dupla: Laryssa Barbosa e Isabela Salgueiro
// ========================================================
namespace TP01_WEB;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Validação de login
    private async void OnOkClicked(object sender, EventArgs e)
    {
        string id = txtId.Text?.Trim();
        string pass = txtPass.Text;

        if (id == "admin" && pass == "senha@dmin")
        {
            await DisplayAlert("Sucesso", "Logou com sucesso", "OK");
        }
        else
        {
            await DisplayAlert("Erro", "Login não autorizado", "OK");
        }
    }

    // Limpar campos e repor foco no ID
    private void OnLimparClicked(object sender, EventArgs e)
    {
        txtId.Text = string.Empty;
        txtPass.Text = string.Empty;
        txtId.Focus();
    }

    // Exibir créditos
    private async void OnCreditosClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Créditos", "Autores do APP:\n- Laryssa Barbosa\n- Isabela Salgueiro", "OK");
    }
}
