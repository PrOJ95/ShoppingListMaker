namespace ShoppingListMaker
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
            nametxt = new TextBox();
            addButton = new Button();
            removeButton = new Button();
            pricetxt = new TextBox();
            quantitynum = new NumericUpDown();
            weightnum = new NumericUpDown();
            namelbl = new Label();
            pricelbl = new Label();
            weightlbl = new Label();
            quantitylbl = new Label();
            currentTotallbl = new Label();
            currentWeightlbl = new Label();
            shoppingListView = new ListView();
            currentTotalNum = new Label();
            currentWeightNum = new Label();
            ((System.ComponentModel.ISupportInitialize)quantitynum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weightnum).BeginInit();
            SuspendLayout();
            // 
            // nametxt
            // 
            nametxt.Location = new Point(59, 11);
            nametxt.Multiline = true;
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(209, 26);
            nametxt.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(15, 146);
            addButton.Name = "addButton";
            addButton.Size = new Size(111, 68);
            addButton.TabIndex = 2;
            addButton.Text = "Add to List";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(151, 146);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(111, 68);
            removeButton.TabIndex = 3;
            removeButton.Text = "Remove from List";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(59, 43);
            pricetxt.Multiline = true;
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(209, 26);
            pricetxt.TabIndex = 4;
            // 
            // quantitynum
            // 
            quantitynum.Location = new Point(151, 104);
            quantitynum.Name = "quantitynum";
            quantitynum.Size = new Size(120, 23);
            quantitynum.TabIndex = 5;
            // 
            // weightnum
            // 
            weightnum.Location = new Point(151, 75);
            weightnum.Name = "weightnum";
            weightnum.Size = new Size(120, 23);
            weightnum.TabIndex = 6;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Location = new Point(9, 14);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(42, 15);
            namelbl.TabIndex = 7;
            namelbl.Text = "Name:";
            // 
            // pricelbl
            // 
            pricelbl.AutoSize = true;
            pricelbl.Location = new Point(12, 46);
            pricelbl.Name = "pricelbl";
            pricelbl.Size = new Size(36, 15);
            pricelbl.TabIndex = 8;
            pricelbl.Text = "Price:";
            // 
            // weightlbl
            // 
            weightlbl.AutoSize = true;
            weightlbl.Location = new Point(97, 77);
            weightlbl.Name = "weightlbl";
            weightlbl.Size = new Size(48, 15);
            weightlbl.TabIndex = 9;
            weightlbl.Text = "Weight:";
            // 
            // quantitylbl
            // 
            quantitylbl.AutoSize = true;
            quantitylbl.Location = new Point(89, 106);
            quantitylbl.Name = "quantitylbl";
            quantitylbl.Size = new Size(56, 15);
            quantitylbl.TabIndex = 10;
            quantitylbl.Text = "Quantity:";
            // 
            // currentTotallbl
            // 
            currentTotallbl.AutoSize = true;
            currentTotallbl.Location = new Point(15, 253);
            currentTotallbl.Name = "currentTotallbl";
            currentTotallbl.Size = new Size(78, 15);
            currentTotallbl.TabIndex = 11;
            currentTotallbl.Text = "Current Total:";
            // 
            // currentWeightlbl
            // 
            currentWeightlbl.AutoSize = true;
            currentWeightlbl.Location = new Point(15, 289);
            currentWeightlbl.Name = "currentWeightlbl";
            currentWeightlbl.Size = new Size(91, 15);
            currentWeightlbl.TabIndex = 12;
            currentWeightlbl.Text = "Current Weight:";
            // 
            // shoppingListView
            // 
            shoppingListView.Location = new Point(277, 11);
            shoppingListView.Name = "shoppingListView";
            shoppingListView.Size = new Size(284, 394);
            shoppingListView.TabIndex = 13;
            shoppingListView.UseCompatibleStateImageBehavior = false;
            shoppingListView.View = View.Details;
            shoppingListView.SelectedIndexChanged += shoppingListView_SelectedIndexChanged;
            // 
            // currentTotalNum
            // 
            currentTotalNum.AutoSize = true;
            currentTotalNum.Location = new Point(126, 253);
            currentTotalNum.Name = "currentTotalNum";
            currentTotalNum.Size = new Size(19, 15);
            currentTotalNum.TabIndex = 14;
            currentTotalNum.Text = "£0";
            // 
            // currentWeightNum
            // 
            currentWeightNum.AutoSize = true;
            currentWeightNum.Location = new Point(126, 289);
            currentWeightNum.Name = "currentWeightNum";
            currentWeightNum.Size = new Size(20, 15);
            currentWeightNum.TabIndex = 15;
            currentWeightNum.Text = "0g";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 415);
            Controls.Add(currentWeightNum);
            Controls.Add(currentTotalNum);
            Controls.Add(shoppingListView);
            Controls.Add(currentWeightlbl);
            Controls.Add(currentTotallbl);
            Controls.Add(quantitylbl);
            Controls.Add(weightlbl);
            Controls.Add(pricelbl);
            Controls.Add(namelbl);
            Controls.Add(weightnum);
            Controls.Add(quantitynum);
            Controls.Add(pricetxt);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(nametxt);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Shopping List Maker";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)quantitynum).EndInit();
            ((System.ComponentModel.ISupportInitialize)weightnum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nametxt;
        private Button addButton;
        private Button removeButton;
        private TextBox pricetxt;
        private NumericUpDown quantitynum;
        private NumericUpDown weightnum;
        private Label namelbl;
        private Label pricelbl;
        private Label weightlbl;
        private Label quantitylbl;
        private Label currentTotallbl;
        private Label currentWeightlbl;
        private ListView shoppingListView;
        private Label currentTotalNum;
        private Label currentWeightNum;
    }
}