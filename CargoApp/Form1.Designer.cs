namespace CargoApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.weightInput = new System.Windows.Forms.NumericUpDown();
            this.lengthInput = new System.Windows.Forms.NumericUpDown();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.heightInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cargoTypes = new System.Windows.Forms.ComboBox();
            this.totalText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.headerText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countInput)).BeginInit();
            this.SuspendLayout();
            // 
            // dropDown
            // 
            this.dropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDown.FormattingEnabled = true;
            this.dropDown.Location = new System.Drawing.Point(62, 94);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(164, 28);
            this.dropDown.TabIndex = 4;
            // 
            // weightInput
            // 
            this.weightInput.DecimalPlaces = 3;
            this.weightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightInput.Location = new System.Drawing.Point(62, 166);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(125, 26);
            this.weightInput.TabIndex = 5;
            this.weightInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lengthInput
            // 
            this.lengthInput.DecimalPlaces = 2;
            this.lengthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lengthInput.Location = new System.Drawing.Point(221, 166);
            this.lengthInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.lengthInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(125, 26);
            this.lengthInput.TabIndex = 6;
            this.lengthInput.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // widthInput
            // 
            this.widthInput.DecimalPlaces = 2;
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.widthInput.Location = new System.Drawing.Point(62, 238);
            this.widthInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(125, 26);
            this.widthInput.TabIndex = 7;
            this.widthInput.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // heightInput
            // 
            this.heightInput.DecimalPlaces = 2;
            this.heightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.heightInput.Location = new System.Drawing.Point(221, 239);
            this.heightInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(125, 26);
            this.heightInput.TabIndex = 8;
            this.heightInput.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "çəki(kq)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "hündürlük(sm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "uzunluq(sm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "en(sm)";
            // 
            // countInput
            // 
            this.countInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countInput.Location = new System.Drawing.Point(62, 315);
            this.countInput.Name = "countInput";
            this.countInput.Size = new System.Drawing.Size(125, 26);
            this.countInput.TabIndex = 13;
            this.countInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "say";
            // 
            // cargoTypes
            // 
            this.cargoTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoTypes.FormattingEnabled = true;
            this.cargoTypes.Location = new System.Drawing.Point(221, 313);
            this.cargoTypes.Name = "cargoTypes";
            this.cargoTypes.Size = new System.Drawing.Size(101, 28);
            this.cargoTypes.TabIndex = 15;
            // 
            // totalText
            // 
            this.totalText.AutoSize = true;
            this.totalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.Location = new System.Drawing.Point(223, 378);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(81, 29);
            this.totalText.TabIndex = 16;
            this.totalText.Text = "0.00$";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(62, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Hesabla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.Color.LimeGreen;
            this.headerText.Location = new System.Drawing.Point(261, 20);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(225, 48);
            this.headerText.TabIndex = 18;
            this.headerText.Text = "TısbağaEX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.cargoTypes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.lengthInput);
            this.Controls.Add(this.weightInput);
            this.Controls.Add(this.dropDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TısbağaEX";
            ((System.ComponentModel.ISupportInitialize)(this.weightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox dropDown;
        private System.Windows.Forms.NumericUpDown weightInput;
        private System.Windows.Forms.NumericUpDown lengthInput;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown heightInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown countInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cargoTypes;
        private System.Windows.Forms.Label totalText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label headerText;
    }
}

