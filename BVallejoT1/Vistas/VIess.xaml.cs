namespace BVallejoT1.Vistas;

public partial class VIess : ContentPage
{
	public VIess()
	{
		InitializeComponent();
	}
    private void OnEjecutar(object sender, EventArgs e)
    {
        string nombre = $"{txtNombre.Text} {txtApellido.Text}";
        int edad = int.Parse(txtEdad.Text);
        decimal salario = Math.Round(decimal.Parse(txtSalario.Text), 2);
        this.alert(nombre, edad, salario);


    }
    public decimal CalculoAporte(decimal salario)
    {
        decimal aporte = Math.Round(salario * 0.0945m, 2);
        return aporte;
    }
    public void alert(string nombre, int edad, decimal salario)
    {
        string msg = $"Bienvenido: {nombre}\nTienes: {edad} años\nTu aporte " +
            $"mensual es: ${CalculoAporte(salario)}";
        DisplayAlert("Alert", msg, "OK");

    }
}