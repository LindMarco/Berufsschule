namespace Support_Ticket_System
{
    partial class Ticket_Start
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
            bu_administrator = new Button();
            bu_bearbeiten = new Button();
            bu_erstellen = new Button();
            la_ueberschrift = new Label();
            SuspendLayout();
            // 
            // bu_administrator
            // 
            bu_administrator.BackColor = SystemColors.ActiveCaption;
            bu_administrator.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_administrator.Location = new Point(714, 12);
            bu_administrator.Name = "bu_administrator";
            bu_administrator.Size = new Size(158, 69);
            bu_administrator.TabIndex = 7;
            bu_administrator.Text = "Administrator";
            bu_administrator.UseVisualStyleBackColor = false;
            bu_administrator.Click += bu_administrator_Click;
            // 
            // bu_bearbeiten
            // 
            bu_bearbeiten.BackColor = SystemColors.ActiveCaption;
            bu_bearbeiten.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_bearbeiten.Location = new Point(485, 235);
            bu_bearbeiten.Name = "bu_bearbeiten";
            bu_bearbeiten.Size = new Size(158, 69);
            bu_bearbeiten.TabIndex = 6;
            bu_bearbeiten.Text = "Ticket bearbeiten";
            bu_bearbeiten.UseVisualStyleBackColor = false;
            bu_bearbeiten.Click += bu_bearbeiten_Click;
            // 
            // bu_erstellen
            // 
            bu_erstellen.BackColor = SystemColors.ActiveCaption;
            bu_erstellen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_erstellen.Location = new Point(144, 235);
            bu_erstellen.Name = "bu_erstellen";
            bu_erstellen.Size = new Size(158, 69);
            bu_erstellen.TabIndex = 5;
            bu_erstellen.Text = "Ticket erstellen";
            bu_erstellen.UseVisualStyleBackColor = false;
            bu_erstellen.Click += bu_erstellen_Click;
            // 
            // la_ueberschrift
            // 
            la_ueberschrift.AutoSize = true;
            la_ueberschrift.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_ueberschrift.Location = new Point(243, 113);
            la_ueberschrift.Name = "la_ueberschrift";
            la_ueberschrift.Size = new Size(316, 32);
            la_ueberschrift.TabIndex = 4;
            la_ueberschrift.Text = "Was möchstest du machen?";
            // 
            // Ticket_Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(884, 511);
            Controls.Add(bu_administrator);
            Controls.Add(bu_bearbeiten);
            Controls.Add(bu_erstellen);
            Controls.Add(la_ueberschrift);
            Name = "Ticket_Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Startseite ";
            FormClosing += start_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bu_administrator;
        private Button bu_bearbeiten;
        private Button bu_erstellen;
        private Label la_ueberschrift;
    }
}
