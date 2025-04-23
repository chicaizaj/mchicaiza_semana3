namespace mchicaizaS3.Views;

public partial class vista2 : ContentPage
{
	public vista2(String usuario)
	{
		InitializeComponent();
		lblUsuario.Text = "USUARIO CONECTADO " + usuario;
	}
}