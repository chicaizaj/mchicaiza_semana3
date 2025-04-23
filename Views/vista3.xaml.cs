namespace mchicaizaS3.Views;

public partial class vista3 : ContentPage
{
	public vista3()
	{
		InitializeComponent();
	}

    private void btnguardar_Clicked(object sender, EventArgs e)
    {
		string usuarioc = txtusuario.Text;
		string contrasenac = txtcontraseña.Text;
		DisplayAlert("Alerta", "Usuario Almacenado", "ok");
		Navigation.PushAsync(new Views.vista1(usuarioc, contrasenac));
    }
}