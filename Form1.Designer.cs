namespace finals
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
            this.btn_GetPlanet = new System.Windows.Forms.Button();
            this.btn_GetPerson = new System.Windows.Forms.Button();
            this.btn_GetSpecies = new System.Windows.Forms.Button();
            this.btn_GetStarship = new System.Windows.Forms.Button();
            this.txt_GetID = new System.Windows.Forms.TextBox();
            this.rtx_GetAllSpecies = new System.Windows.Forms.RichTextBox();
            this.lbl_ID1 = new System.Windows.Forms.Label();
            this.btn_Ratio = new System.Windows.Forms.Button();
            this.txt_Ratio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_GetPlanet
            // 
            this.btn_GetPlanet.Location = new System.Drawing.Point(12, 10);
            this.btn_GetPlanet.Name = "btn_GetPlanet";
            this.btn_GetPlanet.Size = new System.Drawing.Size(94, 29);
            this.btn_GetPlanet.TabIndex = 0;
            this.btn_GetPlanet.Text = "Get Planet";
            this.btn_GetPlanet.UseVisualStyleBackColor = true;
            this.btn_GetPlanet.Click += new System.EventHandler(this.btn_GetPlanet_Click);
            // 
            // btn_GetPerson
            // 
            this.btn_GetPerson.Location = new System.Drawing.Point(12, 45);
            this.btn_GetPerson.Name = "btn_GetPerson";
            this.btn_GetPerson.Size = new System.Drawing.Size(94, 29);
            this.btn_GetPerson.TabIndex = 1;
            this.btn_GetPerson.Text = "Get Person";
            this.btn_GetPerson.UseVisualStyleBackColor = true;
            this.btn_GetPerson.Click += new System.EventHandler(this.btn_GetPerson_Click);
            // 
            // btn_GetSpecies
            // 
            this.btn_GetSpecies.Location = new System.Drawing.Point(404, 10);
            this.btn_GetSpecies.Name = "btn_GetSpecies";
            this.btn_GetSpecies.Size = new System.Drawing.Size(94, 29);
            this.btn_GetSpecies.TabIndex = 2;
            this.btn_GetSpecies.Text = "Get Species";
            this.btn_GetSpecies.UseVisualStyleBackColor = true;
            this.btn_GetSpecies.Click += new System.EventHandler(this.btn_GetSpecies_Click);
            // 
            // btn_GetStarship
            // 
            this.btn_GetStarship.Location = new System.Drawing.Point(12, 80);
            this.btn_GetStarship.Name = "btn_GetStarship";
            this.btn_GetStarship.Size = new System.Drawing.Size(94, 29);
            this.btn_GetStarship.TabIndex = 3;
            this.btn_GetStarship.Text = "Starship";
            this.btn_GetStarship.UseVisualStyleBackColor = true;
            this.btn_GetStarship.Click += new System.EventHandler(this.btn_GetStarship_Click);
            // 
            // txt_GetID
            // 
            this.txt_GetID.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_GetID.ForeColor = System.Drawing.Color.Red;
            this.txt_GetID.Location = new System.Drawing.Point(112, 10);
            this.txt_GetID.Name = "txt_GetID";
            this.txt_GetID.Size = new System.Drawing.Size(70, 27);
            this.txt_GetID.TabIndex = 5;
            this.txt_GetID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GetID_KeyPress);
            // 
            // rtx_GetAllSpecies
            // 
            this.rtx_GetAllSpecies.Location = new System.Drawing.Point(504, 10);
            this.rtx_GetAllSpecies.Name = "rtx_GetAllSpecies";
            this.rtx_GetAllSpecies.Size = new System.Drawing.Size(284, 428);
            this.rtx_GetAllSpecies.TabIndex = 6;
            this.rtx_GetAllSpecies.Text = "";
            // 
            // lbl_ID1
            // 
            this.lbl_ID1.AutoSize = true;
            this.lbl_ID1.Location = new System.Drawing.Point(188, 13);
            this.lbl_ID1.Name = "lbl_ID1";
            this.lbl_ID1.Size = new System.Drawing.Size(32, 20);
            this.lbl_ID1.TabIndex = 8;
            this.lbl_ID1.Text = "ID1";
            // 
            // btn_Ratio
            // 
            this.btn_Ratio.Location = new System.Drawing.Point(12, 269);
            this.btn_Ratio.Name = "btn_Ratio";
            this.btn_Ratio.Size = new System.Drawing.Size(94, 29);
            this.btn_Ratio.TabIndex = 10;
            this.btn_Ratio.Text = "cost ratio";
            this.btn_Ratio.UseVisualStyleBackColor = true;
            this.btn_Ratio.Click += new System.EventHandler(this.btn_Ratio_Click);
            // 
            // txt_Ratio
            // 
            this.txt_Ratio.Location = new System.Drawing.Point(112, 269);
            this.txt_Ratio.Name = "txt_Ratio";
            this.txt_Ratio.Size = new System.Drawing.Size(125, 27);
            this.txt_Ratio.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ratio of ships cost per cargo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Ratio);
            this.Controls.Add(this.btn_Ratio);
            this.Controls.Add(this.lbl_ID1);
            this.Controls.Add(this.rtx_GetAllSpecies);
            this.Controls.Add(this.txt_GetID);
            this.Controls.Add(this.btn_GetStarship);
            this.Controls.Add(this.btn_GetSpecies);
            this.Controls.Add(this.btn_GetPerson);
            this.Controls.Add(this.btn_GetPlanet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_GetPlanet;
        private Button btn_GetPerson;
        private Button btn_GetSpecies;
        private Button btn_GetStarship;
        private TextBox txt_GetID;
        private RichTextBox rtx_GetAllSpecies;
        private Label lbl_ID1;
        private Button btn_Ratio;
        private TextBox txt_Ratio;
        private Label label1;
    }
}