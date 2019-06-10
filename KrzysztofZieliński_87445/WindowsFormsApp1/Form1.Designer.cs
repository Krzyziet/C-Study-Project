using System;

namespace WindowsFormsApp1
{
    partial class Form1
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
            this.IsPerfectProject = new System.Windows.Forms.TabControl();
            this.NWD = new System.Windows.Forms.TabPage();
            this.numericSecond = new System.Windows.Forms.NumericUpDown();
            this.numericFirst = new System.Windows.Forms.NumericUpDown();
            this.buttonNWD = new System.Windows.Forms.Button();
            this.fibbonacciIteracja = new System.Windows.Forms.TabPage();
            this.fibResult = new System.Windows.Forms.Button();
            this.nFib = new System.Windows.Forms.NumericUpDown();
            this.FibonacciRekurencja = new System.Windows.Forms.TabPage();
            this.nFibReku = new System.Windows.Forms.NumericUpDown();
            this.FibRekButton = new System.Windows.Forms.Button();
            this.IsPerfect = new System.Windows.Forms.TabPage();
            this.PerfectButton = new System.Windows.Forms.Button();
            this.KolorowanieMapy = new System.Windows.Forms.TabPage();
            this.WczytajButton = new System.Windows.Forms.Button();
            this.Pesel = new System.Windows.Forms.TabPage();
            this.peseslButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sort = new System.Windows.Forms.TabPage();
            this.sort_button = new System.Windows.Forms.Button();
            this.sortbox = new System.Windows.Forms.RichTextBox();
            this.euler1 = new System.Windows.Forms.TabPage();
            this.Euler1Button = new System.Windows.Forms.Button();
            this.euler4 = new System.Windows.Forms.TabPage();
            this.euler4Button = new System.Windows.Forms.Button();
            this.euler5 = new System.Windows.Forms.TabPage();
            this.euler5Button = new System.Windows.Forms.Button();
            this.euler14 = new System.Windows.Forms.TabPage();
            this.euler14Button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.wczytajZmiana = new System.Windows.Forms.Button();
            this.IsPerfectProject.SuspendLayout();
            this.NWD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirst)).BeginInit();
            this.fibbonacciIteracja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFib)).BeginInit();
            this.FibonacciRekurencja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFibReku)).BeginInit();
            this.IsPerfect.SuspendLayout();
            this.KolorowanieMapy.SuspendLayout();
            this.Pesel.SuspendLayout();
            this.sort.SuspendLayout();
            this.euler1.SuspendLayout();
            this.euler4.SuspendLayout();
            this.euler5.SuspendLayout();
            this.euler14.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IsPerfectProject
            // 
            this.IsPerfectProject.Controls.Add(this.NWD);
            this.IsPerfectProject.Controls.Add(this.fibbonacciIteracja);
            this.IsPerfectProject.Controls.Add(this.FibonacciRekurencja);
            this.IsPerfectProject.Controls.Add(this.IsPerfect);
            this.IsPerfectProject.Controls.Add(this.KolorowanieMapy);
            this.IsPerfectProject.Controls.Add(this.Pesel);
            this.IsPerfectProject.Controls.Add(this.sort);
            this.IsPerfectProject.Controls.Add(this.euler1);
            this.IsPerfectProject.Controls.Add(this.euler4);
            this.IsPerfectProject.Controls.Add(this.euler5);
            this.IsPerfectProject.Controls.Add(this.euler14);
            this.IsPerfectProject.Controls.Add(this.tabPage1);
            this.IsPerfectProject.Location = new System.Drawing.Point(0, 2);
            this.IsPerfectProject.Multiline = true;
            this.IsPerfectProject.Name = "IsPerfectProject";
            this.IsPerfectProject.SelectedIndex = 0;
            this.IsPerfectProject.Size = new System.Drawing.Size(680, 370);
            this.IsPerfectProject.TabIndex = 0;
            // 
            // NWD
            // 
            this.NWD.Controls.Add(this.numericSecond);
            this.NWD.Controls.Add(this.numericFirst);
            this.NWD.Controls.Add(this.buttonNWD);
            this.NWD.Location = new System.Drawing.Point(4, 46);
            this.NWD.Name = "NWD";
            this.NWD.Padding = new System.Windows.Forms.Padding(3);
            this.NWD.Size = new System.Drawing.Size(672, 320);
            this.NWD.TabIndex = 0;
            this.NWD.Text = "NWD";
            this.NWD.UseVisualStyleBackColor = true;
            // 
            // numericSecond
            // 
            this.numericSecond.Location = new System.Drawing.Point(324, 52);
            this.numericSecond.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericSecond.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericSecond.Name = "numericSecond";
            this.numericSecond.Size = new System.Drawing.Size(120, 22);
            this.numericSecond.TabIndex = 2;
            this.numericSecond.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericFirst
            // 
            this.numericFirst.Location = new System.Drawing.Point(129, 52);
            this.numericFirst.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericFirst.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericFirst.Name = "numericFirst";
            this.numericFirst.Size = new System.Drawing.Size(120, 22);
            this.numericFirst.TabIndex = 1;
            this.numericFirst.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericFirst.ValueChanged += new System.EventHandler(this.numericFirst_ValueChanged);
            // 
            // buttonNWD
            // 
            this.buttonNWD.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonNWD.Location = new System.Drawing.Point(247, 160);
            this.buttonNWD.Name = "buttonNWD";
            this.buttonNWD.Size = new System.Drawing.Size(75, 23);
            this.buttonNWD.TabIndex = 0;
            this.buttonNWD.Text = "Wylicz NWD";
            this.buttonNWD.UseVisualStyleBackColor = true;
            this.buttonNWD.Click += new System.EventHandler(this.buttonNWD_Click);
            // 
            // fibbonacciIteracja
            // 
            this.fibbonacciIteracja.Controls.Add(this.fibResult);
            this.fibbonacciIteracja.Controls.Add(this.nFib);
            this.fibbonacciIteracja.Location = new System.Drawing.Point(4, 25);
            this.fibbonacciIteracja.Name = "fibbonacciIteracja";
            this.fibbonacciIteracja.Padding = new System.Windows.Forms.Padding(3);
            this.fibbonacciIteracja.Size = new System.Drawing.Size(672, 341);
            this.fibbonacciIteracja.TabIndex = 1;
            this.fibbonacciIteracja.Text = "Fibonacci Iteracja";
            this.fibbonacciIteracja.UseVisualStyleBackColor = true;
            // 
            // fibResult
            // 
            this.fibResult.Location = new System.Drawing.Point(264, 182);
            this.fibResult.Name = "fibResult";
            this.fibResult.Size = new System.Drawing.Size(75, 23);
            this.fibResult.TabIndex = 1;
            this.fibResult.Text = "Wylicz";
            this.fibResult.UseVisualStyleBackColor = true;
            this.fibResult.Click += new System.EventHandler(this.fibResult_Click_1);
            // 
            // nFib
            // 
            this.nFib.Location = new System.Drawing.Point(204, 48);
            this.nFib.Name = "nFib";
            this.nFib.Size = new System.Drawing.Size(120, 22);
            this.nFib.TabIndex = 0;
            // 
            // FibonacciRekurencja
            // 
            this.FibonacciRekurencja.Controls.Add(this.nFibReku);
            this.FibonacciRekurencja.Controls.Add(this.FibRekButton);
            this.FibonacciRekurencja.Location = new System.Drawing.Point(4, 25);
            this.FibonacciRekurencja.Name = "FibonacciRekurencja";
            this.FibonacciRekurencja.Size = new System.Drawing.Size(672, 341);
            this.FibonacciRekurencja.TabIndex = 2;
            this.FibonacciRekurencja.Text = "Fibonacci Rekurencja";
            this.FibonacciRekurencja.UseVisualStyleBackColor = true;
            // 
            // nFibReku
            // 
            this.nFibReku.Location = new System.Drawing.Point(278, 82);
            this.nFibReku.Name = "nFibReku";
            this.nFibReku.Size = new System.Drawing.Size(120, 22);
            this.nFibReku.TabIndex = 1;
            // 
            // FibRekButton
            // 
            this.FibRekButton.Location = new System.Drawing.Point(301, 228);
            this.FibRekButton.Name = "FibRekButton";
            this.FibRekButton.Size = new System.Drawing.Size(75, 23);
            this.FibRekButton.TabIndex = 0;
            this.FibRekButton.Text = "Wynik";
            this.FibRekButton.UseVisualStyleBackColor = true;
            this.FibRekButton.Click += new System.EventHandler(this.FibRekButton_Click);
            // 
            // IsPerfect
            // 
            this.IsPerfect.Controls.Add(this.PerfectButton);
            this.IsPerfect.Location = new System.Drawing.Point(4, 25);
            this.IsPerfect.Name = "IsPerfect";
            this.IsPerfect.Padding = new System.Windows.Forms.Padding(3);
            this.IsPerfect.Size = new System.Drawing.Size(672, 341);
            this.IsPerfect.TabIndex = 3;
            this.IsPerfect.Text = "IsPerfect";
            this.IsPerfect.UseVisualStyleBackColor = true;
            // 
            // PerfectButton
            // 
            this.PerfectButton.Location = new System.Drawing.Point(213, 184);
            this.PerfectButton.Name = "PerfectButton";
            this.PerfectButton.Size = new System.Drawing.Size(217, 87);
            this.PerfectButton.TabIndex = 0;
            this.PerfectButton.Text = "IsPerfect";
            this.PerfectButton.UseVisualStyleBackColor = true;
            this.PerfectButton.Click += new System.EventHandler(this.PerfectButton_Click);
            // 
            // KolorowanieMapy
            // 
            this.KolorowanieMapy.Controls.Add(this.WczytajButton);
            this.KolorowanieMapy.Location = new System.Drawing.Point(4, 25);
            this.KolorowanieMapy.Name = "KolorowanieMapy";
            this.KolorowanieMapy.Padding = new System.Windows.Forms.Padding(3);
            this.KolorowanieMapy.Size = new System.Drawing.Size(672, 341);
            this.KolorowanieMapy.TabIndex = 4;
            this.KolorowanieMapy.Text = "KolorowanieMapy";
            this.KolorowanieMapy.UseVisualStyleBackColor = true;
            // 
            // WczytajButton
            // 
            this.WczytajButton.Location = new System.Drawing.Point(254, 234);
            this.WczytajButton.Name = "WczytajButton";
            this.WczytajButton.Size = new System.Drawing.Size(75, 23);
            this.WczytajButton.TabIndex = 0;
            this.WczytajButton.Text = "Wczytaj";
            this.WczytajButton.UseVisualStyleBackColor = true;
            this.WczytajButton.Click += new System.EventHandler(this.WczytajButton_Click);
            // 
            // Pesel
            // 
            this.Pesel.Controls.Add(this.peseslButton);
            this.Pesel.Controls.Add(this.richTextBox1);
            this.Pesel.Location = new System.Drawing.Point(4, 25);
            this.Pesel.Name = "Pesel";
            this.Pesel.Padding = new System.Windows.Forms.Padding(3);
            this.Pesel.Size = new System.Drawing.Size(672, 341);
            this.Pesel.TabIndex = 5;
            this.Pesel.Text = "PESEL";
            this.Pesel.UseVisualStyleBackColor = true;
            // 
            // peseslButton
            // 
            this.peseslButton.Location = new System.Drawing.Point(260, 211);
            this.peseslButton.Name = "peseslButton";
            this.peseslButton.Size = new System.Drawing.Size(75, 23);
            this.peseslButton.TabIndex = 1;
            this.peseslButton.Text = "Sprawdź";
            this.peseslButton.UseVisualStyleBackColor = true;
            this.peseslButton.Click += new System.EventHandler(this.peseslButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(211, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(207, 38);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // sort
            // 
            this.sort.Controls.Add(this.sort_button);
            this.sort.Controls.Add(this.sortbox);
            this.sort.Location = new System.Drawing.Point(4, 25);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(672, 341);
            this.sort.TabIndex = 6;
            this.sort.Text = "sort";
            this.sort.UseVisualStyleBackColor = true;
            // 
            // sort_button
            // 
            this.sort_button.Location = new System.Drawing.Point(279, 289);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(75, 23);
            this.sort_button.TabIndex = 1;
            this.sort_button.Text = "sortuj";
            this.sort_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sort_button.UseMnemonic = false;
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
            // 
            // sortbox
            // 
            this.sortbox.Location = new System.Drawing.Point(164, 61);
            this.sortbox.Name = "sortbox";
            this.sortbox.Size = new System.Drawing.Size(309, 195);
            this.sortbox.TabIndex = 0;
            this.sortbox.Text = "Wprowadź 5 liczb oddzielając je kolejnymi enterami ";
            // 
            // euler1
            // 
            this.euler1.Controls.Add(this.Euler1Button);
            this.euler1.Location = new System.Drawing.Point(4, 25);
            this.euler1.Name = "euler1";
            this.euler1.Size = new System.Drawing.Size(672, 341);
            this.euler1.TabIndex = 7;
            this.euler1.Text = "euler1";
            this.euler1.UseVisualStyleBackColor = true;
            // 
            // Euler1Button
            // 
            this.Euler1Button.Location = new System.Drawing.Point(273, 169);
            this.Euler1Button.Name = "Euler1Button";
            this.Euler1Button.Size = new System.Drawing.Size(75, 23);
            this.Euler1Button.TabIndex = 0;
            this.Euler1Button.Text = "pokaż";
            this.Euler1Button.UseVisualStyleBackColor = true;
            this.Euler1Button.Click += new System.EventHandler(this.Euler1Button_Click);
            // 
            // euler4
            // 
            this.euler4.Controls.Add(this.euler4Button);
            this.euler4.Location = new System.Drawing.Point(4, 46);
            this.euler4.Name = "euler4";
            this.euler4.Size = new System.Drawing.Size(672, 320);
            this.euler4.TabIndex = 8;
            this.euler4.Text = "euler4";
            this.euler4.UseVisualStyleBackColor = true;
            // 
            // euler4Button
            // 
            this.euler4Button.Location = new System.Drawing.Point(298, 162);
            this.euler4Button.Name = "euler4Button";
            this.euler4Button.Size = new System.Drawing.Size(75, 23);
            this.euler4Button.TabIndex = 0;
            this.euler4Button.Text = "pokaz";
            this.euler4Button.UseVisualStyleBackColor = true;
            this.euler4Button.Click += new System.EventHandler(this.euler4Button_Click);
            // 
            // euler5
            // 
            this.euler5.Controls.Add(this.euler5Button);
            this.euler5.Location = new System.Drawing.Point(4, 46);
            this.euler5.Name = "euler5";
            this.euler5.Size = new System.Drawing.Size(672, 320);
            this.euler5.TabIndex = 9;
            this.euler5.Text = "Euler5";
            this.euler5.UseVisualStyleBackColor = true;
            // 
            // euler5Button
            // 
            this.euler5Button.Location = new System.Drawing.Point(303, 185);
            this.euler5Button.Name = "euler5Button";
            this.euler5Button.Size = new System.Drawing.Size(75, 23);
            this.euler5Button.TabIndex = 0;
            this.euler5Button.Text = "Show!!";
            this.euler5Button.UseVisualStyleBackColor = true;
            this.euler5Button.Click += new System.EventHandler(this.euler5Button_Click);
            // 
            // euler14
            // 
            this.euler14.Controls.Add(this.euler14Button);
            this.euler14.Location = new System.Drawing.Point(4, 46);
            this.euler14.Name = "euler14";
            this.euler14.Size = new System.Drawing.Size(672, 320);
            this.euler14.TabIndex = 10;
            this.euler14.Text = "Euler14";
            this.euler14.UseVisualStyleBackColor = true;
            // 
            // euler14Button
            // 
            this.euler14Button.Location = new System.Drawing.Point(201, 142);
            this.euler14Button.Name = "euler14Button";
            this.euler14Button.Size = new System.Drawing.Size(254, 93);
            this.euler14Button.TabIndex = 0;
            this.euler14Button.Text = "SHOW RETURNED VALUE";
            this.euler14Button.UseVisualStyleBackColor = true;
            this.euler14Button.Click += new System.EventHandler(this.euler14Button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Pliki Png | *.png";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.wczytajZmiana);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(672, 320);
            this.tabPage1.TabIndex = 11;
            this.tabPage1.Text = "Zmiana kolorow";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // wczytajZmiana
            // 
            this.wczytajZmiana.Location = new System.Drawing.Point(114, 235);
            this.wczytajZmiana.Name = "wczytajZmiana";
            this.wczytajZmiana.Size = new System.Drawing.Size(75, 23);
            this.wczytajZmiana.TabIndex = 0;
            this.wczytajZmiana.Text = "Wczytaj";
            this.wczytajZmiana.UseVisualStyleBackColor = true;
            this.wczytajZmiana.Click += new System.EventHandler(this.wczytajZmiana_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IsPerfectProject);
            this.Name = "Form1";
            this.Text = "Form1";
            this.IsPerfectProject.ResumeLayout(false);
            this.NWD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirst)).EndInit();
            this.fibbonacciIteracja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nFib)).EndInit();
            this.FibonacciRekurencja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nFibReku)).EndInit();
            this.IsPerfect.ResumeLayout(false);
            this.KolorowanieMapy.ResumeLayout(false);
            this.Pesel.ResumeLayout(false);
            this.sort.ResumeLayout(false);
            this.euler1.ResumeLayout(false);
            this.euler4.ResumeLayout(false);
            this.euler5.ResumeLayout(false);
            this.euler14.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void numericFirst_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl IsPerfectProject;
        private System.Windows.Forms.TabPage NWD;
        private System.Windows.Forms.Button buttonNWD;
        private System.Windows.Forms.TabPage fibbonacciIteracja;
        private System.Windows.Forms.NumericUpDown numericSecond;
        private System.Windows.Forms.NumericUpDown numericFirst;
        private System.Windows.Forms.NumericUpDown nFib;
        private System.Windows.Forms.Button fibResult;
        private System.Windows.Forms.TabPage FibonacciRekurencja;
        private System.Windows.Forms.NumericUpDown nFibReku;
        private System.Windows.Forms.Button FibRekButton;
        private System.Windows.Forms.TabPage IsPerfect;
        private System.Windows.Forms.Button PerfectButton;
        private System.Windows.Forms.TabPage KolorowanieMapy;
        private System.Windows.Forms.Button WczytajButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage Pesel;
        private System.Windows.Forms.TabPage sort;
        private System.Windows.Forms.RichTextBox sortbox;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.Button peseslButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage euler1;
        private System.Windows.Forms.Button Euler1Button;
        private System.Windows.Forms.TabPage euler4;
        private System.Windows.Forms.Button euler4Button;
        private System.Windows.Forms.TabPage euler5;
        private System.Windows.Forms.Button euler5Button;
        private System.Windows.Forms.TabPage euler14;
        private System.Windows.Forms.Button euler14Button;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button wczytajZmiana;
    }
}

