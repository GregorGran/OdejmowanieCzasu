namespace OdejmowanieCzasu
{
    partial class Form1
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
            startdate = new DateTimePicker();
            enddate = new DateTimePicker();
            calculate = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // startdate
            // 
            startdate.Location = new Point(12, 12);
            startdate.Name = "startdate";
            startdate.Size = new Size(300, 31);
            startdate.TabIndex = 0;
            // 
            // enddate
            // 
            enddate.Location = new Point(12, 61);
            enddate.Name = "enddate";
            enddate.Size = new Size(300, 31);
            enddate.TabIndex = 1;
            // 
            // calculate
            // 
            calculate.BackColor = SystemColors.MenuHighlight;
            calculate.Location = new Point(347, 9);
            calculate.Name = "calculate";
            calculate.Size = new Size(112, 34);
            calculate.TabIndex = 2;
            calculate.Text = "calculate";
            calculate.UseVisualStyleBackColor = false;
            calculate.Click += calculate_Click_1;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(12, 118);
            result.Name = "result";
            result.Size = new Size(63, 25);
            result.TabIndex = 3;
            result.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(483, 169);
            Controls.Add(result);
            Controls.Add(calculate);
            Controls.Add(enddate);
            Controls.Add(startdate);
            Name = "Form1";
            Text = "Time calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker startdate;
        private DateTimePicker enddate;
        private Button calculate;
        private Label result;
    }
}
