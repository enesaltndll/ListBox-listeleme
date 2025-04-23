using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevGP
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
           lblİller.Items.Add(txtİl.Text); 
           txtİl.Clear(); 
            
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            List<object> selectedItems = new List<object>();
            foreach (var item in lblİller.SelectedItems)
            {

                if (!lblİller2.Items.Contains(item))
                {

                    
                    lblİller2.Items.Add(item);

                }
                selectedItems.Add(item);
            }
            foreach (var item in selectedItems)
            {
                lblİller.Items.Remove(item);
            }
        }

        

        private void btnLeft_Click_1(object sender, EventArgs e)
        {
            List<object> selectedItems = new List<object>();

            foreach (var item in lblİller2.SelectedItems)
            {
                if (!lblİller.Items.Contains(item))
                {
                    lblİller.Items.Add(item);
                }

                selectedItems.Add(item);
            }

            foreach (var item in selectedItems)
            {
                lblİller2.Items.Remove(item);
            }
        }
    }
}
