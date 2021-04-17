namespace Halstead.GUI
{
    partial class frm_Main
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
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_Files = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtg_Operator = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dtg_Operand = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cbox_Folder = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Operator)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Operand)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(314, 28);
            this.txt_Path.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(346, 22);
            this.txt_Path.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Add.Location = new System.Drawing.Point(764, 25);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(124, 28);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Choose Folder";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(764, 83);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(124, 28);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(16, 58);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 481);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_Files);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(732, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_Files
            // 
            this.txt_Files.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Files.Location = new System.Drawing.Point(0, 0);
            this.txt_Files.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Files.Multiline = true;
            this.txt_Files.Name = "txt_Files";
            this.txt_Files.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Files.Size = new System.Drawing.Size(736, 456);
            this.txt_Files.TabIndex = 0;
            this.txt_Files.WordWrap = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_Result);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(732, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Halstead";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_Result
            // 
            this.txt_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result.Location = new System.Drawing.Point(0, 0);
            this.txt_Result.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Result.Size = new System.Drawing.Size(736, 456);
            this.txt_Result.TabIndex = 0;
            this.txt_Result.WordWrap = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtg_Operator);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(732, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Operators";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtg_Operator
            // 
            this.dtg_Operator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Operator.Location = new System.Drawing.Point(0, 0);
            this.dtg_Operator.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_Operator.Name = "dtg_Operator";
            this.dtg_Operator.RowHeadersWidth = 51;
            this.dtg_Operator.Size = new System.Drawing.Size(732, 452);
            this.dtg_Operator.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dtg_Operand);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(732, 452);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Operands";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dtg_Operand
            // 
            this.dtg_Operand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Operand.Location = new System.Drawing.Point(0, 0);
            this.dtg_Operand.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_Operand.Name = "dtg_Operand";
            this.dtg_Operand.RowHeadersWidth = 51;
            this.dtg_Operand.Size = new System.Drawing.Size(732, 452);
            this.dtg_Operand.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(764, 146);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(124, 28);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Export";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cbox_Folder
            // 
            this.cbox_Folder.AutoSize = true;
            this.cbox_Folder.Location = new System.Drawing.Point(667, 30);
            this.cbox_Folder.Name = "cbox_Folder";
            this.cbox_Folder.Size = new System.Drawing.Size(70, 21);
            this.cbox_Folder.TabIndex = 5;
            this.cbox_Folder.Text = "Folder";
            this.cbox_Folder.UseVisualStyleBackColor = true;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 582);
            this.Controls.Add(this.cbox_Folder);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Path);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.Text = "Halstead Complexity Metric";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Operator)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Operand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_Files;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.DataGridView dtg_Operator;
        private System.Windows.Forms.DataGridView dtg_Operand;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.CheckBox cbox_Folder;
    }
}