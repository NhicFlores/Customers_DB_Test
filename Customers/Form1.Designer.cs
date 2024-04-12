namespace Customers
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
            button1 = new Button();
            customer_grid_view = new DataGridView();
            textBox1 = new TextBox();
            State = new Label();
            customer_textbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)customer_grid_view).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 103);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Customers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Load_Button_Click;
            // 
            // customer_grid_view
            // 
            customer_grid_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customer_grid_view.Location = new Point(42, 163);
            customer_grid_view.Name = "customer_grid_view";
            customer_grid_view.Size = new Size(692, 275);
            customer_grid_view.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.Location = new Point(140, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // State
            // 
            State.AutoSize = true;
            State.Location = new Point(85, 47);
            State.Name = "State";
            State.Size = new Size(33, 15);
            State.TabIndex = 3;
            State.Text = "State";
            // 
            // customer_textbox
            // 
            customer_textbox.Location = new Point(507, 49);
            customer_textbox.Name = "customer_textbox";
            customer_textbox.Size = new Size(100, 23);
            customer_textbox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customer_textbox);
            Controls.Add(State);
            Controls.Add(textBox1);
            Controls.Add(customer_grid_view);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)customer_grid_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView customer_grid_view;
        private TextBox textBox1;
        private Label State;
        private TextBox customer_textbox;
    }
}
