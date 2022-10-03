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
            this.dropDown.FormattingEnabled = true;
            this.dropDown.Location = new System.Drawing.Point(62, 52);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(253, 24);
            this.dropDown.TabIndex = 4;
            // 
            // weightInput
            // 
            this.weightInput.DecimalPlaces = 3;
            this.weightInput.Location = new System.Drawing.Point(62, 129);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(94, 22);
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
            this.lengthInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lengthInput.Location = new System.Drawing.Point(221, 129);
            this.lengthInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(94, 22);
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
            this.widthInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.widthInput.Location = new System.Drawing.Point(62, 201);
            this.widthInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(94, 22);
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
            this.heightInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.heightInput.Location = new System.Drawing.Point(221, 202);
            this.heightInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(94, 22);
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
            this.label1.Location = new System.Drawing.Point(162, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "hündürlük(sm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "uzunluq(sm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "En(sm)";
            // 
            // countInput
            // 
            this.countInput.Location = new System.Drawing.Point(62, 251);
            this.countInput.Name = "countInput";
            this.countInput.Size = new System.Drawing.Size(94, 22);
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
            this.label5.Location = new System.Drawing.Point(162, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "say";
            // 
            // cargoTypes
            // 
            this.cargoTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoTypes.FormattingEnabled = true;
            this.cargoTypes.Location = new System.Drawing.Point(221, 251);
            this.cargoTypes.Name = "cargoTypes";
            this.cargoTypes.Size = new System.Drawing.Size(101, 24);
            this.cargoTypes.TabIndex = 15;
            // 
            // totalText
            // 
            this.totalText.AutoSize = true;
            this.totalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.Location = new System.Drawing.Point(57, 310);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(158, 26);
            this.totalText.TabIndex = 16;
            this.totalText.Text = "TOTAL: 0.00$";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Hesabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

