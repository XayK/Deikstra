namespace saodkur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearIt = new System.Windows.Forms.Button();
            this.NewIt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WeiButton = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПредметыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьПредметыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьДеревоРешенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьРешениеДинамикойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearCheck = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.показатьРешениеПереборомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(6000, 1993);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 368);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Предметы";
            // 
            // ClearIt
            // 
            this.ClearIt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearIt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearIt.Image = ((System.Drawing.Image)(resources.GetObject("ClearIt.Image")));
            this.ClearIt.Location = new System.Drawing.Point(290, 332);
            this.ClearIt.Name = "ClearIt";
            this.ClearIt.Size = new System.Drawing.Size(84, 92);
            this.ClearIt.TabIndex = 5;
            this.ClearIt.UseVisualStyleBackColor = false;
            this.ClearIt.Click += new System.EventHandler(this.ClearIt_Click);
            // 
            // NewIt
            // 
            this.NewIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewIt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewIt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewIt.Image = ((System.Drawing.Image)(resources.GetObject("NewIt.Image")));
            this.NewIt.Location = new System.Drawing.Point(290, 221);
            this.NewIt.Name = "NewIt";
            this.NewIt.Size = new System.Drawing.Size(84, 86);
            this.NewIt.TabIndex = 6;
            this.NewIt.UseVisualStyleBackColor = false;
            this.NewIt.Click += new System.EventHandler(this.NewIt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(507, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(507, 378);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(445, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(438, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цена";
            // 
            // WeiButton
            // 
            this.WeiButton.Location = new System.Drawing.Point(508, 249);
            this.WeiButton.Name = "WeiButton";
            this.WeiButton.Size = new System.Drawing.Size(114, 20);
            this.WeiButton.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Макс. вес";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьПредметыToolStripMenuItem,
            this.загрузитьПредметыToolStripMenuItem,
            this.показатьДеревоРешенийToolStripMenuItem,
            this.показатьРешениеДинамикойToolStripMenuItem,
            this.показатьРешениеПереборомToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // сохранитьПредметыToolStripMenuItem
            // 
            this.сохранитьПредметыToolStripMenuItem.Name = "сохранитьПредметыToolStripMenuItem";
            this.сохранитьПредметыToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.сохранитьПредметыToolStripMenuItem.Text = "Сохранить предметы";
            this.сохранитьПредметыToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПредметыToolStripMenuItem_Click);
            // 
            // загрузитьПредметыToolStripMenuItem
            // 
            this.загрузитьПредметыToolStripMenuItem.Name = "загрузитьПредметыToolStripMenuItem";
            this.загрузитьПредметыToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.загрузитьПредметыToolStripMenuItem.Text = "Загрузить Предметы";
            this.загрузитьПредметыToolStripMenuItem.Click += new System.EventHandler(this.загрузитьПредметыToolStripMenuItem_Click);
            // 
            // показатьДеревоРешенийToolStripMenuItem
            // 
            this.показатьДеревоРешенийToolStripMenuItem.Name = "показатьДеревоРешенийToolStripMenuItem";
            this.показатьДеревоРешенийToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.показатьДеревоРешенийToolStripMenuItem.Text = "Показать решение МВиГ";
            this.показатьДеревоРешенийToolStripMenuItem.Click += new System.EventHandler(this.показатьДеревоРешенийToolStripMenuItem_Click);
            // 
            // показатьРешениеДинамикойToolStripMenuItem
            // 
            this.показатьРешениеДинамикойToolStripMenuItem.Name = "показатьРешениеДинамикойToolStripMenuItem";
            this.показатьРешениеДинамикойToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.показатьРешениеДинамикойToolStripMenuItem.Text = "Показать решение динамикой";
            this.показатьРешениеДинамикойToolStripMenuItem.Click += new System.EventHandler(this.показатьРешениеДинамикойToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.описаниеЗадачиToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // описаниеЗадачиToolStripMenuItem
            // 
            this.описаниеЗадачиToolStripMenuItem.Name = "описаниеЗадачиToolStripMenuItem";
            this.описаниеЗадачиToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.описаниеЗадачиToolStripMenuItem.Text = "Описание задачи";
            this.описаниеЗадачиToolStripMenuItem.Click += new System.EventHandler(this.описаниеЗадачиToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 455);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(693, 60);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(235, 316);
            this.listBox2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(751, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ваш набор предметов";
            // 
            // ClearCheck
            // 
            this.ClearCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearCheck.Image = ((System.Drawing.Image)(resources.GetObject("ClearCheck.Image")));
            this.ClearCheck.Location = new System.Drawing.Point(842, 382);
            this.ClearCheck.Name = "ClearCheck";
            this.ClearCheck.Size = new System.Drawing.Size(69, 56);
            this.ClearCheck.TabIndex = 18;
            this.ClearCheck.UseVisualStyleBackColor = false;
            this.ClearCheck.Click += new System.EventHandler(this.ClearCheck_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckButton.Image = ((System.Drawing.Image)(resources.GetObject("CheckButton.Image")));
            this.CheckButton.Location = new System.Drawing.Point(731, 382);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(68, 56);
            this.CheckButton.TabIndex = 19;
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Font = new System.Drawing.Font("Mistral", 48F);
            this.button2.Location = new System.Drawing.Point(384, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 74);
            this.button2.TabIndex = 17;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 477);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.CheckButton);
            this.tabPage2.Controls.Add(this.ClearCheck);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.WeiButton);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ClearIt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.NewIt);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Гл. окно";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 451);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Дерево решения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.listBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(959, 451);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Динамический метод";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(36, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "Предметы";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(524, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Вес";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(23, 413);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(921, 30);
            this.textBox3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(773, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Набор предметов";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(191, 66);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(705, 284);
            this.listBox3.TabIndex = 0;
            // 
            // показатьРешениеПереборомToolStripMenuItem
            // 
            this.показатьРешениеПереборомToolStripMenuItem.Name = "показатьРешениеПереборомToolStripMenuItem";
            this.показатьРешениеПереборомToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.показатьРешениеПереборомToolStripMenuItem.Text = "Показать решение перебором";
            this.показатьРешениеПереборомToolStripMenuItem.Click += new System.EventHandler(this.показатьРешениеПереборомToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 525);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Задаче о рюкзаке";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearIt;
        private System.Windows.Forms.Button NewIt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WeiButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПредметыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьПредметыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem описаниеЗадачиToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearCheck;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem показатьДеревоРешенийToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem показатьРешениеДинамикойToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem показатьРешениеПереборомToolStripMenuItem;
    }
}

