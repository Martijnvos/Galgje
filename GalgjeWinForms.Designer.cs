namespace Galgje_WinForms
{
    partial class GalgjeWinForms
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
            this.buttonRaadLetter = new System.Windows.Forms.Button();
            this.textBoxRaadLetterInput = new System.Windows.Forms.TextBox();
            this.labelKiesLetter = new System.Windows.Forms.Label();
            this.labelRightLettersValues = new System.Windows.Forms.Label();
            this.labelWrongLetterValues = new System.Windows.Forms.Label();
            this.labelRightLetters = new System.Windows.Forms.Label();
            this.labelWrongLetters = new System.Windows.Forms.Label();
            this.labelNogTeGokken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRaadLetter
            // 
            this.buttonRaadLetter.Location = new System.Drawing.Point(174, 56);
            this.buttonRaadLetter.Name = "buttonRaadLetter";
            this.buttonRaadLetter.Size = new System.Drawing.Size(162, 42);
            this.buttonRaadLetter.TabIndex = 0;
            this.buttonRaadLetter.Text = "Raad Letter";
            this.buttonRaadLetter.UseVisualStyleBackColor = true;
            this.buttonRaadLetter.Click += new System.EventHandler(this.buttonRaadLetter_Click);
            // 
            // textBoxRaadLetterInput
            // 
            this.textBoxRaadLetterInput.Location = new System.Drawing.Point(26, 66);
            this.textBoxRaadLetterInput.Name = "textBoxRaadLetterInput";
            this.textBoxRaadLetterInput.Size = new System.Drawing.Size(100, 22);
            this.textBoxRaadLetterInput.TabIndex = 1;
            // 
            // labelKiesLetter
            // 
            this.labelKiesLetter.AutoSize = true;
            this.labelKiesLetter.Location = new System.Drawing.Point(26, 43);
            this.labelKiesLetter.Name = "labelKiesLetter";
            this.labelKiesLetter.Size = new System.Drawing.Size(71, 17);
            this.labelKiesLetter.TabIndex = 2;
            this.labelKiesLetter.Text = "Kies letter";
            // 
            // labelRightLettersValues
            // 
            this.labelRightLettersValues.AutoSize = true;
            this.labelRightLettersValues.Location = new System.Drawing.Point(26, 167);
            this.labelRightLettersValues.Name = "labelRightLettersValues";
            this.labelRightLettersValues.Size = new System.Drawing.Size(0, 17);
            this.labelRightLettersValues.TabIndex = 3;
            // 
            // labelWrongLetterValues
            // 
            this.labelWrongLetterValues.AutoSize = true;
            this.labelWrongLetterValues.Location = new System.Drawing.Point(174, 167);
            this.labelWrongLetterValues.Name = "labelWrongLetterValues";
            this.labelWrongLetterValues.Size = new System.Drawing.Size(0, 17);
            this.labelWrongLetterValues.TabIndex = 4;
            // 
            // labelRightLetters
            // 
            this.labelRightLetters.AutoSize = true;
            this.labelRightLetters.Location = new System.Drawing.Point(23, 134);
            this.labelRightLetters.Name = "labelRightLetters";
            this.labelRightLetters.Size = new System.Drawing.Size(135, 17);
            this.labelRightLetters.TabIndex = 5;
            this.labelRightLetters.Text = "Goed gerade letters";
            // 
            // labelWrongLetters
            // 
            this.labelWrongLetters.AutoSize = true;
            this.labelWrongLetters.Location = new System.Drawing.Point(174, 134);
            this.labelWrongLetters.Name = "labelWrongLetters";
            this.labelWrongLetters.Size = new System.Drawing.Size(158, 17);
            this.labelWrongLetters.TabIndex = 6;
            this.labelWrongLetters.Text = "Verkeerd gerade letters";
            // 
            // labelNogTeGokken
            // 
            this.labelNogTeGokken.AutoSize = true;
            this.labelNogTeGokken.Location = new System.Drawing.Point(396, 56);
            this.labelNogTeGokken.Name = "labelNogTeGokken";
            this.labelNogTeGokken.Size = new System.Drawing.Size(0, 17);
            this.labelNogTeGokken.TabIndex = 7;
            // 
            // GalgjeWinForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 209);
            this.Controls.Add(this.labelNogTeGokken);
            this.Controls.Add(this.labelWrongLetters);
            this.Controls.Add(this.labelRightLetters);
            this.Controls.Add(this.labelWrongLetterValues);
            this.Controls.Add(this.labelRightLettersValues);
            this.Controls.Add(this.labelKiesLetter);
            this.Controls.Add(this.textBoxRaadLetterInput);
            this.Controls.Add(this.buttonRaadLetter);
            this.Name = "GalgjeWinForms";
            this.Text = "Galgje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRaadLetter;
        private System.Windows.Forms.TextBox textBoxRaadLetterInput;
        private System.Windows.Forms.Label labelKiesLetter;
        private System.Windows.Forms.Label labelRightLettersValues;
        private System.Windows.Forms.Label labelWrongLetterValues;
        private System.Windows.Forms.Label labelRightLetters;
        private System.Windows.Forms.Label labelWrongLetters;
        private System.Windows.Forms.Label labelNogTeGokken;
    }
}

