using Domain.Entities;
using Infraestructura.Prestamo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario_Pago.Forms
{
    public partial class FrmCalendario : Form
    {
        
        BDPrestamo BD = new BDPrestamo();
        CalendarioCalcular CC = new CalendarioCalcular();
        public FrmCalendario()
        {
            InitializeComponent();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
                Calendario c = new Calendario()
                {
                    Id = CC.GetLastIndex() + 1,
                    MontoPrestamo = nudMontoDePrestamo.Value,
                    Interes = CC.CalcularInteres(nudMontoDePrestamo.Value, nudInteres.Value, nudTerminos.Value),
                    Terminos = (int)nudTerminos.Value,
                    FechaDePago = dtpFechaDePago.Value,
                    FechaPago = dtpFechaPago.Value,
                    Principal = CC.CalcularPrincipal(nudMontoDePrestamo.Value, nudInteres.Value, nudTerminos.Value),
                    Cuota = Math.Round(CC.CalcularInteres(nudMontoDePrestamo.Value, nudInteres.Value, nudTerminos.Value) + CC.CalcularPrincipal(nudMontoDePrestamo.Value, nudInteres.Value, nudTerminos.Value)),
                    InteresPagado = 0,
                    PrincipalPagado = 0,
                    CuotaPagado = 0,
                    Estado = Domain.Enums.Estado.Pendiente
                };

                BD.Insertar(c);

            dtgvMostrarCalendarios.DataSource = BD.GetAll();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            switch (cmbSelect.SelectedIndex)
            {
                case 0:
                    dtgvMostrarCalendarios.DataSource = CC.GetBy(a => a.Estado == Domain.Enums.Estado.Pendiente);
                    break;

                case 1:
                    dtgvMostrarCalendarios.DataSource = CC.GetBy(a => a.Estado == Domain.Enums.Estado.Pagado);
                    break;

                default:
                    MessageBox.Show("Seleccione una opcion.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
