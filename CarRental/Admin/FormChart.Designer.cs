namespace CarRental.Admin
{
    partial class FormChart
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
            plt_1 = new ScottPlot.FormsPlot();
            SuspendLayout();
            // 
            // plt_1
            // 
            plt_1.Location = new Point(247, 107);
            plt_1.Margin = new Padding(5, 4, 5, 4);
            plt_1.Name = "plt_1";
            plt_1.Size = new Size(528, 301);
            plt_1.TabIndex = 0;
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 458);
            Controls.Add(plt_1);
            Name = "FormChart";
            Text = "Thống kê";
            Load += FormChart_Load;
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.FormsPlot plt_1;
    }
}