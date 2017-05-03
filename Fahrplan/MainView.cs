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
    public partial class MainView : Form
    {
        private ITransport testee;

        public MainView() 
        {
            InitializeComponent();
            testee = new Transport();
        }

        public ITransport Testee { get => testee; set => testee = value; }

        private void btn_suche_Click(object sender, EventArgs e)
        {
            var connections = Testee.GetConnections(txt_von.Text, txt_nach.Text);

                Connection result = connections.ConnectionList[0];
                ConnectionPoint from = result.From;
                ConnectionPoint to = result.To;
            
                lsb_resultat.Items.Add(("Von: " + from.Station.Name + "\n"
                    + " Abfahrt: " + validateDateTime(result.From.Departure) + "\n"
                    + " Nach: " + to.Station.Name + "\n"
                    + " Ankunft:" + validateDateTime(result.To.Arrival) + "\n"
                    + " Länge der Reise " + result.Duration));

            //foreach (string Departure in Abfahrt)
           // {

            //}
            
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
