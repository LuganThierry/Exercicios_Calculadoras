namespace TP.Aula02
{
    partial class FrmCalculator
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
            this.components = new System.ComponentModel.Container();
            this.BtmCalculate = new System.Windows.Forms.Button();
            this.BtmClean = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PctAda = new System.Windows.Forms.PictureBox();
            this.LblReturn = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblWeight = new System.Windows.Forms.Label();
            this.TxbWeight = new System.Windows.Forms.MaskedTextBox();
            this.TxbHeight = new System.Windows.Forms.MaskedTextBox();
            this.LblHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctAda)).BeginInit();
            this.SuspendLayout();
            // 
            // BtmCalculate
            // 
            this.BtmCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.BtmCalculate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtmCalculate.Location = new System.Drawing.Point(95, 340);
            this.BtmCalculate.Name = "BtmCalculate";
            this.BtmCalculate.Size = new System.Drawing.Size(179, 41);
            this.BtmCalculate.TabIndex = 0;
            this.BtmCalculate.Text = "Calculate";
            this.BtmCalculate.UseVisualStyleBackColor = false;
            this.BtmCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtmClean
            // 
            this.BtmClean.BackColor = System.Drawing.Color.SteelBlue;
            this.BtmClean.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtmClean.Location = new System.Drawing.Point(95, 467);
            this.BtmClean.Name = "BtmClean";
            this.BtmClean.Size = new System.Drawing.Size(179, 41);
            this.BtmClean.TabIndex = 1;
            this.BtmClean.Text = "Clean";
            this.BtmClean.UseVisualStyleBackColor = false;
            this.BtmClean.Click += new System.EventHandler(this.BtmClean_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PctAda
            // 
            this.PctAda.Image = global::TP.Aula02.Properties.Resources.Ada;
            this.PctAda.Location = new System.Drawing.Point(95, 12);
            this.PctAda.Name = "PctAda";
            this.PctAda.Size = new System.Drawing.Size(208, 110);
            this.PctAda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctAda.TabIndex = 6;
            this.PctAda.TabStop = false;
            // 
            // LblReturn
            // 
            this.LblReturn.AutoSize = true;
            this.LblReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblReturn.ForeColor = System.Drawing.Color.Brown;
            this.LblReturn.Location = new System.Drawing.Point(25, 405);
            this.LblReturn.Name = "LblReturn";
            this.LblReturn.Size = new System.Drawing.Size(57, 21);
            this.LblReturn.TabIndex = 7;
            this.LblReturn.Text = "Return";
            this.LblReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblReturn.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.ForeColor = System.Drawing.Color.Olive;
            this.LblTitle.Location = new System.Drawing.Point(110, 139);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(183, 50);
            this.LblTitle.TabIndex = 8;
            this.LblTitle.Text = "Calculadora de IMC \r\nby Ada";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblWeight.Location = new System.Drawing.Point(25, 283);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(59, 21);
            this.LblWeight.TabIndex = 4;
            this.LblWeight.Text = "Weight";
            this.LblWeight.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxbWeight
            // 
            this.TxbWeight.Location = new System.Drawing.Point(95, 285);
            this.TxbWeight.Name = "TxbWeight";
            this.TxbWeight.Size = new System.Drawing.Size(170, 23);
            this.TxbWeight.TabIndex = 10;
            this.TxbWeight.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxbWeight_MaskInputRejected);
            // 
            // TxbHeight
            // 
            this.TxbHeight.Location = new System.Drawing.Point(95, 227);
            this.TxbHeight.Name = "TxbHeight";
            this.TxbHeight.Size = new System.Drawing.Size(170, 23);
            this.TxbHeight.TabIndex = 9;
            this.TxbHeight.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHeight.Location = new System.Drawing.Point(28, 225);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(56, 21);
            this.LblHeight.TabIndex = 5;
            this.LblHeight.Text = "Height";
            this.LblHeight.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(280, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "kilogram";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(280, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "centimeters";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbWeight);
            this.Controls.Add(this.TxbHeight);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblReturn);
            this.Controls.Add(this.PctAda);
            this.Controls.Add(this.LblHeight);
            this.Controls.Add(this.LblWeight);
            this.Controls.Add(this.BtmClean);
            this.Controls.Add(this.BtmCalculate);
            this.Name = "FrmCalculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctAda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtmCalculate;
        private Button BtmClean;
        private ImageList imageList1;
        private PictureBox PctAda;
        private Label LblReturn;
        private Label LblTitle;
        private Label LblWeight;
        private MaskedTextBox TxbWeight;
        private MaskedTextBox TxbHeight;
        private Label LblHeight;
        private Label label1;
        private Label label2;
    }
}