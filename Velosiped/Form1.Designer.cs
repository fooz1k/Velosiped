namespace Velosiped
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TurnLeftButton = new System.Windows.Forms.Button();
            this.TurnRightButton = new System.Windows.Forms.Button();
            this.CurrentWheelOnePositionLabel = new System.Windows.Forms.Label();
            this.CurrentWheelTwoPositionLabel = new System.Windows.Forms.Label();
            this.CurrentSteeringWheelPositionLabel = new System.Windows.Forms.Label();
            this.CurrentPositionLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.LowHealthDamageButton = new System.Windows.Forms.Button();
            this.HighHealthDamageButton = new System.Windows.Forms.Button();
            this.MovementLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TurnLeftButton
            // 
            this.TurnLeftButton.Location = new System.Drawing.Point(12, 215);
            this.TurnLeftButton.Name = "TurnLeftButton";
            this.TurnLeftButton.Size = new System.Drawing.Size(75, 40);
            this.TurnLeftButton.TabIndex = 0;
            this.TurnLeftButton.Text = "Повернуть налево";
            this.TurnLeftButton.UseVisualStyleBackColor = true;
            this.TurnLeftButton.Click += new System.EventHandler(this.TurnLeftButton_Click);
            // 
            // TurnRightButton
            // 
            this.TurnRightButton.Location = new System.Drawing.Point(107, 214);
            this.TurnRightButton.Name = "TurnRightButton";
            this.TurnRightButton.Size = new System.Drawing.Size(74, 41);
            this.TurnRightButton.TabIndex = 1;
            this.TurnRightButton.Text = "Повернуть направо";
            this.TurnRightButton.UseVisualStyleBackColor = true;
            this.TurnRightButton.Click += new System.EventHandler(this.TurnRightButton_Click);
            // 
            // CurrentWheelOnePositionLabel
            // 
            this.CurrentWheelOnePositionLabel.AutoSize = true;
            this.CurrentWheelOnePositionLabel.Location = new System.Drawing.Point(13, 13);
            this.CurrentWheelOnePositionLabel.Name = "CurrentWheelOnePositionLabel";
            this.CurrentWheelOnePositionLabel.Size = new System.Drawing.Size(46, 13);
            this.CurrentWheelOnePositionLabel.TabIndex = 2;
            this.CurrentWheelOnePositionLabel.Text = "X : Y: Z:";
            // 
            // CurrentWheelTwoPositionLabel
            // 
            this.CurrentWheelTwoPositionLabel.AutoSize = true;
            this.CurrentWheelTwoPositionLabel.Location = new System.Drawing.Point(13, 30);
            this.CurrentWheelTwoPositionLabel.Name = "CurrentWheelTwoPositionLabel";
            this.CurrentWheelTwoPositionLabel.Size = new System.Drawing.Size(46, 13);
            this.CurrentWheelTwoPositionLabel.TabIndex = 3;
            this.CurrentWheelTwoPositionLabel.Text = "X : Y: Z:";
            // 
            // CurrentSteeringWheelPositionLabel
            // 
            this.CurrentSteeringWheelPositionLabel.AutoSize = true;
            this.CurrentSteeringWheelPositionLabel.Location = new System.Drawing.Point(12, 70);
            this.CurrentSteeringWheelPositionLabel.Name = "CurrentSteeringWheelPositionLabel";
            this.CurrentSteeringWheelPositionLabel.Size = new System.Drawing.Size(31, 13);
            this.CurrentSteeringWheelPositionLabel.TabIndex = 4;
            this.CurrentSteeringWheelPositionLabel.Text = "Руль";
            // 
            // CurrentPositionLabel
            // 
            this.CurrentPositionLabel.AutoSize = true;
            this.CurrentPositionLabel.Location = new System.Drawing.Point(13, 47);
            this.CurrentPositionLabel.Name = "CurrentPositionLabel";
            this.CurrentPositionLabel.Size = new System.Drawing.Size(43, 13);
            this.CurrentPositionLabel.TabIndex = 8;
            this.CurrentPositionLabel.Text = "X: Y: Z:";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Location = new System.Drawing.Point(15, 87);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(38, 13);
            this.HealthLabel.TabIndex = 9;
            this.HealthLabel.Text = "Health";
            // 
            // LowHealthDamageButton
            // 
            this.LowHealthDamageButton.Location = new System.Drawing.Point(11, 166);
            this.LowHealthDamageButton.Name = "LowHealthDamageButton";
            this.LowHealthDamageButton.Size = new System.Drawing.Size(76, 43);
            this.LowHealthDamageButton.TabIndex = 10;
            this.LowHealthDamageButton.Text = "Попасть в яму";
            this.LowHealthDamageButton.UseVisualStyleBackColor = true;
            this.LowHealthDamageButton.Click += new System.EventHandler(this.LowHealthDamageButton_Click);
            // 
            // HighHealthDamageButton
            // 
            this.HighHealthDamageButton.Location = new System.Drawing.Point(106, 166);
            this.HighHealthDamageButton.Name = "HighHealthDamageButton";
            this.HighHealthDamageButton.Size = new System.Drawing.Size(73, 42);
            this.HighHealthDamageButton.TabIndex = 11;
            this.HighHealthDamageButton.Text = "Врезатся в стену";
            this.HighHealthDamageButton.UseVisualStyleBackColor = true;
            this.HighHealthDamageButton.Click += new System.EventHandler(this.HighHealthDamageButton_Click);
            // 
            // MovementLabel
            // 
            this.MovementLabel.AutoSize = true;
            this.MovementLabel.Location = new System.Drawing.Point(15, 104);
            this.MovementLabel.Name = "MovementLabel";
            this.MovementLabel.Size = new System.Drawing.Size(37, 13);
            this.MovementLabel.TabIndex = 12;
            this.MovementLabel.Text = "Едем ";
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(107, 261);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(87, 23);
            this.StopButton.TabIndex = 13;
            this.StopButton.Text = "Остановится";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(11, 261);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(75, 23);
            this.MoveButton.TabIndex = 14;
            this.MoveButton.Text = "Ехать";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 312);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.MovementLabel);
            this.Controls.Add(this.HighHealthDamageButton);
            this.Controls.Add(this.LowHealthDamageButton);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.CurrentPositionLabel);
            this.Controls.Add(this.CurrentSteeringWheelPositionLabel);
            this.Controls.Add(this.CurrentWheelTwoPositionLabel);
            this.Controls.Add(this.CurrentWheelOnePositionLabel);
            this.Controls.Add(this.TurnRightButton);
            this.Controls.Add(this.TurnLeftButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TurnLeftButton;
        private System.Windows.Forms.Button TurnRightButton;
        private System.Windows.Forms.Label CurrentWheelOnePositionLabel;
        private System.Windows.Forms.Label CurrentWheelTwoPositionLabel;
        private System.Windows.Forms.Label CurrentSteeringWheelPositionLabel;
        private System.Windows.Forms.Label CurrentPositionLabel;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Button LowHealthDamageButton;
        private System.Windows.Forms.Button HighHealthDamageButton;
        private System.Windows.Forms.Label MovementLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button MoveButton;
    }
}

