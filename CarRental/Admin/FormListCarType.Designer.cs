﻿namespace CarRental.Admin
{
	partial class FormListCarType
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			panel1 = new Panel();
			btn_addtoorder = new FontAwesome.Sharp.IconButton();
			materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
			panel2 = new Panel();
			dgv_cartype = new DataGridView();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_cartype).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(btn_addtoorder);
			panel1.Controls.Add(materialTextBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 96);
			panel1.TabIndex = 1;
			// 
			// btn_addtoorder
			// 
			btn_addtoorder.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_addtoorder.IconColor = Color.Black;
			btn_addtoorder.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_addtoorder.Location = new Point(571, 30);
			btn_addtoorder.Name = "btn_addtoorder";
			btn_addtoorder.Size = new Size(120, 47);
			btn_addtoorder.TabIndex = 1;
			btn_addtoorder.Text = "Tạo hóa đơn";
			btn_addtoorder.UseVisualStyleBackColor = true;
			btn_addtoorder.Click += btn_addtoorder_Click;
			// 
			// materialTextBox1
			// 
			materialTextBox1.AnimateReadOnly = false;
			materialTextBox1.BorderStyle = BorderStyle.None;
			materialTextBox1.Depth = 0;
			materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialTextBox1.LeadingIcon = null;
			materialTextBox1.Location = new Point(147, 27);
			materialTextBox1.MaxLength = 50;
			materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
			materialTextBox1.Multiline = false;
			materialTextBox1.Name = "materialTextBox1";
			materialTextBox1.Size = new Size(125, 50);
			materialTextBox1.TabIndex = 0;
			materialTextBox1.Text = "";
			materialTextBox1.TrailingIcon = null;
			// 
			// panel2
			// 
			panel2.Controls.Add(dgv_cartype);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 96);
			panel2.Name = "panel2";
			panel2.Size = new Size(800, 354);
			panel2.TabIndex = 2;
			// 
			// dgv_cartype
			// 
			dgv_cartype.BackgroundColor = SystemColors.ActiveCaption;
			dgv_cartype.BorderStyle = BorderStyle.None;
			dgv_cartype.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgv_cartype.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgv_cartype.ColumnHeadersHeight = 29;
			dgv_cartype.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgv_cartype.Dock = DockStyle.Fill;
			dgv_cartype.EnableHeadersVisualStyles = false;
			dgv_cartype.GridColor = Color.DeepSkyBlue;
			dgv_cartype.Location = new Point(0, 0);
			dgv_cartype.Name = "dgv_cartype";
			dgv_cartype.RowHeadersVisible = false;
			dgv_cartype.RowHeadersWidth = 51;
			dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = Color.LawnGreen;
			dataGridViewCellStyle2.SelectionForeColor = Color.White;
			dgv_cartype.RowsDefaultCellStyle = dataGridViewCellStyle2;
			dgv_cartype.RowTemplate.Height = 29;
			dgv_cartype.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_cartype.Size = new Size(800, 354);
			dgv_cartype.TabIndex = 2;
			// 
			// FormListCarType
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "FormListCarType";
			Text = "FormListCarType";
			Load += FormListCarType_Load;
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgv_cartype).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private DataGridView dgv_cartype;
		private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
		private FontAwesome.Sharp.IconButton btn_addtoorder;
	}
}