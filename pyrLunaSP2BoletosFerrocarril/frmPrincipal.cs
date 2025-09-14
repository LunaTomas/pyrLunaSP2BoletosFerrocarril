namespace pyrLunaSP2BoletosFerrocarril
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Precio por kilómetro
            const decimal precioPorKm = 5m;
            const decimal descuento = 0.5m;

            // Variables
            decimal distancia;
            int dias;

            // Validar que la distancia sea numérica y mayor a 0
            if (!decimal.TryParse(txtDistancia.Text, out distancia) || distancia <= 0)
            {
                MessageBox.Show("Ingrese una distancia válida mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tomar la cantidad de días
            dias = (int)nudDias.Value;

            // Calcular el precio base ida y vuelta
            decimal distanciaTotal = distancia * 2;
            decimal precioBase = distanciaTotal * precioPorKm;

            // Aplicar descuento
            if (distancia >= 100 && dias >= 7)
            {
                precioBase *= descuento; // 50% de descuento
            }

            // Mostrar el resultado
            MessageBox.Show($"El precio del boleto es: ${precioBase}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
