namespace Esercizio_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inserisciprod = new System.Windows.Forms.Label();
            this.Prodotto = new System.Windows.Forms.TextBox();
            this.Lista = new System.Windows.Forms.Label();
            this.Listaprod = new System.Windows.Forms.ListBox();
            this.Inserisciprodotto = new System.Windows.Forms.Button();
            this.Prezzo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Inserisciprod
            // 
            this.Inserisciprod.AutoSize = true;
            this.Inserisciprod.Location = new System.Drawing.Point(54, 58);
            this.Inserisciprod.Name = "Inserisciprod";
            this.Inserisciprod.Size = new System.Drawing.Size(90, 13);
            this.Inserisciprod.TabIndex = 0;
            this.Inserisciprod.Text = "Inserisci prodotto:";
            this.Inserisciprod.Click += new System.EventHandler(this.label1_Click);
            // 
            // Prodotto
            // 
            this.Prodotto.Location = new System.Drawing.Point(57, 74);
            this.Prodotto.Name = "Prodotto";
            this.Prodotto.Size = new System.Drawing.Size(207, 20);
            this.Prodotto.TabIndex = 1;
            // 
            // Lista
            // 
            this.Lista.AutoSize = true;
            this.Lista.Location = new System.Drawing.Point(482, 58);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(70, 13);
            this.Lista.TabIndex = 2;
            this.Lista.Text = "Lista prodotti:";
            this.Lista.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Listaprod
            // 
            this.Listaprod.FormattingEnabled = true;
            this.Listaprod.Location = new System.Drawing.Point(485, 74);
            this.Listaprod.Name = "Listaprod";
            this.Listaprod.Size = new System.Drawing.Size(254, 303);
            this.Listaprod.TabIndex = 3;
            // 
            // Inserisciprodotto
            // 
            this.Inserisciprodotto.Location = new System.Drawing.Point(57, 154);
            this.Inserisciprodotto.Name = "Inserisciprodotto";
            this.Inserisciprodotto.Size = new System.Drawing.Size(126, 57);
            this.Inserisciprodotto.TabIndex = 4;
            this.Inserisciprodotto.Text = "Aggiungi prodotto";
            this.Inserisciprodotto.UseVisualStyleBackColor = true;
            this.Inserisciprodotto.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prezzo
            // 
            this.Prezzo.Location = new System.Drawing.Point(57, 113);
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.Size = new System.Drawing.Size(207, 20);
            this.Prezzo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inserisci prezzo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prezzo);
            this.Controls.Add(this.Inserisciprodotto);
            this.Controls.Add(this.Listaprod);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.Prodotto);
            this.Controls.Add(this.Inserisciprod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inserisciprod;
        private System.Windows.Forms.TextBox Prodotto;
        private System.Windows.Forms.Label Lista;
        private System.Windows.Forms.ListBox Listaprod;
        private System.Windows.Forms.Button Inserisciprodotto;
        private System.Windows.Forms.TextBox Prezzo;
        private System.Windows.Forms.Label label1;
    }
}

