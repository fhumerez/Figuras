namespace Figuras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAlturaT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaseT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreT = new System.Windows.Forms.TextBox();
            this.txtAreaTriangulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNombreR = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.txtAreaR = new System.Windows.Forms.TextBox();
            this.txtAlturaR = new System.Windows.Forms.TextBox();
            this.txtBaseR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtAreaP = new System.Windows.Forms.TextBox();
            this.txtAlturaP = new System.Windows.Forms.TextBox();
            this.txtbaseP = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.btnParalelo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblPila = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAlturaT
            // 
            this.txtAlturaT.Location = new System.Drawing.Point(399, 121);
            this.txtAlturaT.Name = "txtAlturaT";
            this.txtAlturaT.Size = new System.Drawing.Size(75, 27);
            this.txtAlturaT.TabIndex = 3;
            this.txtAlturaT.Text = "10";
            this.txtAlturaT.TextChanged += new System.EventHandler(this.txtAlturaT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altura";
            // 
            // txtBaseT
            // 
            this.txtBaseT.Location = new System.Drawing.Point(399, 88);
            this.txtBaseT.Name = "txtBaseT";
            this.txtBaseT.Size = new System.Drawing.Size(77, 27);
            this.txtBaseT.TabIndex = 1;
            this.txtBaseT.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(535, 287);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtNombreT);
            this.tabPage1.Controls.Add(this.txtAreaTriangulo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtBaseT);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtAlturaT);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(527, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Triangulo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nombre";
            // 
            // txtNombreT
            // 
            this.txtNombreT.Location = new System.Drawing.Point(399, 40);
            this.txtNombreT.Name = "txtNombreT";
            this.txtNombreT.Size = new System.Drawing.Size(81, 27);
            this.txtNombreT.TabIndex = 8;
            this.txtNombreT.Text = "Isosceles";
            // 
            // txtAreaTriangulo
            // 
            this.txtAreaTriangulo.Location = new System.Drawing.Point(397, 193);
            this.txtAreaTriangulo.Name = "txtAreaTriangulo";
            this.txtAreaTriangulo.ReadOnly = true;
            this.txtAreaTriangulo.Size = new System.Drawing.Size(77, 27);
            this.txtAreaTriangulo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Area";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crear Triangulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtNombreR);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnRectangulo);
            this.tabPage2.Controls.Add(this.txtAreaR);
            this.tabPage2.Controls.Add(this.txtAlturaR);
            this.tabPage2.Controls.Add(this.txtBaseR);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(527, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rectangulo";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtNombreR
            // 
            this.txtNombreR.Location = new System.Drawing.Point(397, 42);
            this.txtNombreR.Name = "txtNombreR";
            this.txtNombreR.Size = new System.Drawing.Size(105, 27);
            this.txtNombreR.TabIndex = 13;
            this.txtNombreR.Text = "Aureo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nombre";
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(106, 190);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(158, 41);
            this.btnRectangulo.TabIndex = 11;
            this.btnRectangulo.Text = "Crea Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // txtAreaR
            // 
            this.txtAreaR.Location = new System.Drawing.Point(397, 156);
            this.txtAreaR.Name = "txtAreaR";
            this.txtAreaR.ReadOnly = true;
            this.txtAreaR.Size = new System.Drawing.Size(105, 27);
            this.txtAreaR.TabIndex = 10;
            // 
            // txtAlturaR
            // 
            this.txtAlturaR.Location = new System.Drawing.Point(396, 123);
            this.txtAlturaR.Name = "txtAlturaR";
            this.txtAlturaR.Size = new System.Drawing.Size(106, 27);
            this.txtAlturaR.TabIndex = 9;
            this.txtAlturaR.Text = "5";
            // 
            // txtBaseR
            // 
            this.txtBaseR.Location = new System.Drawing.Point(396, 86);
            this.txtBaseR.Name = "txtBaseR";
            this.txtBaseR.Size = new System.Drawing.Size(106, 27);
            this.txtBaseR.TabIndex = 8;
            this.txtBaseR.Text = "150";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Area";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(296, 157);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Altura";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtAreaP);
            this.tabPage3.Controls.Add(this.txtAlturaP);
            this.tabPage3.Controls.Add(this.txtbaseP);
            this.tabPage3.Controls.Add(this.txtNombreP);
            this.tabPage3.Controls.Add(this.btnParalelo);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(527, 254);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Paralelogramo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtAreaP
            // 
            this.txtAreaP.Location = new System.Drawing.Point(400, 153);
            this.txtAreaP.Name = "txtAreaP";
            this.txtAreaP.ReadOnly = true;
            this.txtAreaP.Size = new System.Drawing.Size(87, 27);
            this.txtAreaP.TabIndex = 21;
            // 
            // txtAlturaP
            // 
            this.txtAlturaP.Location = new System.Drawing.Point(400, 120);
            this.txtAlturaP.Name = "txtAlturaP";
            this.txtAlturaP.Size = new System.Drawing.Size(87, 27);
            this.txtAlturaP.TabIndex = 20;
            this.txtAlturaP.Text = "3";
            // 
            // txtbaseP
            // 
            this.txtbaseP.Location = new System.Drawing.Point(400, 80);
            this.txtbaseP.Name = "txtbaseP";
            this.txtbaseP.Size = new System.Drawing.Size(87, 27);
            this.txtbaseP.TabIndex = 19;
            this.txtbaseP.Text = "50";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(400, 34);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(87, 27);
            this.txtNombreP.TabIndex = 18;
            this.txtNombreP.Text = "Regular";
            // 
            // btnParalelo
            // 
            this.btnParalelo.Location = new System.Drawing.Point(93, 185);
            this.btnParalelo.Name = "btnParalelo";
            this.btnParalelo.Size = new System.Drawing.Size(158, 44);
            this.btnParalelo.TabIndex = 17;
            this.btnParalelo.Text = "Crear Paralelogramo";
            this.btnParalelo.UseVisualStyleBackColor = true;
            this.btnParalelo.Click += new System.EventHandler(this.btnParalelo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Area";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Base";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Altura";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 157);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnMostrar);
            this.splitContainer1.Panel2.Controls.Add(this.lblPila);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.lstPila);
            this.splitContainer1.Size = new System.Drawing.Size(539, 615);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(78, 276);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(133, 30);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Pila ";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblPila
            // 
            this.lblPila.AutoSize = true;
            this.lblPila.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPila.Location = new System.Drawing.Point(311, 25);
            this.lblPila.Name = "lblPila";
            this.lblPila.Size = new System.Drawing.Size(129, 22);
            this.lblPila.TabIndex = 2;
            this.lblPila.Text = "Pila Vacia .................";
            this.lblPila.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pila de Figuras";
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.ItemHeight = 20;
            this.lstPila.Location = new System.Drawing.Point(10, 25);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(258, 244);
            this.lstPila.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 615);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "FIGURAS GEOMETRICAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtAlturaT;
        private Label label2;
        private TextBox txtBaseT;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private TabPage tabPage3;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtAreaTriangulo;
        private Label label5;
        private Button btnRectangulo;
        private TextBox txtAreaR;
        private TextBox txtAlturaR;
        private TextBox txtBaseR;
        private Label label6;
        private ListBox lstPila;
        private Label label7;
        private Label lblPila;
        private TextBox txtNombreT;
        private Label label8;
        private TextBox txtNombreR;
        private Label label9;
        private TextBox txtAreaP;
        private TextBox txtAlturaP;
        private TextBox txtbaseP;
        private TextBox txtNombreP;
        private Button btnParalelo;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnMostrar;
    }
}