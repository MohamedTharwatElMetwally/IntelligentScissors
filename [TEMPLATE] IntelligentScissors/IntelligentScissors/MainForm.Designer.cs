namespace IntelligentScissors
{
    partial class MainForm
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
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mouse_x_position = new System.Windows.Forms.TextBox();
            this.mouse_y_position = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.anchor_x = new System.Windows.Forms.TextBox();
            this.anchor_y = new System.Windows.Forms.TextBox();
            this.autoAnchor = new System.Windows.Forms.Button();
            this.crop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // originalImage
            // 
            this.originalImage.Location = new System.Drawing.Point(4, 4);
            this.originalImage.Margin = new System.Windows.Forms.Padding(4);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(412, 360);
            this.originalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.originalImage.TabIndex = 1;
            this.originalImage.TabStop = false;
            this.originalImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClick);
            this.originalImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(805, 697);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(109, 76);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.Open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 656);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 484);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Smoothed Image";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(667, 744);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(75, 27);
            this.txtHeight.TabIndex = 8;
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(667, 700);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.ReadOnly = true;
            this.txtWidth.Size = new System.Drawing.Size(75, 27);
            this.txtWidth.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 703);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 747);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Height";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.originalImage);
            this.panel2.Location = new System.Drawing.Point(35, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1348, 637);
            this.panel2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 750);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mouse Y Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 703);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mouse X Position";
            // 
            // mouse_x_position
            // 
            this.mouse_x_position.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouse_x_position.Location = new System.Drawing.Point(220, 703);
            this.mouse_x_position.Margin = new System.Windows.Forms.Padding(4);
            this.mouse_x_position.Name = "mouse_x_position";
            this.mouse_x_position.ReadOnly = true;
            this.mouse_x_position.Size = new System.Drawing.Size(75, 27);
            this.mouse_x_position.TabIndex = 18;
            // 
            // mouse_y_position
            // 
            this.mouse_y_position.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouse_y_position.Location = new System.Drawing.Point(220, 746);
            this.mouse_y_position.Margin = new System.Windows.Forms.Padding(4);
            this.mouse_y_position.Name = "mouse_y_position";
            this.mouse_y_position.ReadOnly = true;
            this.mouse_y_position.Size = new System.Drawing.Size(75, 27);
            this.mouse_y_position.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(332, 750);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Anchor Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 703);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Anchor X";
            // 
            // anchor_x
            // 
            this.anchor_x.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anchor_x.Location = new System.Drawing.Point(451, 703);
            this.anchor_x.Margin = new System.Windows.Forms.Padding(4);
            this.anchor_x.Name = "anchor_x";
            this.anchor_x.ReadOnly = true;
            this.anchor_x.Size = new System.Drawing.Size(75, 27);
            this.anchor_x.TabIndex = 22;
            // 
            // anchor_y
            // 
            this.anchor_y.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anchor_y.Location = new System.Drawing.Point(451, 746);
            this.anchor_y.Margin = new System.Windows.Forms.Padding(4);
            this.anchor_y.Name = "anchor_y";
            this.anchor_y.ReadOnly = true;
            this.anchor_y.Size = new System.Drawing.Size(75, 27);
            this.anchor_y.TabIndex = 21;
            // 
            // autoAnchor
            // 
            this.autoAnchor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoAnchor.ForeColor = System.Drawing.Color.Red;
            this.autoAnchor.Location = new System.Drawing.Point(957, 697);
            this.autoAnchor.Margin = new System.Windows.Forms.Padding(4);
            this.autoAnchor.Name = "autoAnchor";
            this.autoAnchor.Size = new System.Drawing.Size(109, 76);
            this.autoAnchor.TabIndex = 25;
            this.autoAnchor.Text = "Auto Anchor";
            this.autoAnchor.UseVisualStyleBackColor = true;
            this.autoAnchor.Click += new System.EventHandler(this.autoAnchor_Click);
            // 
            // crop
            // 
            this.crop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crop.Location = new System.Drawing.Point(1098, 687);
            this.crop.Margin = new System.Windows.Forms.Padding(4);
            this.crop.Name = "crop";
            this.crop.Size = new System.Drawing.Size(80, 37);
            this.crop.TabIndex = 26;
            this.crop.Text = "Crop";
            this.crop.UseVisualStyleBackColor = true;
            this.crop.Click += new System.EventHandler(this.crop_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1098, 744);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 809);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crop);
            this.Controls.Add(this.autoAnchor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mouse_x_position);
            this.Controls.Add(this.mouse_y_position);
            this.Controls.Add(this.anchor_x);
            this.Controls.Add(this.anchor_y);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intelligent Scissors...";
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mouse_x_position;
        private System.Windows.Forms.TextBox mouse_y_position;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox anchor_x;
        private System.Windows.Forms.TextBox anchor_y;
        private System.Windows.Forms.Button autoAnchor;
        private System.Windows.Forms.Button crop;
        private System.Windows.Forms.Button button1;
    }
}

