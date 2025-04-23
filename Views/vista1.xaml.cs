namespace mchicaizaS3.Views;

public partial class vista1 : ContentPage
{
	public vista1()
	{
		InitializeComponent();
	}

    string usuariof = "";
    string contrasenaf = "";
    public vista1(string usuario, string contrasena)
    {
        InitializeComponent();
        this.usuariof = usuario;
        this.contrasenaf = contrasena;
    }

    private void btniniciar_Clicked(object sender, EventArgs e)
    {
        if (txtusuario.Text == usuariof && txtcontrasena.Text == contrasenaf)
        {
            Navigation.PushAsync(new Views.vista2(usuariof));
        }
        else
        {
            DisplayAlert("Alerta", "USUARIO INCORRECTO", "OK");
        }
    }

    private void btnregistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vista3());
    }
}