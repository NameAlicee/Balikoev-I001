
namespace CRUD2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserTableView = new System.Windows.Forms.DataGridView();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.UserPatronBox = new System.Windows.Forms.TextBox();
            this.UserSurnameBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserTableView
            // 
            this.UserTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserTableView.Location = new System.Drawing.Point(12, 354);
            this.UserTableView.Name = "UserTableView";
            this.UserTableView.ReadOnly = true;
            this.UserTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserTableView.Size = new System.Drawing.Size(424, 285);
            this.UserTableView.TabIndex = 0;
            this.UserTableView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserTableView_CellClick);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(78, 94);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(100, 20);
            this.UserNameBox.TabIndex = 1;
            // 
            // UserPatronBox
            // 
            this.UserPatronBox.Location = new System.Drawing.Point(275, 94);
            this.UserPatronBox.Name = "UserPatronBox";
            this.UserPatronBox.Size = new System.Drawing.Size(100, 20);
            this.UserPatronBox.TabIndex = 2;
            // 
            // UserSurnameBox
            // 
            this.UserSurnameBox.Location = new System.Drawing.Point(78, 149);
            this.UserSurnameBox.Name = "UserSurnameBox";
            this.UserSurnameBox.Size = new System.Drawing.Size(100, 20);
            this.UserSurnameBox.TabIndex = 3;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(275, 149);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 20);
            this.LoginBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(78, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 24);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(275, 256);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 24);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Patrynomic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 646);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.UserSurnameBox);
            this.Controls.Add(this.UserPatronBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.UserTableView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserTableView;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox UserPatronBox;
        private System.Windows.Forms.TextBox UserSurnameBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

