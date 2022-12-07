namespace TPCollectionList
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxInserer = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Q1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCreerList_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Q2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCreerListString_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Q3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonFusionnerQ1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Q4 moyenne";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonMoyenne_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(44, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "Q5 moyenne foreach";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonMoyenneForeach_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(46, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 29);
            this.button6.TabIndex = 5;
            this.button6.Text = "Q6 moyenne Linq";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonMoyenneLinq_Click);
            // 
            // textBoxInserer
            // 
            this.textBoxInserer.Location = new System.Drawing.Point(356, 58);
            this.textBoxInserer.Name = "textBoxInserer";
            this.textBoxInserer.Size = new System.Drawing.Size(125, 27);
            this.textBoxInserer.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(496, 56);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 29);
            this.button7.TabIndex = 7;
            this.button7.Text = "Inserer au début";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonInsererDebut_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(356, 129);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(201, 29);
            this.button8.TabIndex = 8;
            this.button8.Text = "Supprimer indice 3";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonSupprimerIndice3_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(360, 193);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(197, 29);
            this.button9.TabIndex = 9;
            this.button9.Text = "Verifier si 3 et 7 présents";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBoxInserer);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBoxInserer;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}