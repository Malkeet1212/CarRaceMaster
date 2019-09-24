namespace CarRace {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car3 = new System.Windows.Forms.PictureBox();
            this.Car4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LimBet = new System.Windows.Forms.Label();
            this.MarkBet = new System.Windows.Forms.Label();
            this.JhonBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.CarsNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.carRaceAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.LimRButton = new System.Windows.Forms.RadioButton();
            this.MarkRButton = new System.Windows.Forms.RadioButton();
            this.JhonButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRaceAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.SystemColors.Control;
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(-1, -64);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(802, 428);
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            this.racetrack.Click += new System.EventHandler(this.Racetrack_Click);
            // 
            // Car1
            // 
            this.Car1.Image = ((System.Drawing.Image)(resources.GetObject("Car1.Image")));
            this.Car1.Location = new System.Drawing.Point(13, 3);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(67, 59);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car1.TabIndex = 1;
            this.Car1.TabStop = false;
            // 
            // Car2
            // 
            this.Car2.Image = ((System.Drawing.Image)(resources.GetObject("Car2.Image")));
            this.Car2.Location = new System.Drawing.Point(12, 101);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(67, 59);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car2.TabIndex = 2;
            this.Car2.TabStop = false;
            // 
            // Car3
            // 
            this.Car3.Image = ((System.Drawing.Image)(resources.GetObject("Car3.Image")));
            this.Car3.Location = new System.Drawing.Point(12, 210);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(67, 59);
            this.Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car3.TabIndex = 3;
            this.Car3.TabStop = false;
            // 
            // Car4
            // 
            this.Car4.Image = ((System.Drawing.Image)(resources.GetObject("Car4.Image")));
            this.Car4.Location = new System.Drawing.Point(13, 297);
            this.Car4.Name = "Car4";
            this.Car4.Size = new System.Drawing.Size(67, 59);
            this.Car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car4.TabIndex = 4;
            this.Car4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.LimBet);
            this.groupBox1.Controls.Add(this.MarkBet);
            this.groupBox1.Controls.Add(this.JhonBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.CarsNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.carRaceAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.LimRButton);
            this.groupBox1.Controls.Add(this.MarkRButton);
            this.groupBox1.Controls.Add(this.JhonButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(-1, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 168);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Race";
            // 
            // LimBet
            // 
            this.LimBet.BackColor = System.Drawing.SystemColors.Info;
            this.LimBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LimBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LimBet.Location = new System.Drawing.Point(487, 112);
            this.LimBet.Name = "LimBet";
            this.LimBet.Size = new System.Drawing.Size(290, 17);
            this.LimBet.TabIndex = 13;
            this.LimBet.Text = "label6";
            // 
            // MarkBet
            // 
            this.MarkBet.BackColor = System.Drawing.SystemColors.Info;
            this.MarkBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MarkBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MarkBet.Location = new System.Drawing.Point(487, 86);
            this.MarkBet.Name = "MarkBet";
            this.MarkBet.Size = new System.Drawing.Size(290, 17);
            this.MarkBet.TabIndex = 12;
            this.MarkBet.Text = "label5";
            // 
            // JhonBet
            // 
            this.JhonBet.BackColor = System.Drawing.SystemColors.Info;
            this.JhonBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JhonBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.JhonBet.Location = new System.Drawing.Point(487, 61);
            this.JhonBet.Name = "JhonBet";
            this.JhonBet.Size = new System.Drawing.Size(290, 17);
            this.JhonBet.TabIndex = 11;
            this.JhonBet.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // race
            // 
            this.race.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.ForeColor = System.Drawing.Color.Black;
            this.race.Location = new System.Drawing.Point(14, 132);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(135, 30);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = true;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // CarsNumber
            // 
            this.CarsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CarsNumber.Location = new System.Drawing.Point(320, 62);
            this.CarsNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CarsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CarsNumber.Name = "CarsNumber";
            this.CarsNumber.Size = new System.Drawing.Size(64, 23);
            this.CarsNumber.TabIndex = 8;
            this.CarsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CarsNumber.ValueChanged += new System.EventHandler(this.CarsNumber_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(317, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cars number";
            // 
            // carRaceAmount
            // 
            this.carRaceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carRaceAmount.Location = new System.Drawing.Point(149, 61);
            this.carRaceAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.carRaceAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.carRaceAmount.Name = "carRaceAmount";
            this.carRaceAmount.Size = new System.Drawing.Size(63, 23);
            this.carRaceAmount.TabIndex = 6;
            this.carRaceAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.carRaceAmount.ValueChanged += new System.EventHandler(this.carRaceAmount_ValueChanged);
            // 
            // Bets
            // 
            this.Bets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Bets.Location = new System.Drawing.Point(487, 20);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(126, 30);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = true;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // LimRButton
            // 
            this.LimRButton.AutoSize = true;
            this.LimRButton.Checked = true;
            this.LimRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LimRButton.Location = new System.Drawing.Point(14, 97);
            this.LimRButton.Name = "LimRButton";
            this.LimRButton.Size = new System.Drawing.Size(48, 21);
            this.LimRButton.TabIndex = 3;
            this.LimRButton.TabStop = true;
            this.LimRButton.Text = "Lim";
            this.LimRButton.UseVisualStyleBackColor = true;
            this.LimRButton.CheckedChanged += new System.EventHandler(this.LimButton_CheckedChanged);
            // 
            // MarkRButton
            // 
            this.MarkRButton.AutoSize = true;
            this.MarkRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MarkRButton.Location = new System.Drawing.Point(14, 73);
            this.MarkRButton.Name = "MarkRButton";
            this.MarkRButton.Size = new System.Drawing.Size(57, 21);
            this.MarkRButton.TabIndex = 2;
            this.MarkRButton.Text = "Mark";
            this.MarkRButton.UseVisualStyleBackColor = true;
            this.MarkRButton.CheckedChanged += new System.EventHandler(this.MarkButton_CheckedChanged);
            // 
            // JhonButton
            // 
            this.JhonButton.AutoSize = true;
            this.JhonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.JhonButton.Location = new System.Drawing.Point(14, 49);
            this.JhonButton.Name = "JhonButton";
            this.JhonButton.Size = new System.Drawing.Size(57, 21);
            this.JhonButton.TabIndex = 1;
            this.JhonButton.Text = "Jhon";
            this.JhonButton.UseVisualStyleBackColor = true;
            this.JhonButton.CheckedChanged += new System.EventHandler(this.JhonButton_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(136, 28);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(101, 17);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            this.MaximumBet.Click += new System.EventHandler(this.MaximumBet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Car4);
            this.Controls.Add(this.Car3);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.Car1);
            this.Controls.Add(this.racetrack);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Race Course";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRaceAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox Car3;
        private System.Windows.Forms.PictureBox Car4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LimRButton;
        private System.Windows.Forms.RadioButton MarkRButton;
        private System.Windows.Forms.RadioButton JhonButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown carRaceAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown CarsNumber;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label JhonBet;
        private System.Windows.Forms.Label LimBet;
        private System.Windows.Forms.Label MarkBet;
    }
}

