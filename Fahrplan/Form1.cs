using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrplan
{
    public partial class Form1 : Form
    {
        private ITransport testee;

        public Form1() 
        {
            InitializeComponent();
        }

        public ITransport Testee { get => testee; set => testee = value; }

        private void btn_suche_Click(object sender, EventArgs e)
        {
            Testee = new Transport();
            var connections = Testee.GetConnections(txt_von.Text, txt_nach.Text);

            Connection result = connections.ConnectionList[0];
            ConnectionPoint from = result.From;
            ConnectionPoint to = result.To;

            MessageBox.Show("From: " + from.Station.Name + "\n"
                + "Abfahrt: " + validateDateTime(result.From.Departure) + "\n"
                + "To: " + to.Station.Name + "\n"
                + "Ankunft:" + validateDateTime(result.To.Arrival) + "\n"
                + "Lenght" + result.Duration);
            Console.WriteLine(result.From.Departure);
        }

        private String validateDateTime(String time)

        {
            DateTimeOffset datetime = DateTimeOffset.Parse(time);
            String result = datetime.ToString();
            result = result.Split('+')[0];

            return result;

        }

        private void btn_neuesuche_Click(object sender, EventArgs e)
        {
            txt_von.Clear();
            txt_nach.Clear();
        }
    }
}
