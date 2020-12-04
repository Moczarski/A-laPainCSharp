namespace Zadanie3_Mateusz_Moczarski
{
    partial class MoczarskiPaint
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxWidth = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.comboBoxFigury = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzJakoTłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxFill = new System.Windows.Forms.CheckBox();
            this.drawSpace = new System.Windows.Forms.GroupBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.drawSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 405);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PointerDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PointerMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PointerUp);
            // 
            // comboBoxWidth
            // 
            this.comboBoxWidth.FormattingEnabled = true;
            this.comboBoxWidth.Items.AddRange(new object[] {
            "cienki",
            "normalny",
            "gruby"});
            this.comboBoxWidth.Location = new System.Drawing.Point(12, 131);
            this.comboBoxWidth.Name = "comboBoxWidth";
            this.comboBoxWidth.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWidth.TabIndex = 3;
            this.comboBoxWidth.Text = "Grubość";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(40, 279);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Czyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Red;
            this.buttonColor.Location = new System.Drawing.Point(13, 281);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(21, 21);
            this.buttonColor.TabIndex = 5;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.Color);
            // 
            // comboBoxFigury
            // 
            this.comboBoxFigury.FormattingEnabled = true;
            this.comboBoxFigury.Items.AddRange(new object[] {
            "rysowanie",
            "punkt",
            "koło",
            "kwadrat",
            "elipsa",
            "łuk",
            "wycinek koła",
            "wielokąt",
            "krzywa beziera",
            "gumka"});
            this.comboBoxFigury.Location = new System.Drawing.Point(12, 70);
            this.comboBoxFigury.Name = "comboBoxFigury";
            this.comboBoxFigury.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFigury.TabIndex = 6;
            this.comboBoxFigury.Text = "Figury";
            this.comboBoxFigury.SelectedIndexChanged += new System.EventHandler(this.FigureIsChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(787, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzJakoTłoToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // otwórzJakoTłoToolStripMenuItem
            // 
            this.otwórzJakoTłoToolStripMenuItem.Name = "otwórzJakoTłoToolStripMenuItem";
            this.otwórzJakoTłoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.otwórzJakoTłoToolStripMenuItem.Text = "Dodaj tło";
            this.otwórzJakoTłoToolStripMenuItem.Click += new System.EventHandler(this.OtwórzJakoTłoToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.ZapiszJakoToolStripMenuItem_Click);
            // 
            // checkBoxFill
            // 
            this.checkBoxFill.AutoSize = true;
            this.checkBoxFill.Checked = true;
            this.checkBoxFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFill.Location = new System.Drawing.Point(13, 334);
            this.checkBoxFill.Name = "checkBoxFill";
            this.checkBoxFill.Size = new System.Drawing.Size(107, 21);
            this.checkBoxFill.TabIndex = 10;
            this.checkBoxFill.Text = "Wypełnienie";
            this.checkBoxFill.UseVisualStyleBackColor = true;
            // 
            // drawSpace
            // 
            this.drawSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawSpace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drawSpace.Controls.Add(this.pictureBox1);
            this.drawSpace.Location = new System.Drawing.Point(141, 32);
            this.drawSpace.Name = "drawSpace";
            this.drawSpace.Size = new System.Drawing.Size(634, 426);
            this.drawSpace.TabIndex = 11;
            this.drawSpace.TabStop = false;
            this.drawSpace.Text = "Płótno";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(12, 196);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(121, 22);
            this.textBoxSize.TabIndex = 12;
            this.textBoxSize.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Grubość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Narzędzia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rozmiar";
            // 
            // MoczarskiPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.drawSpace);
            this.Controls.Add(this.checkBoxFill);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBoxFigury);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxWidth);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MoczarskiPaint";
            this.Text = "Moczarski Paint";
            this.SizeChanged += new System.EventHandler(this.SizeIsChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.drawSpace.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxWidth;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ComboBox comboBoxFigury;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzJakoTłoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxFill;
        private System.Windows.Forms.GroupBox drawSpace;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label3;
    }
}

