namespace FourWindsCustomerList
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonNext = new System.Windows.Forms.Button();
            this.dgvCust = new System.Windows.Forms.DataGridView();
            this.dgvCustCustomerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPositionTo = new System.Windows.Forms.Button();
            this.textboxPositionTo = new System.Windows.Forms.TextBox();
            this.buttonGotoFirst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(555, 67);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(112, 35);
            this.buttonNext.TabIndex = 21;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // dgvCust
            // 
            this.dgvCust.AllowUserToAddRows = false;
            this.dgvCust.AllowUserToDeleteRows = false;
            this.dgvCust.AllowUserToResizeColumns = false;
            this.dgvCust.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCust.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCust.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCust.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCust.ColumnHeadersHeight = 35;
            this.dgvCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCustCustomerNumber,
            this.dgvCustCustomerName});
            this.dgvCust.EnableHeadersVisualStyles = false;
            this.dgvCust.Location = new System.Drawing.Point(48, 123);
            this.dgvCust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCust.MultiSelect = false;
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCust.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCust.RowHeadersVisible = false;
            this.dgvCust.RowTemplate.Height = 24;
            this.dgvCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCust.Size = new System.Drawing.Size(894, 467);
            this.dgvCust.TabIndex = 20;
            // 
            // dgvCustCustomerNumber
            // 
            this.dgvCustCustomerNumber.DataPropertyName = "CMCustNo";
            this.dgvCustCustomerNumber.HeaderText = "Number";
            this.dgvCustCustomerNumber.Name = "dgvCustCustomerNumber";
            // 
            // dgvCustCustomerName
            // 
            this.dgvCustCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCustCustomerName.DataPropertyName = "CMName";
            this.dgvCustCustomerName.HeaderText = "Name";
            this.dgvCustCustomerName.Name = "dgvCustCustomerName";
            // 
            // buttonPositionTo
            // 
            this.buttonPositionTo.Location = new System.Drawing.Point(314, 67);
            this.buttonPositionTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPositionTo.Name = "buttonPositionTo";
            this.buttonPositionTo.Size = new System.Drawing.Size(112, 35);
            this.buttonPositionTo.TabIndex = 23;
            this.buttonPositionTo.Text = "Position To";
            this.buttonPositionTo.UseVisualStyleBackColor = true;
            this.buttonPositionTo.Click += new System.EventHandler(this.buttonPositionTo_Click);
            // 
            // textboxPositionTo
            // 
            this.textboxPositionTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPositionTo.Location = new System.Drawing.Point(53, 71);
            this.textboxPositionTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxPositionTo.Name = "textboxPositionTo";
            this.textboxPositionTo.Size = new System.Drawing.Size(250, 26);
            this.textboxPositionTo.TabIndex = 22;
            // 
            // buttonGotoFirst
            // 
            this.buttonGotoFirst.Location = new System.Drawing.Point(434, 67);
            this.buttonGotoFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGotoFirst.Name = "buttonGotoFirst";
            this.buttonGotoFirst.Size = new System.Drawing.Size(112, 35);
            this.buttonGotoFirst.TabIndex = 24;
            this.buttonGotoFirst.Text = "First";
            this.buttonGotoFirst.UseVisualStyleBackColor = true;
            this.buttonGotoFirst.Click += new System.EventHandler(this.buttonGotoFirst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 655);
            this.Controls.Add(this.buttonGotoFirst);
            this.Controls.Add(this.buttonPositionTo);
            this.Controls.Add(this.textboxPositionTo);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.dgvCust);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.DataGridView dgvCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustCustomerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustCustomerName;
        private System.Windows.Forms.Button buttonPositionTo;
        private System.Windows.Forms.TextBox textboxPositionTo;
        private System.Windows.Forms.Button buttonGotoFirst;
    }
}

