namespace Shipping_Of_Goods_System
{
    partial class frmShipping
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLogo = new TextBox();
            lblClientID = new Label();
            txtClientID = new TextBox();
            txtSeaFreight = new TextBox();
            lblSeaFreight = new Label();
            txtLandTransport = new TextBox();
            lblLandTransport = new Label();
            txtAirCargo = new TextBox();
            lblAirCargo = new Label();
            SuspendLayout();
            // 
            // txtLogo
            // 
            txtLogo.Font = new Font("Sitka Text", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtLogo.Location = new Point(552, 12);
            txtLogo.Multiline = true;
            txtLogo.Name = "txtLogo";
            txtLogo.Size = new Size(543, 57);
            txtLogo.TabIndex = 0;
            txtLogo.Text = "Shipping of Goods System";
            txtLogo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblClientID
            // 
            lblClientID.AutoSize = true;
            lblClientID.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClientID.Location = new Point(578, 176);
            lblClientID.Name = "lblClientID";
            lblClientID.Size = new Size(174, 35);
            lblClientID.TabIndex = 1;
            lblClientID.Text = "Client ID :";
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(750, 176);
            txtClientID.Multiline = true;
            txtClientID.Name = "txtClientID";
            txtClientID.ReadOnly = true;
            txtClientID.Size = new Size(246, 35);
            txtClientID.TabIndex = 2;
            // 
            // txtSeaFreight
            // 
            txtSeaFreight.Location = new Point(750, 309);
            txtSeaFreight.Multiline = true;
            txtSeaFreight.Name = "txtSeaFreight";
            txtSeaFreight.ReadOnly = true;
            txtSeaFreight.Size = new Size(246, 35);
            txtSeaFreight.TabIndex = 4;
            // 
            // lblSeaFreight
            // 
            lblSeaFreight.AutoSize = true;
            lblSeaFreight.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeaFreight.Location = new Point(447, 309);
            lblSeaFreight.Name = "lblSeaFreight";
            lblSeaFreight.Size = new Size(305, 35);
            lblSeaFreight.TabIndex = 3;
            lblSeaFreight.Text = "Sea Freight Tons :";
            // 
            // txtLandTransport
            // 
            txtLandTransport.Location = new Point(750, 243);
            txtLandTransport.Multiline = true;
            txtLandTransport.Name = "txtLandTransport";
            txtLandTransport.ReadOnly = true;
            txtLandTransport.Size = new Size(246, 35);
            txtLandTransport.TabIndex = 6;
            // 
            // lblLandTransport
            // 
            lblLandTransport.AutoSize = true;
            lblLandTransport.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLandTransport.Location = new Point(383, 243);
            lblLandTransport.Name = "lblLandTransport";
            lblLandTransport.Size = new Size(369, 35);
            lblLandTransport.TabIndex = 5;
            lblLandTransport.Text = "Land Transport Tons :";
            // 
            // txtAirCargo
            // 
            txtAirCargo.Location = new Point(750, 374);
            txtAirCargo.Multiline = true;
            txtAirCargo.Name = "txtAirCargo";
            txtAirCargo.ReadOnly = true;
            txtAirCargo.Size = new Size(246, 35);
            txtAirCargo.TabIndex = 8;
            // 
            // lblAirCargo
            // 
            lblAirCargo.AutoSize = true;
            lblAirCargo.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAirCargo.Location = new Point(481, 374);
            lblAirCargo.Name = "lblAirCargo";
            lblAirCargo.Size = new Size(271, 35);
            lblAirCargo.TabIndex = 7;
            lblAirCargo.Text = "Air Cargo Tons :";
            // 
            // frmShipping
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1633, 823);
            Controls.Add(txtAirCargo);
            Controls.Add(lblAirCargo);
            Controls.Add(txtLandTransport);
            Controls.Add(lblLandTransport);
            Controls.Add(txtSeaFreight);
            Controls.Add(lblSeaFreight);
            Controls.Add(txtClientID);
            Controls.Add(lblClientID);
            Controls.Add(txtLogo);
            Name = "frmShipping";
            Text = "Form Shipping";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogo;
        private Label lblClientID;
        private TextBox txtClientID;
        private TextBox txtSeaFreight;
        private Label lblSeaFreight;
        private TextBox txtLandTransport;
        private Label lblLandTransport;
        private TextBox txtAirCargo;
        private Label lblAirCargo;
    }
}
