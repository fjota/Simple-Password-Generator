namespace Password_Generator
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.Copy_passwd = new System.Windows.Forms.Button();
      this.New_passwd = new System.Windows.Forms.Button();
      this.Text_special_characters = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.Text_passwd = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.Special_characters = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.Passwd_length = new System.Windows.Forms.NumericUpDown();
      this.Numbers = new System.Windows.Forms.CheckBox();
      this.Lowecase_letters = new System.Windows.Forms.CheckBox();
      this.Capital_letters = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Passwd_length)).BeginInit();
      this.SuspendLayout();
      // 
      // Copy_passwd
      // 
      this.Copy_passwd.BackColor = System.Drawing.SystemColors.Control;
      this.Copy_passwd.FlatAppearance.BorderSize = 0;
      this.Copy_passwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Copy_passwd.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Copy_passwd.ForeColor = System.Drawing.Color.Black;
      this.Copy_passwd.Location = new System.Drawing.Point(120, 103);
      this.Copy_passwd.Name = "Copy_passwd";
      this.Copy_passwd.Size = new System.Drawing.Size(123, 33);
      this.Copy_passwd.TabIndex = 0;
      this.Copy_passwd.Text = "Copy";
      this.Copy_passwd.UseVisualStyleBackColor = false;
      this.Copy_passwd.Click += new System.EventHandler(this.Copy_passwd_Click);
      // 
      // New_passwd
      // 
      this.New_passwd.BackColor = System.Drawing.Color.Transparent;
      this.New_passwd.BackgroundImage = global::Password_Generator.Properties.Resources.loop;
      this.New_passwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.New_passwd.FlatAppearance.BorderSize = 0;
      this.New_passwd.Location = new System.Drawing.Point(275, 58);
      this.New_passwd.Name = "New_passwd";
      this.New_passwd.Size = new System.Drawing.Size(31, 31);
      this.New_passwd.TabIndex = 1;
      this.New_passwd.UseVisualStyleBackColor = false;
      this.New_passwd.Click += new System.EventHandler(this.New_passwd_Click);
      // 
      // Text_special_characters
      // 
      this.Text_special_characters.Location = new System.Drawing.Point(182, 202);
      this.Text_special_characters.Name = "Text_special_characters";
      this.Text_special_characters.ReadOnly = true;
      this.Text_special_characters.Size = new System.Drawing.Size(124, 20);
      this.Text_special_characters.TabIndex = 2;
      this.Text_special_characters.Text = "~!@#$%^&*+-/.,\\{}[]();:";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.Text_passwd);
      this.panel1.Controls.Add(this.New_passwd);
      this.panel1.Controls.Add(this.Copy_passwd);
      this.panel1.Location = new System.Drawing.Point(0, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(365, 208);
      this.panel1.TabIndex = 3;
      // 
      // Text_passwd
      // 
      this.Text_passwd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Text_passwd.Location = new System.Drawing.Point(106, 58);
      this.Text_passwd.Name = "Text_passwd";
      this.Text_passwd.Size = new System.Drawing.Size(163, 27);
      this.Text_passwd.TabIndex = 5;
      this.Text_passwd.Text = "fhdVx8}G;z(T";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.Special_characters);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.Text_special_characters);
      this.panel2.Controls.Add(this.Passwd_length);
      this.panel2.Controls.Add(this.Numbers);
      this.panel2.Controls.Add(this.Lowecase_letters);
      this.panel2.Controls.Add(this.Capital_letters);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 217);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(365, 272);
      this.panel2.TabIndex = 4;
      // 
      // Special_characters
      // 
      this.Special_characters.AutoSize = true;
      this.Special_characters.Checked = true;
      this.Special_characters.CheckState = System.Windows.Forms.CheckState.Checked;
      this.Special_characters.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Special_characters.Location = new System.Drawing.Point(29, 202);
      this.Special_characters.Name = "Special_characters";
      this.Special_characters.Size = new System.Drawing.Size(147, 20);
      this.Special_characters.TabIndex = 5;
      this.Special_characters.Text = "Special Characters";
      this.Special_characters.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(26, 43);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(121, 16);
      this.label1.TabIndex = 4;
      this.label1.Text = "Password Length:";
      // 
      // Passwd_length
      // 
      this.Passwd_length.Location = new System.Drawing.Point(153, 43);
      this.Passwd_length.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.Passwd_length.Name = "Passwd_length";
      this.Passwd_length.Size = new System.Drawing.Size(47, 20);
      this.Passwd_length.TabIndex = 3;
      this.Passwd_length.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
      // 
      // Numbers
      // 
      this.Numbers.AutoSize = true;
      this.Numbers.Checked = true;
      this.Numbers.CheckState = System.Windows.Forms.CheckState.Checked;
      this.Numbers.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Numbers.Location = new System.Drawing.Point(29, 162);
      this.Numbers.Name = "Numbers";
      this.Numbers.Size = new System.Drawing.Size(118, 20);
      this.Numbers.TabIndex = 2;
      this.Numbers.Text = "Numbers (0-9)";
      this.Numbers.UseVisualStyleBackColor = true;
      // 
      // Lowecase_letters
      // 
      this.Lowecase_letters.AutoSize = true;
      this.Lowecase_letters.Checked = true;
      this.Lowecase_letters.CheckState = System.Windows.Forms.CheckState.Checked;
      this.Lowecase_letters.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Lowecase_letters.Location = new System.Drawing.Point(29, 122);
      this.Lowecase_letters.Name = "Lowecase_letters";
      this.Lowecase_letters.Size = new System.Drawing.Size(128, 20);
      this.Lowecase_letters.TabIndex = 1;
      this.Lowecase_letters.Text = "Lowercase (a-z)";
      this.Lowecase_letters.UseVisualStyleBackColor = true;
      // 
      // Capital_letters
      // 
      this.Capital_letters.AutoSize = true;
      this.Capital_letters.Checked = true;
      this.Capital_letters.CheckState = System.Windows.Forms.CheckState.Checked;
      this.Capital_letters.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Capital_letters.Location = new System.Drawing.Point(29, 86);
      this.Capital_letters.Name = "Capital_letters";
      this.Capital_letters.Size = new System.Drawing.Size(150, 20);
      this.Capital_letters.TabIndex = 0;
      this.Capital_letters.Text = "Capital letters (A-Z)";
      this.Capital_letters.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(365, 489);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "PASSWORD GENERATOR";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Passwd_length)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button Copy_passwd;
    private System.Windows.Forms.Button New_passwd;
    private System.Windows.Forms.TextBox Text_special_characters;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label Text_passwd;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown Passwd_length;
    private System.Windows.Forms.CheckBox Numbers;
    private System.Windows.Forms.CheckBox Lowecase_letters;
    private System.Windows.Forms.CheckBox Capital_letters;
    private System.Windows.Forms.CheckBox Special_characters;
  }
}

