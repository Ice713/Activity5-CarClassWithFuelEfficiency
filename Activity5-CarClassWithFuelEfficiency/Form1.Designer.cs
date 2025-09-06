namespace Activity5_CarClassWithFuelEfficiency
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMaxDistance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.numericUpDownFuelCapacity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFuelEfficiency = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelEfficiency)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fuel Capacity:";
            // 
            // buttonMaxDistance
            // 
            this.buttonMaxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaxDistance.Location = new System.Drawing.Point(255, 99);
            this.buttonMaxDistance.Name = "buttonMaxDistance";
            this.buttonMaxDistance.Size = new System.Drawing.Size(145, 28);
            this.buttonMaxDistance.TabIndex = 2;
            this.buttonMaxDistance.Text = "Max Distance";
            this.buttonMaxDistance.UseVisualStyleBackColor = true;
            this.buttonMaxDistance.Click += new System.EventHandler(this.buttonMaxDistance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fuel Efficiency:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(252, 160);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 16);
            this.labelOutput.TabIndex = 5;
            // 
            // numericUpDownFuelCapacity
            // 
            this.numericUpDownFuelCapacity.DecimalPlaces = 2;
            this.numericUpDownFuelCapacity.Location = new System.Drawing.Point(358, 30);
            this.numericUpDownFuelCapacity.Name = "numericUpDownFuelCapacity";
            this.numericUpDownFuelCapacity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFuelCapacity.TabIndex = 6;
            // 
            // numericUpDownFuelEfficiency
            // 
            this.numericUpDownFuelEfficiency.DecimalPlaces = 2;
            this.numericUpDownFuelEfficiency.Location = new System.Drawing.Point(358, 58);
            this.numericUpDownFuelEfficiency.Name = "numericUpDownFuelEfficiency";
            this.numericUpDownFuelEfficiency.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFuelEfficiency.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownFuelEfficiency);
            this.Controls.Add(this.numericUpDownFuelCapacity);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonMaxDistance);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Activity 5: Car Class with Fuel Efficiency";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelEfficiency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMaxDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelEfficiency;
    }
}

