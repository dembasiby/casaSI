namespace CasaEcologie.WinForms.Formulaires;

public partial class FrmConnexion : Form
{
    private readonly ServiceContainer _services;

    public FrmConnexion(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void BtnConnexion_Click(object sender, EventArgs e)
    {
        var result = _services.Auth.Authentifier(txtNomUtilisateur.Text, txtMotDePasse.Text);

        if (result.Success)
        {
            using var accueil = new FrmAccueil(_services, result.Role);
            Hide();
            accueil.ShowDialog();
            Close();
        }
        else
        {
            MessageBox.Show(result.ErrorMessage, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnQuitter_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
