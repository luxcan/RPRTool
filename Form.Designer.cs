namespace RPRTool {
    partial class Form {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            grpResult = new GroupBox();
            btnClearResult = new Button();
            tboxResult = new RichTextBox();
            tabMain = new TabControl();
            tabPgSimTime = new TabPage();
            btnSimTimeAddMins = new Button();
            txtSimTimeAddMins = new TextBox();
            lblSimTimeAddMins = new Label();
            btnSimTime = new Button();
            tabPgASCII = new TabPage();
            btnAsciiConvert = new Button();
            txtAscii = new TextBox();
            lblAscii = new Label();
            tabPgByteArray = new TabPage();
            lblDoubleToByteArray = new Label();
            txtDoubleToByteArray = new TextBox();
            btnDoubleToByteArray = new Button();
            grpResult.SuspendLayout();
            tabMain.SuspendLayout();
            tabPgSimTime.SuspendLayout();
            tabPgASCII.SuspendLayout();
            tabPgByteArray.SuspendLayout();
            SuspendLayout();
            // 
            // grpResult
            // 
            grpResult.Controls.Add(btnClearResult);
            grpResult.Controls.Add(tboxResult);
            grpResult.Location = new Point(324, 12);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(279, 365);
            grpResult.TabIndex = 1;
            grpResult.TabStop = false;
            grpResult.Text = "Result";
            // 
            // btnClearResult
            // 
            btnClearResult.Location = new Point(6, 335);
            btnClearResult.Name = "btnClearResult";
            btnClearResult.Size = new Size(267, 23);
            btnClearResult.TabIndex = 2;
            btnClearResult.Text = "Clear";
            btnClearResult.UseVisualStyleBackColor = true;
            btnClearResult.Click += btnClearResult_Click;
            // 
            // tboxResult
            // 
            tboxResult.Location = new Point(6, 22);
            tboxResult.Name = "tboxResult";
            tboxResult.Size = new Size(267, 307);
            tboxResult.TabIndex = 2;
            tboxResult.Text = "";
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPgSimTime);
            tabMain.Controls.Add(tabPgASCII);
            tabMain.Controls.Add(tabPgByteArray);
            tabMain.Location = new Point(12, 12);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(295, 365);
            tabMain.TabIndex = 2;
            // 
            // tabPgSimTime
            // 
            tabPgSimTime.Controls.Add(btnSimTimeAddMins);
            tabPgSimTime.Controls.Add(txtSimTimeAddMins);
            tabPgSimTime.Controls.Add(lblSimTimeAddMins);
            tabPgSimTime.Controls.Add(btnSimTime);
            tabPgSimTime.Location = new Point(4, 24);
            tabPgSimTime.Name = "tabPgSimTime";
            tabPgSimTime.Padding = new Padding(3);
            tabPgSimTime.Size = new Size(287, 337);
            tabPgSimTime.TabIndex = 0;
            tabPgSimTime.Text = "Sim Time";
            tabPgSimTime.UseVisualStyleBackColor = true;
            // 
            // btnSimTimeAddMins
            // 
            btnSimTimeAddMins.Location = new Point(140, 71);
            btnSimTimeAddMins.Name = "btnSimTimeAddMins";
            btnSimTimeAddMins.Size = new Size(75, 23);
            btnSimTimeAddMins.TabIndex = 3;
            btnSimTimeAddMins.Text = "Add Mins";
            btnSimTimeAddMins.UseVisualStyleBackColor = true;
            btnSimTimeAddMins.Click += btnSimTimeAddMins_Click;
            // 
            // txtSimTimeAddMins
            // 
            txtSimTimeAddMins.Location = new Point(12, 71);
            txtSimTimeAddMins.Name = "txtSimTimeAddMins";
            txtSimTimeAddMins.Size = new Size(122, 23);
            txtSimTimeAddMins.TabIndex = 2;
            // 
            // lblSimTimeAddMins
            // 
            lblSimTimeAddMins.AutoSize = true;
            lblSimTimeAddMins.Location = new Point(12, 53);
            lblSimTimeAddMins.Name = "lblSimTimeAddMins";
            lblSimTimeAddMins.Size = new Size(203, 15);
            lblSimTimeAddMins.TabIndex = 1;
            lblSimTimeAddMins.Text = "Add Minutes to Current System Time";
            // 
            // btnSimTime
            // 
            btnSimTime.Location = new Point(12, 13);
            btnSimTime.Name = "btnSimTime";
            btnSimTime.Size = new Size(259, 23);
            btnSimTime.TabIndex = 0;
            btnSimTime.Text = "Get Current System Time";
            btnSimTime.UseVisualStyleBackColor = true;
            btnSimTime.Click += btnSimTime_Click;
            // 
            // tabPgASCII
            // 
            tabPgASCII.Controls.Add(btnAsciiConvert);
            tabPgASCII.Controls.Add(txtAscii);
            tabPgASCII.Controls.Add(lblAscii);
            tabPgASCII.Location = new Point(4, 24);
            tabPgASCII.Name = "tabPgASCII";
            tabPgASCII.Padding = new Padding(3);
            tabPgASCII.Size = new Size(287, 337);
            tabPgASCII.TabIndex = 1;
            tabPgASCII.Text = "ASCII";
            tabPgASCII.UseVisualStyleBackColor = true;
            // 
            // btnAsciiConvert
            // 
            btnAsciiConvert.Location = new Point(12, 60);
            btnAsciiConvert.Name = "btnAsciiConvert";
            btnAsciiConvert.Size = new Size(257, 23);
            btnAsciiConvert.TabIndex = 2;
            btnAsciiConvert.Text = "Convert";
            btnAsciiConvert.UseVisualStyleBackColor = true;
            btnAsciiConvert.Click += btnAsciiConvert_Click;
            // 
            // txtAscii
            // 
            txtAscii.Location = new Point(12, 31);
            txtAscii.Name = "txtAscii";
            txtAscii.Size = new Size(257, 23);
            txtAscii.TabIndex = 1;
            // 
            // lblAscii
            // 
            lblAscii.AutoSize = true;
            lblAscii.Location = new Point(12, 13);
            lblAscii.Name = "lblAscii";
            lblAscii.Size = new Size(149, 15);
            lblAscii.TabIndex = 0;
            lblAscii.Text = "Convert Text to ASCII Code";
            // 
            // tabPgByteArray
            // 
            tabPgByteArray.Controls.Add(btnDoubleToByteArray);
            tabPgByteArray.Controls.Add(txtDoubleToByteArray);
            tabPgByteArray.Controls.Add(lblDoubleToByteArray);
            tabPgByteArray.Location = new Point(4, 24);
            tabPgByteArray.Name = "tabPgByteArray";
            tabPgByteArray.Padding = new Padding(3);
            tabPgByteArray.Size = new Size(287, 337);
            tabPgByteArray.TabIndex = 2;
            tabPgByteArray.Text = "Byte Array";
            tabPgByteArray.UseVisualStyleBackColor = true;
            // 
            // lblDoubleToByteArray
            // 
            lblDoubleToByteArray.AutoSize = true;
            lblDoubleToByteArray.Location = new Point(12, 13);
            lblDoubleToByteArray.Name = "lblDoubleToByteArray";
            lblDoubleToByteArray.Size = new Size(235, 15);
            lblDoubleToByteArray.TabIndex = 0;
            lblDoubleToByteArray.Text = "Convert Double to Byte Arrays (Big-Endian)";
            // 
            // txtDoubleToByteArray
            // 
            txtDoubleToByteArray.Location = new Point(12, 31);
            txtDoubleToByteArray.Name = "txtDoubleToByteArray";
            txtDoubleToByteArray.Size = new Size(257, 23);
            txtDoubleToByteArray.TabIndex = 1;
            // 
            // btnDoubleToByteArray
            // 
            btnDoubleToByteArray.Location = new Point(12, 60);
            btnDoubleToByteArray.Name = "btnDoubleToByteArray";
            btnDoubleToByteArray.Size = new Size(257, 23);
            btnDoubleToByteArray.TabIndex = 2;
            btnDoubleToByteArray.Text = "Convert Double";
            btnDoubleToByteArray.UseVisualStyleBackColor = true;
            btnDoubleToByteArray.Click += btnDoubleToByteArray_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 388);
            Controls.Add(tabMain);
            Controls.Add(grpResult);
            Name = "Form";
            Text = "RPR Tool";
            grpResult.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabPgSimTime.ResumeLayout(false);
            tabPgSimTime.PerformLayout();
            tabPgASCII.ResumeLayout(false);
            tabPgASCII.PerformLayout();
            tabPgByteArray.ResumeLayout(false);
            tabPgByteArray.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpResult;
        private Button btnClearResult;
        private RichTextBox tboxResult;
        private TabControl tabMain;
        private TabPage tabPgSimTime;
        private Button btnSimTime;
        private Button btnSimTimeAddMins;
        private TextBox txtSimTimeAddMins;
        private Label lblSimTimeAddMins;
        private TabPage tabPgASCII;
        private Label lblAscii;
        private Button btnAsciiConvert;
        private TextBox txtAscii;
        private TabPage tabPgByteArray;
        private TextBox txtDoubleToByteArray;
        private Label lblDoubleToByteArray;
        private Button btnDoubleToByteArray;
    }
}
