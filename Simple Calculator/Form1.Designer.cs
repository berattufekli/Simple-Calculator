namespace Simple_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Button0 = new CustomControls.RJControls.RJButton();
            this.AdditionButton = new CustomControls.RJControls.RJButton();
            this.Button3 = new CustomControls.RJControls.RJButton();
            this.Button2 = new CustomControls.RJControls.RJButton();
            this.Button1 = new CustomControls.RJControls.RJButton();
            this.SubtractionButton = new CustomControls.RJControls.RJButton();
            this.Button6 = new CustomControls.RJControls.RJButton();
            this.Button5 = new CustomControls.RJControls.RJButton();
            this.Button4 = new CustomControls.RJControls.RJButton();
            this.MultiplyButton = new CustomControls.RJControls.RJButton();
            this.Button9 = new CustomControls.RJControls.RJButton();
            this.Button8 = new CustomControls.RJControls.RJButton();
            this.DivButton = new CustomControls.RJControls.RJButton();
            this.ModButton = new CustomControls.RJControls.RJButton();
            this.ClearButton = new CustomControls.RJControls.RJButton();
            this.Button7 = new CustomControls.RJControls.RJButton();
            this.ResultText = new System.Windows.Forms.Label();
            this.ResultButton = new CustomControls.RJControls.RJButton();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Button0, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.AdditionButton, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.Button3, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Button2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Button1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.SubtractionButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Button6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Button5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Button4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.MultiplyButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DivButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ModButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ClearButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ResultText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CloseButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ResultButton, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 641);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Button0
            // 
            this.Button0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button0.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Button0.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Button0.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Button0.BorderRadius = 30;
            this.Button0.BorderSize = 0;
            this.tableLayoutPanel1.SetColumnSpan(this.Button0, 2);
            this.Button0.FlatAppearance.BorderSize = 0;
            this.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button0.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button0.ForeColor = System.Drawing.Color.White;
            this.Button0.Location = new System.Drawing.Point(15, 555);
            this.Button0.Margin = new System.Windows.Forms.Padding(10);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(154, 71);
            this.Button0.TabIndex = 20;
            this.Button0.Text = "0";
            this.Button0.TextColor = System.Drawing.Color.White;
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdditionButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.AdditionButton.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.AdditionButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AdditionButton.BorderRadius = 30;
            this.AdditionButton.BorderSize = 0;
            this.AdditionButton.FlatAppearance.BorderSize = 0;
            this.AdditionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdditionButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdditionButton.ForeColor = System.Drawing.Color.White;
            this.AdditionButton.Location = new System.Drawing.Point(276, 467);
            this.AdditionButton.Margin = new System.Windows.Forms.Padding(10);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(68, 68);
            this.AdditionButton.TabIndex = 19;
            this.AdditionButton.Text = "+";
            this.AdditionButton.TextColor = System.Drawing.Color.White;
            this.AdditionButton.UseVisualStyleBackColor = false;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // Button3
            // 
            this.Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Button3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Button3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Button3.BorderRadius = 30;
            this.Button3.BorderSize = 0;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(189, 467);
            this.Button3.Margin = new System.Windows.Forms.Padding(10);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(67, 68);
            this.Button3.TabIndex = 18;
            this.Button3.Text = "3";
            this.Button3.TextColor = System.Drawing.Color.White;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Button2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Button2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Button2.BorderRadius = 30;
            this.Button2.BorderSize = 0;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(102, 467);
            this.Button2.Margin = new System.Windows.Forms.Padding(10);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(67, 68);
            this.Button2.TabIndex = 17;
            this.Button2.Text = "2";
            this.Button2.TextColor = System.Drawing.Color.White;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Button1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Button1.BorderRadius = 30;
            this.Button1.BorderSize = 0;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(15, 467);
            this.Button1.Margin = new System.Windows.Forms.Padding(10);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(67, 68);
            this.Button1.TabIndex = 16;
            this.Button1.Text = "1";
            this.Button1.TextColor = System.Drawing.Color.White;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtractionButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.SubtractionButton.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.SubtractionButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SubtractionButton.BorderRadius = 30;
            this.SubtractionButton.BorderSize = 0;
            this.SubtractionButton.FlatAppearance.BorderSize = 0;
            this.SubtractionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtractionButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SubtractionButton.ForeColor = System.Drawing.Color.White;
            this.SubtractionButton.Location = new System.Drawing.Point(276, 379);
            this.SubtractionButton.Margin = new System.Windows.Forms.Padding(10);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(68, 68);
            this.SubtractionButton.TabIndex = 15;
            this.SubtractionButton.Text = "-";
            this.SubtractionButton.TextColor = System.Drawing.Color.White;
            this.SubtractionButton.UseVisualStyleBackColor = false;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // Button6
            // 
            this.Button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Button6.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Button6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Button6.BorderRadius = 30;
            this.Button6.BorderSize = 0;
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Location = new System.Drawing.Point(189, 379);
            this.Button6.Margin = new System.Windows.Forms.Padding(10);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(67, 68);
            this.Button6.TabIndex = 14;
            this.Button6.Text = "6";
            this.Button6.TextColor = System.Drawing.Color.White;
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Button5.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Button5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Button5.BorderRadius = 30;
            this.Button5.BorderSize = 0;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Location = new System.Drawing.Point(102, 379);
            this.Button5.Margin = new System.Windows.Forms.Padding(10);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(67, 68);
            this.Button5.TabIndex = 13;
            this.Button5.Text = "5";
            this.Button5.TextColor = System.Drawing.Color.White;
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Button4.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Button4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Button4.BorderRadius = 30;
            this.Button4.BorderSize = 0;
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Location = new System.Drawing.Point(15, 379);
            this.Button4.Margin = new System.Windows.Forms.Padding(10);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(67, 68);
            this.Button4.TabIndex = 12;
            this.Button4.Text = "4";
            this.Button4.TextColor = System.Drawing.Color.White;
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MultiplyButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.MultiplyButton.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.MultiplyButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.MultiplyButton.BorderRadius = 30;
            this.MultiplyButton.BorderSize = 0;
            this.MultiplyButton.FlatAppearance.BorderSize = 0;
            this.MultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplyButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MultiplyButton.ForeColor = System.Drawing.Color.White;
            this.MultiplyButton.Location = new System.Drawing.Point(276, 291);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(10);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(68, 68);
            this.MultiplyButton.TabIndex = 11;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.TextColor = System.Drawing.Color.White;
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // Button9
            // 
            this.Button9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button9.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Button9.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Button9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Button9.BorderRadius = 30;
            this.Button9.BorderSize = 0;
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button9.ForeColor = System.Drawing.Color.White;
            this.Button9.Location = new System.Drawing.Point(189, 291);
            this.Button9.Margin = new System.Windows.Forms.Padding(10);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(67, 68);
            this.Button9.TabIndex = 10;
            this.Button9.Text = "9";
            this.Button9.TextColor = System.Drawing.Color.White;
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button8
            // 
            this.Button8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Button8.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Button8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Button8.BorderRadius = 30;
            this.Button8.BorderSize = 0;
            this.Button8.FlatAppearance.BorderSize = 0;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button8.ForeColor = System.Drawing.Color.White;
            this.Button8.Location = new System.Drawing.Point(102, 292);
            this.Button8.Margin = new System.Windows.Forms.Padding(10);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(67, 65);
            this.Button8.TabIndex = 9;
            this.Button8.Text = "8";
            this.Button8.TextColor = System.Drawing.Color.White;
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // DivButton
            // 
            this.DivButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.DivButton.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.DivButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DivButton.BorderRadius = 30;
            this.DivButton.BorderSize = 0;
            this.DivButton.FlatAppearance.BorderSize = 0;
            this.DivButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DivButton.ForeColor = System.Drawing.Color.White;
            this.DivButton.Location = new System.Drawing.Point(276, 203);
            this.DivButton.Margin = new System.Windows.Forms.Padding(10);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(68, 68);
            this.DivButton.TabIndex = 8;
            this.DivButton.Text = "/";
            this.DivButton.TextColor = System.Drawing.Color.White;
            this.DivButton.UseVisualStyleBackColor = false;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // ModButton
            // 
            this.ModButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ModButton.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.ModButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ModButton.BorderRadius = 30;
            this.ModButton.BorderSize = 0;
            this.ModButton.FlatAppearance.BorderSize = 0;
            this.ModButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ModButton.ForeColor = System.Drawing.Color.White;
            this.ModButton.Location = new System.Drawing.Point(189, 203);
            this.ModButton.Margin = new System.Windows.Forms.Padding(10);
            this.ModButton.Name = "ModButton";
            this.ModButton.Size = new System.Drawing.Size(67, 68);
            this.ModButton.TabIndex = 7;
            this.ModButton.Text = "%";
            this.ModButton.TextColor = System.Drawing.Color.White;
            this.ModButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ClearButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ClearButton.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.ClearButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ClearButton.BorderRadius = 30;
            this.ClearButton.BorderSize = 0;
            this.tableLayoutPanel1.SetColumnSpan(this.ClearButton, 2);
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(15, 203);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(10);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(154, 68);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.TextColor = System.Drawing.Color.White;
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Button7
            // 
            this.Button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button7.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Button7.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Button7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Button7.BorderRadius = 30;
            this.Button7.BorderSize = 0;
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button7.ForeColor = System.Drawing.Color.White;
            this.Button7.Location = new System.Drawing.Point(15, 291);
            this.Button7.Margin = new System.Windows.Forms.Padding(10);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(67, 68);
            this.Button7.TabIndex = 0;
            this.Button7.Text = "7";
            this.Button7.TextColor = System.Drawing.Color.White;
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // ResultText
            // 
            this.ResultText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultText.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ResultText, 4);
            this.ResultText.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            this.ResultText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultText.Location = new System.Drawing.Point(8, 36);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(343, 157);
            this.ResultText.TabIndex = 24;
            this.ResultText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ResultButton
            // 
            this.ResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ResultButton.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.ResultButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ResultButton.BorderRadius = 30;
            this.ResultButton.BorderSize = 0;
            this.tableLayoutPanel1.SetColumnSpan(this.ResultButton, 2);
            this.ResultButton.FlatAppearance.BorderSize = 0;
            this.ResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResultButton.ForeColor = System.Drawing.Color.White;
            this.ResultButton.Location = new System.Drawing.Point(189, 555);
            this.ResultButton.Margin = new System.Windows.Forms.Padding(10);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(155, 71);
            this.ResultButton.TabIndex = 23;
            this.ResultButton.Text = "=";
            this.ResultButton.TextColor = System.Drawing.Color.White;
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Image = global::Simple_Calculator.Properties.Resources.close;
            this.CloseButton.Location = new System.Drawing.Point(326, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(5);
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 25;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 25);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Simple_Calculator.Properties.Resources.calculator__1_;
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(38, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculator";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.RJControls.RJButton ResultButton;
        private CustomControls.RJControls.RJButton Button0;
        private CustomControls.RJControls.RJButton AdditionButton;
        private CustomControls.RJControls.RJButton Button3;
        private CustomControls.RJControls.RJButton Button2;
        private CustomControls.RJControls.RJButton Button1;
        private CustomControls.RJControls.RJButton SubtractionButton;
        private CustomControls.RJControls.RJButton Button6;
        private CustomControls.RJControls.RJButton Button5;
        private CustomControls.RJControls.RJButton Button4;
        private CustomControls.RJControls.RJButton MultiplyButton;
        private CustomControls.RJControls.RJButton Button9;
        private CustomControls.RJControls.RJButton Button8;
        private CustomControls.RJControls.RJButton DivButton;
        private CustomControls.RJControls.RJButton ModButton;
        private CustomControls.RJControls.RJButton ClearButton;
        private CustomControls.RJControls.RJButton Button7;
        private System.Windows.Forms.Label ResultText;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

