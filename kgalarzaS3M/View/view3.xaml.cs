namespace kgalarzaS3M.View;

public partial class view3 : ContentPage
{
    public view3()
    {
        InitializeComponent();
    }

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasenia = txtContrasenia.Text;

        DisplayAlert("Alerta", "usuarioGuardado", "ok");
        Navigation.PushAsync(new View.view1(usuario, contrasenia));



    }
}