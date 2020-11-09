using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maps
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string street = txtBoxStreet.Text;
            string city = txtBoxCity.Text;
            string state = txtBoxState.Text;
            string zip = txtBoxZip.Text;

            try
            {
                StringBuilder queryData = new StringBuilder();
                queryData.Append("http://maps.google.com/maps?q=");

                if (street != string.Empty)
                {
                    queryData.Append(street + "," + "+");
                }

                if (city != string.Empty)
                {
                    queryData.Append(city + "," + "+");
                }

                if (zip != string.Empty)
                {
                    queryData.Append(zip + "," + "+");
                }
                webBrowser1.Navigate(queryData.ToString());

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
    }
}
