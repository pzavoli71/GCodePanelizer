namespace GCodePanelizer
{
    partial class fmGCodePanelizer
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
            btCreaPannello = new Button();
            txNumRighe = new TextBox();
            lbRighe = new Label();
            label1 = new Label();
            txNumColonne = new TextBox();
            txDistanzaX = new TextBox();
            txDistanzay = new TextBox();
            txCorpo = new TextBox();
            txHeader = new TextBox();
            txFooter = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btLeggiFile = new Button();
            SuspendLayout();
            // 
            // btCreaPannello
            // 
            btCreaPannello.Location = new Point(599, 35);
            btCreaPannello.Name = "btCreaPannello";
            btCreaPannello.Size = new Size(166, 23);
            btCreaPannello.TabIndex = 0;
            btCreaPannello.Text = "Crea Pannello";
            btCreaPannello.UseVisualStyleBackColor = true;
            btCreaPannello.Click += btCreaPannello_Click;
            // 
            // txNumRighe
            // 
            txNumRighe.Location = new Point(104, 6);
            txNumRighe.Name = "txNumRighe";
            txNumRighe.Size = new Size(62, 23);
            txNumRighe.TabIndex = 1;
            txNumRighe.Text = "3";
            txNumRighe.TextAlign = HorizontalAlignment.Right;
            // 
            // lbRighe
            // 
            lbRighe.AutoSize = true;
            lbRighe.Location = new Point(38, 9);
            lbRighe.Name = "lbRighe";
            lbRighe.Size = new Size(37, 15);
            lbRighe.TabIndex = 2;
            lbRighe.Text = "Righe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 43);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Colonne";
            // 
            // txNumColonne
            // 
            txNumColonne.Location = new Point(104, 40);
            txNumColonne.Name = "txNumColonne";
            txNumColonne.Size = new Size(62, 23);
            txNumColonne.TabIndex = 4;
            txNumColonne.Text = "3";
            txNumColonne.TextAlign = HorizontalAlignment.Right;
            // 
            // txDistanzaX
            // 
            txDistanzaX.Location = new Point(332, 6);
            txDistanzaX.Name = "txDistanzaX";
            txDistanzaX.Size = new Size(64, 23);
            txDistanzaX.TabIndex = 5;
            txDistanzaX.Text = "25";
            txDistanzaX.TextAlign = HorizontalAlignment.Right;
            // 
            // txDistanzay
            // 
            txDistanzay.Location = new Point(332, 40);
            txDistanzay.Name = "txDistanzay";
            txDistanzay.Size = new Size(64, 23);
            txDistanzay.TabIndex = 6;
            txDistanzay.Text = "25";
            txDistanzay.TextAlign = HorizontalAlignment.Right;
            // 
            // txCorpo
            // 
            txCorpo.AcceptsReturn = true;
            txCorpo.Location = new Point(12, 246);
            txCorpo.MaxLength = 300000;
            txCorpo.Multiline = true;
            txCorpo.Name = "txCorpo";
            txCorpo.ScrollBars = ScrollBars.Both;
            txCorpo.Size = new Size(753, 388);
            txCorpo.TabIndex = 7;
            txCorpo.WordWrap = false;
            // 
            // txHeader
            // 
            txHeader.Location = new Point(12, 69);
            txHeader.Multiline = true;
            txHeader.Name = "txHeader";
            txHeader.ScrollBars = ScrollBars.Both;
            txHeader.Size = new Size(753, 170);
            txHeader.TabIndex = 8;
            // 
            // txFooter
            // 
            txFooter.Location = new Point(12, 640);
            txFooter.Multiline = true;
            txFooter.Name = "txFooter";
            txFooter.ScrollBars = ScrollBars.Both;
            txFooter.Size = new Size(753, 108);
            txFooter.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 9);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 10;
            label2.Text = "Larghezza riga (mm)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 43);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 11;
            label3.Text = "Larghezza colonna (mm)";
            // 
            // btLeggiFile
            // 
            btLeggiFile.Location = new Point(599, 9);
            btLeggiFile.Name = "btLeggiFile";
            btLeggiFile.Size = new Size(166, 23);
            btLeggiFile.TabIndex = 12;
            btLeggiFile.Text = "Leggi file gcode";
            btLeggiFile.UseVisualStyleBackColor = true;
            btLeggiFile.Click += btLeggiFile_Click;
            // 
            // fmGCodePanelizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 757);
            Controls.Add(btLeggiFile);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txFooter);
            Controls.Add(txHeader);
            Controls.Add(txCorpo);
            Controls.Add(txDistanzay);
            Controls.Add(txDistanzaX);
            Controls.Add(txNumColonne);
            Controls.Add(label1);
            Controls.Add(lbRighe);
            Controls.Add(txNumRighe);
            Controls.Add(btCreaPannello);
            Name = "fmGCodePanelizer";
            Text = "GCode Panelizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCreaPannello;
        private TextBox txNumRighe;
        private Label lbRighe;
        private Label label1;
        private TextBox txNumColonne;
        private TextBox txDistanzaX;
        private TextBox txDistanzay;
        private TextBox txCorpo;
        private TextBox txHeader;
        private TextBox txFooter;
        private Label label2;
        private Label label3;
        private Button btLeggiFile;
    }
}
