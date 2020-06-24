namespace kvntrm
{
    partial class Summary_list
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
            this.labelExtra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewSum = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ship = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelShip = new System.Windows.Forms.Label();
            this.labelBal = new System.Windows.Forms.Label();
            this.textBoxBal = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxShip = new System.Windows.Forms.ComboBox();
            this.comboBoxExtra = new System.Windows.Forms.ComboBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExtra
            // 
            this.labelExtra.AutoSize = true;
            this.labelExtra.BackColor = System.Drawing.Color.Transparent;
            this.labelExtra.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExtra.Location = new System.Drawing.Point(83, 107);
            this.labelExtra.Name = "labelExtra";
            this.labelExtra.Size = new System.Drawing.Size(73, 25);
            this.labelExtra.TabIndex = 92;
            this.labelExtra.Text = "Выдача ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::kvntrm.Properties.Resources.ЛОГО_Кванториум_Цветной;
            this.pictureBox1.Location = new System.Drawing.Point(88, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // listViewSum
            // 
            this.listViewSum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listViewSum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Material,
            this.Extra,
            this.Ship,
            this.Balance});
            this.listViewSum.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewSum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewSum.FullRowSelect = true;
            this.listViewSum.GridLines = true;
            this.listViewSum.HideSelection = false;
            this.listViewSum.Location = new System.Drawing.Point(273, 51);
            this.listViewSum.MultiSelect = false;
            this.listViewSum.Name = "listViewSum";
            this.listViewSum.Size = new System.Drawing.Size(618, 270);
            this.listViewSum.TabIndex = 90;
            this.listViewSum.UseCompatibleStateImageBehavior = false;
            this.listViewSum.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 29;
            // 
            // Material
            // 
            this.Material.Text = "Товар";
            this.Material.Width = 47;
            // 
            // Extra
            // 
            this.Extra.Text = "Выдача";
            this.Extra.Width = 84;
            // 
            // Ship
            // 
            this.Ship.Text = "Поставка";
            this.Ship.Width = 82;
            // 
            // Balance
            // 
            this.Balance.Text = "Текущий баланс";
            this.Balance.Width = 138;
            // 
            // labelShip
            // 
            this.labelShip.AutoSize = true;
            this.labelShip.BackColor = System.Drawing.Color.Transparent;
            this.labelShip.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShip.Location = new System.Drawing.Point(83, 162);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(85, 25);
            this.labelShip.TabIndex = 89;
            this.labelShip.Text = "Поставка";
            // 
            // labelBal
            // 
            this.labelBal.AutoSize = true;
            this.labelBal.BackColor = System.Drawing.Color.Transparent;
            this.labelBal.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBal.Location = new System.Drawing.Point(81, 224);
            this.labelBal.Name = "labelBal";
            this.labelBal.Size = new System.Drawing.Size(136, 25);
            this.labelBal.TabIndex = 88;
            this.labelBal.Text = "Текущий баланс";
            // 
            // textBoxBal
            // 
            this.textBoxBal.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxBal.Location = new System.Drawing.Point(84, 252);
            this.textBoxBal.Name = "textBoxBal";
            this.textBoxBal.Size = new System.Drawing.Size(160, 27);
            this.textBoxBal.TabIndex = 85;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(481, 327);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(202, 44);
            this.buttonEdit.TabIndex = 84;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(273, 327);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(202, 44);
            this.buttonAdd.TabIndex = 83;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(689, 327);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(202, 44);
            this.buttonDel.TabIndex = 82;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            // 
            // comboBoxShip
            // 
            this.comboBoxShip.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxShip.FormattingEnabled = true;
            this.comboBoxShip.Location = new System.Drawing.Point(84, 190);
            this.comboBoxShip.Name = "comboBoxShip";
            this.comboBoxShip.Size = new System.Drawing.Size(160, 27);
            this.comboBoxShip.TabIndex = 93;
            // 
            // comboBoxExtra
            // 
            this.comboBoxExtra.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxExtra.FormattingEnabled = true;
            this.comboBoxExtra.Location = new System.Drawing.Point(84, 135);
            this.comboBoxExtra.Name = "comboBoxExtra";
            this.comboBoxExtra.Size = new System.Drawing.Size(160, 27);
            this.comboBoxExtra.TabIndex = 94;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.BackColor = System.Drawing.Color.Transparent;
            this.labelMaterial.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaterial.Location = new System.Drawing.Point(81, 49);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(57, 25);
            this.labelMaterial.TabIndex = 96;
            this.labelMaterial.Text = "Товар";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(84, 77);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(160, 27);
            this.comboBoxMaterial.TabIndex = 97;
            // 
            // Summary_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kvntrm.Properties.Resources.BG_for_IS;
            this.ClientSize = new System.Drawing.Size(953, 403);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.comboBoxExtra);
            this.Controls.Add(this.comboBoxShip);
            this.Controls.Add(this.labelExtra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewSum);
            this.Controls.Add(this.labelShip);
            this.Controls.Add(this.labelBal);
            this.Controls.Add(this.textBoxBal);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDel);
            this.Name = "Summary_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сводная ведомость о расходных материалах и оборудовании";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExtra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewSum;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Material;
        private System.Windows.Forms.ColumnHeader Extra;
        private System.Windows.Forms.ColumnHeader Ship;
        private System.Windows.Forms.ColumnHeader Balance;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.Label labelBal;
        private System.Windows.Forms.TextBox textBoxBal;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxShip;
        private System.Windows.Forms.ComboBox comboBoxExtra;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
    }
}