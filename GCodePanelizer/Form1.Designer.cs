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
            button1 = new Button();
            txNumRighe = new TextBox();
            lbRighe = new Label();
            label1 = new Label();
            txNumColonne = new TextBox();
            txDistanzaX = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(38, 82);
            button1.Name = "button1";
            button1.Size = new Size(166, 37);
            button1.TabIndex = 0;
            button1.Text = "Crea Pannello";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            label1.Location = new Point(38, 40);
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
            txDistanzaX.Location = new Point(229, 6);
            txDistanzaX.Name = "txDistanzaX";
            txDistanzaX.Size = new Size(100, 23);
            txDistanzaX.TabIndex = 5;
            txDistanzaX.Text = "25";
            txDistanzaX.TextAlign = HorizontalAlignment.Right;
            // 
            // fmGCodePanelizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 142);
            Controls.Add(txDistanzaX);
            Controls.Add(txNumColonne);
            Controls.Add(label1);
            Controls.Add(lbRighe);
            Controls.Add(txNumRighe);
            Controls.Add(button1);
            Name = "fmGCodePanelizer";
            Text = "GCode Panelizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txNumRighe;
        private Label lbRighe;
        private Label label1;
        private TextBox txNumColonne;
        private TextBox txDistanzaX;
    }
}
