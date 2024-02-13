using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INVENTEK_Test_1
{
    public partial class Form1 : Form
    {
        // Productos
        double burgerPrice = 5.99;
        double friesPrice = 2.99;
        double drinkPrice = 1.99;
        double dessertPrice = 2.99;

        // Delivery
        double zona1 = 2.00;
        double zona2 = 3.00;
        double zona3 = 4.00;
        double eatIn = 0;

        // total, subtota y tax
        double subtotal = 0;
        double tax = 0.07;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(numQty.Value);

            if (rdBurger.Checked)
            {
                AddItemToInvoice("Burger", burgerPrice, qty);
            }
            else if (rdFries.Checked)
            {
                AddItemToInvoice("Fries", friesPrice, qty);
            }
            else if (rdDrink.Checked)
            {
                AddItemToInvoice("Drink", drinkPrice, qty);
            }
            else if (rdDessert.Checked)
            {
                AddItemToInvoice("Dessert", dessertPrice, qty);
            }
            double totalTax = subtotal * tax;
            total = subtotal + (subtotal * tax);
            txtSubtotal.Text = subtotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            txtTotal.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            numQty.Value = 1;
        }

        private void AddItemToInvoice(string itemName, double itemPrice, int quantity)
        {
            ListViewItem item = new ListViewItem(itemName);
            item.SubItems.Add(quantity.ToString());
            item.SubItems.Add(itemPrice.ToString());
            item.SubItems.Add((itemPrice * quantity).ToString());

            listView.Items.Add(item);

            double itemTotal = itemPrice * quantity;
            subtotal += itemTotal;
         }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView.SelectedItems)
            {
                double itemTotal = Convert.ToDouble(item.SubItems[3].Text);
                subtotal -= itemTotal;
                item.Remove();
            }
            double totalTax = subtotal * tax;
            total = subtotal + totalTax;
            txtSubtotal.Text = subtotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            txtTotal.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));

            CalculateTotal();
            rdBurger.Checked = false;
            rdFries.Checked = false;
            rdDrink.Checked = false;
            rdDessert.Checked = false;
            rdZone1.Checked = false;
            rdPickUp.Checked = false;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();

            // Reiniciar los valores de subtotal, impuesto y total a cero
            subtotal = 0;
            total = 0;

            // Recalcular subtotal, impuesto y total y actualizar los TextBox
            CalculateTotal();
            txtSubtotal.Text = subtotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            txtTotal.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));

            // Desmarcar todos los botones de radio
            rdBurger.Checked = false;
            rdFries.Checked = false;
            rdDrink.Checked = false;
            rdDessert.Checked = false;
            rdZone1.Checked = false;
            rdPickUp.Checked = false;
        }


        private void rdZone1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdZone1.Checked)
            {
                RemoveDeliveryFromInvoice();
                AddDeliveryToInvoice("Delivery (Zone 1)", zona1);
            }
        }

        private void rdZone2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdZone2.Checked)
            {
                RemoveDeliveryFromInvoice();
                AddDeliveryToInvoice("Delivery (Zone 2)", zona2);
            }
        }

        private void rdZone3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdZone3.Checked)
            {
                RemoveDeliveryFromInvoice();
                AddDeliveryToInvoice("Delivery (Zone 3)", zona3);
            }
        }

        private void rdPickUp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPickUp.Checked)
            {
                RemoveDeliveryFromInvoice();
                AddDeliveryToInvoice("Pickup", eatIn);
            }
        }

        private void RemoveDeliveryFromInvoice()
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Text == "Delivery (Zone 1)" || item.Text == "Delivery (Zone 2)" || item.Text == "Delivery (Zone 3)" || item.Text == "Pickup")
                {
                    double itemPrice = Convert.ToDouble(item.SubItems[2].Text);
                    subtotal -= itemPrice;
                    item.Remove();
                    break; // Si solo puede haber un elemento de entrega, podemos salir del bucle después de eliminar el primero
                }
            }
        }
        private void AddDeliveryToInvoice(string itemName, double itemPrice)
        {
            ListViewItem item = new ListViewItem(itemName);
            item.SubItems.Add("1");
            item.SubItems.Add(itemPrice.ToString());
            item.SubItems.Add(itemPrice.ToString());

            listView.Items.Add(item);

            subtotal += itemPrice;

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            double totalTax = subtotal * tax;
            total = subtotal + totalTax;

            txtSubtotal.Text = subtotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            txtTotal.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
        }

    }
}
