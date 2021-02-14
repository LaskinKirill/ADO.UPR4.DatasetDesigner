
namespace DatasetDesigner
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
            this.GetCustomerButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GetCustomerButton
            // 
            this.GetCustomerButton.Location = new System.Drawing.Point(12, 12);
            this.GetCustomerButton.Name = "GetCustomerButton";
            this.GetCustomerButton.Size = new System.Drawing.Size(117, 41);
            this.GetCustomerButton.TabIndex = 0;
            this.GetCustomerButton.Text = "Get Customers";
            this.GetCustomerButton.UseVisualStyleBackColor = true;
            this.GetCustomerButton.Click += new System.EventHandler(this.GetCustomerButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(153, 12);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(200, 238);
            this.CustomersListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.GetCustomerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetCustomerButton;
        private System.Windows.Forms.ListBox CustomersListBox;
    }
}

