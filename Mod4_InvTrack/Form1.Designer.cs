namespace Mod4_InvTrack
{
    partial class frmInvTrack
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
            btnAdd = new Button();
            btnSubtract = new Button();
            btnClear = new Button();
            textBox1 = new TextBox();
            inputIndex = new TextBox();
            inputQuantity = new TextBox();
            lblInventory = new Label();
            lblIndex = new Label();
            lblQuatity = new Label();
            lblIndexInfo = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 395);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Inventory";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(135, 395);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(117, 23);
            btnSubtract.TabIndex = 1;
            btnSubtract.Text = "Remove Inventory";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(258, 395);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.Lime;
            textBox1.Location = new Point(12, 69);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 98);
            textBox1.TabIndex = 3;
            // 
            // inputIndex
            // 
            inputIndex.Location = new Point(127, 221);
            inputIndex.Name = "inputIndex";
            inputIndex.Size = new Size(100, 23);
            inputIndex.TabIndex = 4;
            // 
            // inputQuantity
            // 
            inputQuantity.Location = new Point(127, 312);
            inputQuantity.Name = "inputQuantity";
            inputQuantity.Size = new Size(100, 23);
            inputQuantity.TabIndex = 5;
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(12, 51);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(100, 15);
            lblInventory.TabIndex = 6;
            lblInventory.Text = "Current Inventory";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(12, 221);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(93, 15);
            lblIndex.TabIndex = 7;
            lblIndex.Text = "Enter Item Index";
            // 
            // lblQuatity
            // 
            lblQuatity.AutoSize = true;
            lblQuatity.Location = new Point(12, 312);
            lblQuatity.Name = "lblQuatity";
            lblQuatity.Size = new Size(83, 15);
            lblQuatity.TabIndex = 8;
            lblQuatity.Text = "Enter Quantity";
            // 
            // lblIndexInfo
            // 
            lblIndexInfo.Location = new Point(258, 221);
            lblIndexInfo.Name = "lblIndexInfo";
            lblIndexInfo.Size = new Size(70, 79);
            lblIndexInfo.TabIndex = 9;
            lblIndexInfo.Text = "0: Laptop  1: Monitor 2: Keyboard 3: Mouse   4: Headset";
            // 
            // frmInvTrack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(430, 450);
            Controls.Add(lblIndexInfo);
            Controls.Add(lblQuatity);
            Controls.Add(lblIndex);
            Controls.Add(lblInventory);
            Controls.Add(inputQuantity);
            Controls.Add(inputIndex);
            Controls.Add(textBox1);
            Controls.Add(btnClear);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Name = "frmInvTrack";
            Text = "Inventory Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSubtract;
        private Button btnClear;
        private TextBox textBox1;
        private TextBox inputIndex;
        private TextBox inputQuantity;
        private Label lblInventory;
        private Label lblIndex;
        private Label lblQuatity;
        private Label lblIndexInfo;
    }
}
