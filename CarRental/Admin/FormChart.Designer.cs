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
            plt_2 = new ScottPlot.FormsPlot();
            SuspendLayout();
            // 
            // plt_1
            // 
            plt_1.Location = new Point(34, 117);
            plt_1.Margin = new Padding(5, 4, 5, 4);
            plt_1.Name = "plt_1";
            plt_1.Size = new Size(431, 301);
            plt_1.TabIndex = 0;
            // 
            // plt_2
            // 
            plt_2.Location = new Point(567, 117);
            plt_2.Margin = new Padding(5, 4, 5, 4);
            plt_2.Name = "plt_2";
            plt_2.Size = new Size(431, 301);
            plt_2.TabIndex = 1;
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 458);
            Controls.Add(plt_2);
            Controls.Add(plt_1);
            Name = "FormChart";
            Text = "Thống kê";
            Load += FormChart_Load;
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.FormsPlot plt_1;
        private ScottPlot.FormsPlot plt_2;
    }
}