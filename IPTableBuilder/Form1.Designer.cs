namespace IPTableBuilder
{
    partial class formIPTableBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIPTableBuilder));
            this.gridSubnets = new System.Windows.Forms.DataGridView();
            this.SubnetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetworkAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstUseableAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondUsableAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUseableAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroadcastAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.boxIP1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxIP2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxIP3 = new System.Windows.Forms.TextBox();
            this.boxIP4 = new System.Windows.Forms.TextBox();
            this.btnFireLasers = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.boxEndDevices = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxSubnetMask = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boxSubnetCount = new System.Windows.Forms.TextBox();
            this.boxClassType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubnets)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSubnets
            // 
            this.gridSubnets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSubnets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSubnets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSubnets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSubnets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubnetNumber,
            this.NetworkAddress,
            this.FirstUseableAddress,
            this.SecondUsableAddress,
            this.blankColumn,
            this.LastUseableAddress,
            this.BroadcastAddress});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSubnets.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSubnets.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.gridSubnets.Location = new System.Drawing.Point(37, 69);
            this.gridSubnets.Name = "gridSubnets";
            this.gridSubnets.Size = new System.Drawing.Size(1008, 293);
            this.gridSubnets.TabIndex = 0;
            // 
            // SubnetNumber
            // 
            this.SubnetNumber.HeaderText = "Subnet #";
            this.SubnetNumber.Name = "SubnetNumber";
            this.SubnetNumber.Width = 150;
            // 
            // NetworkAddress
            // 
            this.NetworkAddress.HeaderText = "Network Address";
            this.NetworkAddress.Name = "NetworkAddress";
            this.NetworkAddress.Width = 150;
            // 
            // FirstUseableAddress
            // 
            this.FirstUseableAddress.HeaderText = "First Useable Address";
            this.FirstUseableAddress.Name = "FirstUseableAddress";
            this.FirstUseableAddress.Width = 160;
            // 
            // SecondUsableAddress
            // 
            this.SecondUsableAddress.HeaderText = "Second Useable Address";
            this.SecondUsableAddress.Name = "SecondUsableAddress";
            this.SecondUsableAddress.Width = 170;
            // 
            // blankColumn
            // 
            this.blankColumn.HeaderText = "...";
            this.blankColumn.Name = "blankColumn";
            this.blankColumn.Width = 30;
            // 
            // LastUseableAddress
            // 
            this.LastUseableAddress.HeaderText = "Last Useable Address";
            this.LastUseableAddress.Name = "LastUseableAddress";
            this.LastUseableAddress.Width = 150;
            // 
            // BroadcastAddress
            // 
            this.BroadcastAddress.HeaderText = "Broadcast Address";
            this.BroadcastAddress.Name = "BroadcastAddress";
            this.BroadcastAddress.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starting IP Address:";
            // 
            // boxIP1
            // 
            this.boxIP1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIP1.Location = new System.Drawing.Point(187, 34);
            this.boxIP1.MaxLength = 3;
            this.boxIP1.Name = "boxIP1";
            this.boxIP1.Size = new System.Drawing.Size(48, 26);
            this.boxIP1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(241, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(321, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = ".";
            // 
            // boxIP2
            // 
            this.boxIP2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIP2.Location = new System.Drawing.Point(267, 34);
            this.boxIP2.MaxLength = 3;
            this.boxIP2.Name = "boxIP2";
            this.boxIP2.Size = new System.Drawing.Size(48, 26);
            this.boxIP2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(401, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = ".";
            // 
            // boxIP3
            // 
            this.boxIP3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIP3.Location = new System.Drawing.Point(347, 36);
            this.boxIP3.MaxLength = 3;
            this.boxIP3.Name = "boxIP3";
            this.boxIP3.Size = new System.Drawing.Size(48, 26);
            this.boxIP3.TabIndex = 6;
            // 
            // boxIP4
            // 
            this.boxIP4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIP4.Location = new System.Drawing.Point(427, 34);
            this.boxIP4.MaxLength = 3;
            this.boxIP4.Name = "boxIP4";
            this.boxIP4.Size = new System.Drawing.Size(48, 26);
            this.boxIP4.TabIndex = 8;
            // 
            // btnFireLasers
            // 
            this.btnFireLasers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireLasers.Location = new System.Drawing.Point(941, 32);
            this.btnFireLasers.Name = "btnFireLasers";
            this.btnFireLasers.Size = new System.Drawing.Size(104, 29);
            this.btnFireLasers.TabIndex = 9;
            this.btnFireLasers.Text = "Fire Lasers!";
            this.btnFireLasers.UseVisualStyleBackColor = true;
            this.btnFireLasers.Click += new System.EventHandler(this.btnFireLasers_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(586, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of end devices:";
            // 
            // boxEndDevices
            // 
            this.boxEndDevices.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxEndDevices.Location = new System.Drawing.Point(764, 34);
            this.boxEndDevices.MaxLength = 3;
            this.boxEndDevices.Name = "boxEndDevices";
            this.boxEndDevices.Size = new System.Drawing.Size(82, 26);
            this.boxEndDevices.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(278, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Subnet Mask:";
            // 
            // boxSubnetMask
            // 
            this.boxSubnetMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boxSubnetMask.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSubnetMask.Location = new System.Drawing.Point(387, 379);
            this.boxSubnetMask.MaxLength = 12;
            this.boxSubnetMask.Name = "boxSubnetMask";
            this.boxSubnetMask.Size = new System.Drawing.Size(118, 26);
            this.boxSubnetMask.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(278, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "# of Subnets:";
            // 
            // boxSubnetCount
            // 
            this.boxSubnetCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boxSubnetCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSubnetCount.Location = new System.Drawing.Point(387, 409);
            this.boxSubnetCount.MaxLength = 99999999;
            this.boxSubnetCount.Name = "boxSubnetCount";
            this.boxSubnetCount.Size = new System.Drawing.Size(118, 26);
            this.boxSubnetCount.TabIndex = 15;
            // 
            // boxClassType
            // 
            this.boxClassType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boxClassType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxClassType.Location = new System.Drawing.Point(143, 379);
            this.boxClassType.MaxLength = 12;
            this.boxClassType.Name = "boxClassType";
            this.boxClassType.Size = new System.Drawing.Size(118, 26);
            this.boxClassType.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Class Type:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(888, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Check For Erros";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formIPTableBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1057, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxClassType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxSubnetCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxSubnetMask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxEndDevices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFireLasers);
            this.Controls.Add(this.boxIP4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxIP3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxIP2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxIP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridSubnets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formIPTableBuilder";
            this.Text = "IP Table Builder";
            ((System.ComponentModel.ISupportInitialize)(this.gridSubnets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSubnets;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubnetNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetworkAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstUseableAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondUsableAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn blankColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUseableAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroadcastAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxIP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxIP2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxIP3;
        private System.Windows.Forms.TextBox boxIP4;
        private System.Windows.Forms.Button btnFireLasers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxEndDevices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxSubnetMask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxSubnetCount;
        private System.Windows.Forms.TextBox boxClassType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

