namespace INVENTEK_Test_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupFood = new System.Windows.Forms.GroupBox();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.lblQty = new System.Windows.Forms.Label();
            this.rdDessert = new System.Windows.Forms.RadioButton();
            this.rdDrink = new System.Windows.Forms.RadioButton();
            this.rdFries = new System.Windows.Forms.RadioButton();
            this.rdBurger = new System.Windows.Forms.RadioButton();
            this.groupDelivery = new System.Windows.Forms.GroupBox();
            this.rdPickUp = new System.Windows.Forms.RadioButton();
            this.rdZone3 = new System.Windows.Forms.RadioButton();
            this.rdZone2 = new System.Windows.Forms.RadioButton();
            this.rdZone1 = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Units = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printInvoice = new System.Drawing.Printing.PrintDocument();
            this.groupFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.groupDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFood
            // 
            this.groupFood.Controls.Add(this.btnInvoice);
            this.groupFood.Controls.Add(this.numQty);
            this.groupFood.Controls.Add(this.lblQty);
            this.groupFood.Controls.Add(this.rdDessert);
            this.groupFood.Controls.Add(this.rdDrink);
            this.groupFood.Controls.Add(this.rdFries);
            this.groupFood.Controls.Add(this.rdBurger);
            this.groupFood.Location = new System.Drawing.Point(12, 18);
            this.groupFood.Name = "groupFood";
            this.groupFood.Size = new System.Drawing.Size(136, 198);
            this.groupFood.TabIndex = 0;
            this.groupFood.TabStop = false;
            this.groupFood.Text = "Food Menu";
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(13, 161);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(109, 23);
            this.btnInvoice.TabIndex = 3;
            this.btnInvoice.Text = "Add To Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(42, 127);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(47, 20);
            this.numQty.TabIndex = 2;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(10, 129);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(26, 13);
            this.lblQty.TabIndex = 1;
            this.lblQty.Text = "Qty:";
            // 
            // rdDessert
            // 
            this.rdDessert.AutoSize = true;
            this.rdDessert.Location = new System.Drawing.Point(10, 98);
            this.rdDessert.Name = "rdDessert";
            this.rdDessert.Size = new System.Drawing.Size(61, 17);
            this.rdDessert.TabIndex = 0;
            this.rdDessert.Text = "Dessert";
            this.rdDessert.UseVisualStyleBackColor = true;
            // 
            // rdDrink
            // 
            this.rdDrink.AutoSize = true;
            this.rdDrink.Location = new System.Drawing.Point(10, 75);
            this.rdDrink.Name = "rdDrink";
            this.rdDrink.Size = new System.Drawing.Size(72, 17);
            this.rdDrink.TabIndex = 0;
            this.rdDrink.Text = "Soft Drink";
            this.rdDrink.UseVisualStyleBackColor = true;
            // 
            // rdFries
            // 
            this.rdFries.AutoSize = true;
            this.rdFries.Location = new System.Drawing.Point(10, 52);
            this.rdFries.Name = "rdFries";
            this.rdFries.Size = new System.Drawing.Size(47, 17);
            this.rdFries.TabIndex = 0;
            this.rdFries.Text = "Fries";
            this.rdFries.UseVisualStyleBackColor = true;
            // 
            // rdBurger
            // 
            this.rdBurger.AutoSize = true;
            this.rdBurger.Location = new System.Drawing.Point(10, 29);
            this.rdBurger.Name = "rdBurger";
            this.rdBurger.Size = new System.Drawing.Size(56, 17);
            this.rdBurger.TabIndex = 0;
            this.rdBurger.Text = "Burger";
            this.rdBurger.UseVisualStyleBackColor = true;
            // 
            // groupDelivery
            // 
            this.groupDelivery.Controls.Add(this.rdPickUp);
            this.groupDelivery.Controls.Add(this.rdZone3);
            this.groupDelivery.Controls.Add(this.rdZone2);
            this.groupDelivery.Controls.Add(this.rdZone1);
            this.groupDelivery.Location = new System.Drawing.Point(12, 222);
            this.groupDelivery.Name = "groupDelivery";
            this.groupDelivery.Size = new System.Drawing.Size(136, 117);
            this.groupDelivery.TabIndex = 1;
            this.groupDelivery.TabStop = false;
            this.groupDelivery.Text = "Delivery Options";
            // 
            // rdPickUp
            // 
            this.rdPickUp.AutoSize = true;
            this.rdPickUp.Location = new System.Drawing.Point(13, 90);
            this.rdPickUp.Name = "rdPickUp";
            this.rdPickUp.Size = new System.Drawing.Size(97, 17);
            this.rdPickUp.TabIndex = 0;
            this.rdPickUp.TabStop = true;
            this.rdPickUp.Text = "Eat In / Pickup";
            this.rdPickUp.UseVisualStyleBackColor = true;
            this.rdPickUp.CheckedChanged += new System.EventHandler(this.rdPickUp_CheckedChanged);
            // 
            // rdZone3
            // 
            this.rdZone3.AutoSize = true;
            this.rdZone3.Location = new System.Drawing.Point(13, 67);
            this.rdZone3.Name = "rdZone3";
            this.rdZone3.Size = new System.Drawing.Size(59, 17);
            this.rdZone3.TabIndex = 0;
            this.rdZone3.TabStop = true;
            this.rdZone3.Text = "Zone 3";
            this.rdZone3.UseVisualStyleBackColor = true;
            this.rdZone3.CheckedChanged += new System.EventHandler(this.rdZone3_CheckedChanged);
            // 
            // rdZone2
            // 
            this.rdZone2.AutoSize = true;
            this.rdZone2.Location = new System.Drawing.Point(13, 44);
            this.rdZone2.Name = "rdZone2";
            this.rdZone2.Size = new System.Drawing.Size(59, 17);
            this.rdZone2.TabIndex = 0;
            this.rdZone2.TabStop = true;
            this.rdZone2.Text = "Zone 2";
            this.rdZone2.UseVisualStyleBackColor = true;
            this.rdZone2.CheckedChanged += new System.EventHandler(this.rdZone2_CheckedChanged);
            // 
            // rdZone1
            // 
            this.rdZone1.AutoSize = true;
            this.rdZone1.Location = new System.Drawing.Point(13, 21);
            this.rdZone1.Name = "rdZone1";
            this.rdZone1.Size = new System.Drawing.Size(59, 17);
            this.rdZone1.TabIndex = 0;
            this.rdZone1.TabStop = true;
            this.rdZone1.Text = "Zone 1";
            this.rdZone1.UseVisualStyleBackColor = true;
            this.rdZone1.CheckedChanged += new System.EventHandler(this.rdZone1_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(145, 363);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 43);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(286, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(377, 321);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(445, 318);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(106, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(377, 296);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(57, 13);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Sales Tax:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(445, 293);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(106, 20);
            this.txtTax.TabIndex = 4;
            this.txtTax.Text = "7%";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.Location = new System.Drawing.Point(377, 270);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(48, 13);
            this.lblDelivery.TabIndex = 3;
            this.lblDelivery.Text = "Delivery:";
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(445, 267);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(106, 20);
            this.txtDelivery.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(445, 242);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(106, 20);
            this.txtSubtotal.TabIndex = 4;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Units,
            this.Rate,
            this.Subtotal});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(172, 26);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(379, 210);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 133;
            // 
            // Units
            // 
            this.Units.Text = "Units";
            this.Units.Width = 71;
            // 
            // Rate
            // 
            this.Rate.Text = "Rate";
            this.Rate.Width = 87;
            // 
            // Subtotal
            // 
            this.Subtotal.Text = "Subtotal";
            this.Subtotal.Width = 84;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(172, 245);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(445, 345);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(106, 23);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir factura";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printInvoice
            // 
            this.printInvoice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 421);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtDelivery);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupDelivery);
            this.Controls.Add(this.groupFood);
            this.MaximumSize = new System.Drawing.Size(580, 460);
            this.MinimumSize = new System.Drawing.Size(580, 460);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupFood.ResumeLayout(false);
            this.groupFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.groupDelivery.ResumeLayout(false);
            this.groupDelivery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFood;
        private System.Windows.Forms.RadioButton rdDrink;
        private System.Windows.Forms.RadioButton rdFries;
        private System.Windows.Forms.RadioButton rdBurger;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.RadioButton rdDessert;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.GroupBox groupDelivery;
        private System.Windows.Forms.RadioButton rdPickUp;
        private System.Windows.Forms.RadioButton rdZone3;
        private System.Windows.Forms.RadioButton rdZone2;
        private System.Windows.Forms.RadioButton rdZone1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Units;
        private System.Windows.Forms.ColumnHeader Rate;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printInvoice;
    }
}

