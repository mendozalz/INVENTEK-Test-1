using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


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

        // Total, subtota y tax
        double subtotal = 0;
        double tax = 0.07;
        double total = 0;

        // Ruta imagen de imagotipo para la impresión
        string imagen = @"C:\Users\MENDO\Desktop\C#\INVENTEK-Test#1\img\imagotipo.png";

        // Nombre predeterminado del documento a imprimir
        string nombreArchivoPredeterminado = "Factura.pdf";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            try
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
            catch (FormatException ex)
            {
                MessageBox.Show("Error al convertir la cantidad a un número entero.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message);
            }
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

        private void UpdateInvoiceDetails()
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
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
            catch (FormatException ex)
            {
                MessageBox.Show("Error al convertir el precio del artículo a un número.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message);
            }
        }


        private void rdZone1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdZone1.Checked)
                {
                    RemoveDeliveryFromInvoice();
                    AddDeliveryToInvoice("Delivery (Zone 1)", zona1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message);
            }
        }

        private void rdZone2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdZone2.Checked)
                {
                    RemoveDeliveryFromInvoice();
                    AddDeliveryToInvoice("Delivery (Zone 2)", zona2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message);
            }
        }

        private void rdZone3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdZone3.Checked)
                {
                    RemoveDeliveryFromInvoice();
                    AddDeliveryToInvoice("Delivery (Zone 3)", zona3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message);
            }
        }

        private void rdPickUp_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdPickUp.Checked)
                {
                    RemoveDeliveryFromInvoice();
                    AddDeliveryToInvoice("Pickup", eatIn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message);
            }
        }

        private void RemoveDeliveryFromInvoice()
        {
            try
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
            catch (FormatException ex)
            {
                MessageBox.Show("Error al convertir el precio del artículo a un número.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message);
            }
        }

        private void AddDeliveryToInvoice(string itemName, double itemPrice)
        {
            try
            {
                ListViewItem item = new ListViewItem(itemName);
                item.SubItems.Add("1");
                item.SubItems.Add(itemPrice.ToString());
                item.SubItems.Add(itemPrice.ToString());

                listView.Items.Add(item);

                subtotal += itemPrice;

                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message);
            }
        }

        private void CalculateTotal()
        {
            try
            {
                double totalTax = subtotal * tax;
                total = subtotal + totalTax;

                txtSubtotal.Text = subtotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
                txtTotal.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printInvoice = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printInvoice.PrinterSettings = ps;
            printInvoice.PrintPage += Imprimir;
            printInvoice.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            int width = 600;
            int y = 20;
            Image img = Image.FromFile(imagen);
            e.Graphics.DrawImage(img, new Rectangle(50, y += 20, 100, 100));
            e.Graphics.DrawString("--- Ticket Invoice ---", font, Brushes.Black, new RectangleF(350, y += 100, width, 20));

            foreach (ListViewItem item in listView.Items)
            {
                string itemName = item.SubItems[0].Text;
                string itemQuantity = item.SubItems[1].Text;
                string itemPrice = item.SubItems[2].Text;

                string itemInfo = $"{itemName} - Quantity: {itemQuantity} - Price: ${itemPrice}";

                e.Graphics.DrawString(itemInfo, font, Brushes.Black, new RectangleF(280, y += 40, width, 20));


            }

            double subtotal = 0;
            foreach (ListViewItem item in listView.Items)
            {
                double itemPrice = Convert.ToDouble(item.SubItems[2].Text);
                int itemQuantity = Convert.ToInt32(item.SubItems[1].Text);
                subtotal += itemPrice * itemQuantity;
            }

            double taxAmount = subtotal * tax;

            double totalAmount = subtotal + taxAmount;

                e.Graphics.DrawString("-----------------------------------------------------------", font, Brushes.Black, new RectangleF(270, y += 40, width, 20));
                e.Graphics.DrawString($"Subtotal: {subtotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}", font, Brushes.Black, new RectangleF(280, y += 20, width, 20));
            e.Graphics.DrawString($"Tax: {taxAmount.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}", font, Brushes.Black, new RectangleF(280, y += 30, width, 20));
            e.Graphics.DrawString($"Total: {totalAmount.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}", font, Brushes.Black, new RectangleF(280, y += 30, width, 20));
        }

        // Guardar y cargar transacción

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction transaccion = new Transaction
                {
                    Items = new List<TransactionItem>(),
                    Subtotal = subtotal,
                    Tax = tax,
                    Total = total
                };

                foreach (ListViewItem item in listView.Items)
                {
                    TransactionItem itemTransaccion = new TransactionItem
                    {
                        Nombre = item.SubItems[0].Text,
                        Cantidad = Convert.ToInt32(item.SubItems[1].Text),
                        Precio = Convert.ToDouble(item.SubItems[2].Text),
                        Total = Convert.ToDouble(item.SubItems[3].Text)
                    };
                    transaccion.Items.Add(itemTransaccion);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(Transaction));
                using (TextWriter writer = new StreamWriter(@"C:\Users\MENDO\Desktop\C#\INVENTEK-Test#1\Transactions\transaccion.xml"))
                {
                    serializer.Serialize(writer, transaccion);
                }

                MessageBox.Show("Transacción guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error al guardar la transacción: " + ex.Message);
            }
        }

        private void btnLoadTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Transaction));
                using (Stream reader = new FileStream(@"C:\Users\MENDO\Desktop\C#\INVENTEK-Test#1\Transactions\transaccion.xml", FileMode.Open))
                {
                    Transaction transaccion = (Transaction)serializer.Deserialize(reader);

                    listView.Items.Clear();

                    foreach (TransactionItem item in transaccion.Items)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.Nombre);
                        listViewItem.SubItems.Add(item.Cantidad.ToString());
                        listViewItem.SubItems.Add(item.Precio.ToString());
                        listViewItem.SubItems.Add(item.Total.ToString());
                        listView.Items.Add(listViewItem);
                    }

                    subtotal = transaccion.Subtotal;
                    tax = transaccion.Tax;
                    total = transaccion.Total;
                    txtSubtotal.Text = subtotal.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                    txtTotal.Text = total.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                }

                MessageBox.Show("Transacción cargada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error al cargar la transacción: " + ex.Message);
            }
        }

    }

    public class TransactionItem
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }
    }

    public class Transaction
    {
        public List<TransactionItem> Items { get; set; }
        public double Subtotal { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }
    }


}

