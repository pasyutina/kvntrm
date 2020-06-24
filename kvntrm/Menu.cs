using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kvntrm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonAgents_Click(object sender, EventArgs e)
        {
            Form agentSet = new Agent();
            agentSet.Show();
        }

        private void buttonProvider_Click(object sender, EventArgs e)
        {
            Form providerSet = new Provider();
            providerSet.Show();
        }

        private void buttonPriem_Click(object sender, EventArgs e)
        {
            Form shipmentSet = new Shipment();
            shipmentSet.Show();
        }

        private void buttonNal_Click(object sender, EventArgs e)
        {
            Form materialsSet = new Material();
            materialsSet.Show();
        }

        private void buttonExtra_Click(object sender, EventArgs e)
        {
            Form extraSet = new Extradition();
            extraSet.Show();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            Form sumSet = new Summary_list();
            sumSet.Show();
        }
    }
}
