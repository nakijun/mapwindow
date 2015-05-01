namespace MWLite.GUI.Forms
{
    partial class MeasuringForm
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
            this.chkShowBearing = new System.Windows.Forms.CheckBox();
            this.chkShowLength = new System.Windows.Forms.CheckBox();
            this.cboBearingType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.udBearingPrecision = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAngleFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkShowTotalLength = new System.Windows.Forms.CheckBox();
            this.udLengthPrecision = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLengthUnits = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udBearingPrecision)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udLengthPrecision)).BeginInit();
            this.SuspendLayout();
            // 
            // chkShowBearing
            // 
            this.chkShowBearing.AutoSize = true;
            this.chkShowBearing.Location = new System.Drawing.Point(6, 0);
            this.chkShowBearing.Name = "chkShowBearing";
            this.chkShowBearing.Size = new System.Drawing.Size(91, 17);
            this.chkShowBearing.TabIndex = 0;
            this.chkShowBearing.Text = "Show bearing";
            this.chkShowBearing.UseVisualStyleBackColor = true;
            // 
            // chkShowLength
            // 
            this.chkShowLength.AutoSize = true;
            this.chkShowLength.Location = new System.Drawing.Point(6, 0);
            this.chkShowLength.Name = "chkShowLength";
            this.chkShowLength.Size = new System.Drawing.Size(85, 17);
            this.chkShowLength.TabIndex = 1;
            this.chkShowLength.Text = "Show length";
            this.chkShowLength.UseVisualStyleBackColor = true;
            // 
            // cboBearingType
            // 
            this.cboBearingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBearingType.FormattingEnabled = true;
            this.cboBearingType.Location = new System.Drawing.Point(168, 36);
            this.cboBearingType.Name = "cboBearingType";
            this.cboBearingType.Size = new System.Drawing.Size(121, 21);
            this.cboBearingType.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.udBearingPrecision);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboAngleFormat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboBearingType);
            this.groupBox1.Controls.Add(this.chkShowBearing);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // udBearingPrecision
            // 
            this.udBearingPrecision.Location = new System.Drawing.Point(169, 118);
            this.udBearingPrecision.Name = "udBearingPrecision";
            this.udBearingPrecision.Size = new System.Drawing.Size(120, 20);
            this.udBearingPrecision.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precision";
            // 
            // cboAngleFormat
            // 
            this.cboAngleFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAngleFormat.FormattingEnabled = true;
            this.cboAngleFormat.Location = new System.Drawing.Point(168, 76);
            this.cboAngleFormat.Name = "cboAngleFormat";
            this.cboAngleFormat.Size = new System.Drawing.Size(121, 21);
            this.cboAngleFormat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Angle format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bearing type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkShowTotalLength);
            this.groupBox2.Controls.Add(this.udLengthPrecision);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkShowLength);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboLengthUnits);
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 148);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // chkShowTotalLength
            // 
            this.chkShowTotalLength.AutoSize = true;
            this.chkShowTotalLength.Location = new System.Drawing.Point(34, 110);
            this.chkShowTotalLength.Name = "chkShowTotalLength";
            this.chkShowTotalLength.Size = new System.Drawing.Size(108, 17);
            this.chkShowTotalLength.TabIndex = 8;
            this.chkShowTotalLength.Text = "Show total length";
            this.chkShowTotalLength.UseVisualStyleBackColor = true;
            // 
            // udLengthPrecision
            // 
            this.udLengthPrecision.Location = new System.Drawing.Point(169, 68);
            this.udLengthPrecision.Name = "udLengthPrecision";
            this.udLengthPrecision.Size = new System.Drawing.Size(120, 20);
            this.udLengthPrecision.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precision";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Length units";
            // 
            // cboLengthUnits
            // 
            this.cboLengthUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLengthUnits.FormattingEnabled = true;
            this.cboLengthUnits.Location = new System.Drawing.Point(168, 31);
            this.cboLengthUnits.Name = "cboLengthUnits";
            this.cboLengthUnits.Size = new System.Drawing.Size(121, 21);
            this.cboLengthUnits.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(141, 341);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 26);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(237, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 26);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // MeasuringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 374);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeasuringForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Measuring options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udBearingPrecision)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udLengthPrecision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkShowBearing;
        private System.Windows.Forms.CheckBox chkShowLength;
        private System.Windows.Forms.ComboBox cboBearingType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown udBearingPrecision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAngleFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkShowTotalLength;
        private System.Windows.Forms.NumericUpDown udLengthPrecision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLengthUnits;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}