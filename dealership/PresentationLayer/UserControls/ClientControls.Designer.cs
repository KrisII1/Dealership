namespace PresentationLayer.UserControls
{
    partial class ClientControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.create_btn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.age_lbl = new System.Windows.Forms.Label();
            this.age_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name_txtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(56, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Name:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(502, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 46;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(405, 304);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(66, 32);
            this.update_btn.TabIndex = 45;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(282, 27);
            this.userDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersWidth = 62;
            this.userDataGridView.RowTemplate.Height = 33;
            this.userDataGridView.Size = new System.Drawing.Size(772, 230);
            this.userDataGridView.TabIndex = 44;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(282, 304);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(89, 33);
            this.create_btn.TabIndex = 43;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 23);
            this.textBox4.TabIndex = 42;
            // 
            // age_lbl
            // 
            this.age_lbl.AutoSize = true;
            this.age_lbl.Location = new System.Drawing.Point(139, 127);
            this.age_lbl.Name = "age_lbl";
            this.age_lbl.Size = new System.Drawing.Size(28, 15);
            this.age_lbl.TabIndex = 40;
            this.age_lbl.Text = "Age";
            // 
            // age_numericUpDown
            // 
            this.age_numericUpDown.Location = new System.Drawing.Point(173, 125);
            this.age_numericUpDown.Name = "age_numericUpDown";
            this.age_numericUpDown.Size = new System.Drawing.Size(68, 23);
            this.age_numericUpDown.TabIndex = 39;
            this.age_numericUpDown.ThousandsSeparator = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 23);
            this.textBox1.TabIndex = 37;
            // 
            // name_txtBox
            // 
            this.name_txtBox.Location = new System.Drawing.Point(110, 61);
            this.name_txtBox.Name = "name_txtBox";
            this.name_txtBox.Size = new System.Drawing.Size(128, 23);
            this.name_txtBox.TabIndex = 36;
            // 
            // ClientControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.age_lbl);
            this.Controls.Add(this.age_numericUpDown);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name_txtBox);
            this.Name = "ClientControls";
            this.Size = new System.Drawing.Size(1239, 544);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label label3;
        private Label label2;
        private Button button4;
        private Button update_btn;
        private DataGridView userDataGridView;
        private Button create_btn;
        private TextBox textBox4;
        private Label age_lbl;
        private NumericUpDown age_numericUpDown;
        private TextBox textBox1;
        private TextBox name_txtBox;
    }
}
