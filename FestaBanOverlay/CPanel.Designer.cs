namespace FestaGameOverlay
{
    partial class CPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerA = new System.Windows.Forms.TextBox();
            this.PlayerB = new System.Windows.Forms.TextBox();
            this.DoCollect = new System.Windows.Forms.Button();
            this.OpenOverlay = new System.Windows.Forms.Button();
            this.PanelA = new System.Windows.Forms.Panel();
            this.PlayerAX = new System.Windows.Forms.RadioButton();
            this.PlayerA8B = new System.Windows.Forms.RadioButton();
            this.PlayerA4B = new System.Windows.Forms.RadioButton();
            this.PlayerA6B = new System.Windows.Forms.RadioButton();
            this.PlayerA5B = new System.Windows.Forms.RadioButton();
            this.PanelB = new System.Windows.Forms.Panel();
            this.PlayerB8B = new System.Windows.Forms.RadioButton();
            this.PlayerB6B = new System.Windows.Forms.RadioButton();
            this.PlayerB5B = new System.Windows.Forms.RadioButton();
            this.PlayerB4B = new System.Windows.Forms.RadioButton();
            this.PlayerBX = new System.Windows.Forms.RadioButton();
            this.BanModeCheckBox = new System.Windows.Forms.CheckBox();
            this.ScoreA = new System.Windows.Forms.TextBox();
            this.ScoreB = new System.Windows.Forms.TextBox();
            this.PlayerAP = new System.Windows.Forms.Button();
            this.PlayerAM = new System.Windows.Forms.Button();
            this.PlayerBM = new System.Windows.Forms.Button();
            this.PlayerBP = new System.Windows.Forms.Button();
            this.ResetTimer = new System.Windows.Forms.Button();
            this.EnableTimer = new System.Windows.Forms.Button();
            this.DisableTimer = new System.Windows.Forms.Button();
            this.TimerInitValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelA.SuspendLayout();
            this.PanelB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Pretendard", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "선수";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayerA
            // 
            this.PlayerA.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerA.Location = new System.Drawing.Point(135, 22);
            this.PlayerA.Name = "PlayerA";
            this.PlayerA.Size = new System.Drawing.Size(173, 31);
            this.PlayerA.TabIndex = 7;
            this.PlayerA.TextChanged += new System.EventHandler(this.PlayerA_TextChanged);
            // 
            // PlayerB
            // 
            this.PlayerB.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerB.Location = new System.Drawing.Point(135, 85);
            this.PlayerB.Name = "PlayerB";
            this.PlayerB.Size = new System.Drawing.Size(173, 31);
            this.PlayerB.TabIndex = 8;
            this.PlayerB.TextChanged += new System.EventHandler(this.PlayerB_TextChanged);
            // 
            // DoCollect
            // 
            this.DoCollect.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoCollect.Location = new System.Drawing.Point(12, 248);
            this.DoCollect.Name = "DoCollect";
            this.DoCollect.Size = new System.Drawing.Size(108, 31);
            this.DoCollect.TabIndex = 29;
            this.DoCollect.Text = "메모리 정리";
            this.DoCollect.UseVisualStyleBackColor = true;
            this.DoCollect.Click += new System.EventHandler(this.DoCollect_Click);
            // 
            // OpenOverlay
            // 
            this.OpenOverlay.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenOverlay.Location = new System.Drawing.Point(135, 238);
            this.OpenOverlay.Name = "OpenOverlay";
            this.OpenOverlay.Size = new System.Drawing.Size(209, 41);
            this.OpenOverlay.TabIndex = 30;
            this.OpenOverlay.Text = "오버레이 실행";
            this.OpenOverlay.UseVisualStyleBackColor = true;
            this.OpenOverlay.Click += new System.EventHandler(this.OpenOverlay_Click);
            // 
            // PanelA
            // 
            this.PanelA.Controls.Add(this.PlayerAX);
            this.PanelA.Controls.Add(this.PlayerA8B);
            this.PanelA.Controls.Add(this.PlayerA4B);
            this.PanelA.Controls.Add(this.PlayerA6B);
            this.PanelA.Controls.Add(this.PlayerA5B);
            this.PanelA.Location = new System.Drawing.Point(443, 15);
            this.PanelA.Name = "PanelA";
            this.PanelA.Size = new System.Drawing.Size(408, 44);
            this.PanelA.TabIndex = 39;
            // 
            // PlayerAX
            // 
            this.PlayerAX.AutoSize = true;
            this.PlayerAX.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerAX.Location = new System.Drawing.Point(329, 0);
            this.PlayerAX.Name = "PlayerAX";
            this.PlayerAX.Size = new System.Drawing.Size(55, 44);
            this.PlayerAX.TabIndex = 45;
            this.PlayerAX.TabStop = true;
            this.PlayerAX.Text = "X";
            this.PlayerAX.UseVisualStyleBackColor = true;
            // 
            // PlayerA8B
            // 
            this.PlayerA8B.AutoSize = true;
            this.PlayerA8B.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerA8B.Location = new System.Drawing.Point(247, 0);
            this.PlayerA8B.Name = "PlayerA8B";
            this.PlayerA8B.Size = new System.Drawing.Size(76, 44);
            this.PlayerA8B.TabIndex = 44;
            this.PlayerA8B.TabStop = true;
            this.PlayerA8B.Text = "8B";
            this.PlayerA8B.UseVisualStyleBackColor = true;
            // 
            // PlayerA4B
            // 
            this.PlayerA4B.AutoSize = true;
            this.PlayerA4B.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerA4B.Location = new System.Drawing.Point(0, 0);
            this.PlayerA4B.Name = "PlayerA4B";
            this.PlayerA4B.Size = new System.Drawing.Size(77, 44);
            this.PlayerA4B.TabIndex = 41;
            this.PlayerA4B.TabStop = true;
            this.PlayerA4B.Text = "4B";
            this.PlayerA4B.UseVisualStyleBackColor = true;
            // 
            // PlayerA6B
            // 
            this.PlayerA6B.AutoSize = true;
            this.PlayerA6B.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerA6B.Location = new System.Drawing.Point(165, 0);
            this.PlayerA6B.Name = "PlayerA6B";
            this.PlayerA6B.Size = new System.Drawing.Size(76, 44);
            this.PlayerA6B.TabIndex = 43;
            this.PlayerA6B.TabStop = true;
            this.PlayerA6B.Text = "6B";
            this.PlayerA6B.UseVisualStyleBackColor = true;
            // 
            // PlayerA5B
            // 
            this.PlayerA5B.AutoSize = true;
            this.PlayerA5B.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerA5B.Location = new System.Drawing.Point(83, 0);
            this.PlayerA5B.Name = "PlayerA5B";
            this.PlayerA5B.Size = new System.Drawing.Size(76, 44);
            this.PlayerA5B.TabIndex = 42;
            this.PlayerA5B.TabStop = true;
            this.PlayerA5B.Text = "5B";
            this.PlayerA5B.UseVisualStyleBackColor = true;
            // 
            // PanelB
            // 
            this.PanelB.Controls.Add(this.PlayerB8B);
            this.PanelB.Controls.Add(this.PlayerB6B);
            this.PanelB.Controls.Add(this.PlayerB5B);
            this.PanelB.Controls.Add(this.PlayerB4B);
            this.PanelB.Location = new System.Drawing.Point(443, 79);
            this.PanelB.Name = "PanelB";
            this.PanelB.Size = new System.Drawing.Size(408, 44);
            this.PanelB.TabIndex = 40;
            // 
            // PlayerB8B
            // 
            this.PlayerB8B.AutoSize = true;
            this.PlayerB8B.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerB8B.Location = new System.Drawing.Point(247, 0);
            this.PlayerB8B.Name = "PlayerB8B";
            this.PlayerB8B.Size = new System.Drawing.Size(76, 44);
            this.PlayerB8B.TabIndex = 42;
            this.PlayerB8B.TabStop = true;
            this.PlayerB8B.Text = "8B";
            this.PlayerB8B.UseVisualStyleBackColor = true;
            // 
            // PlayerB6B
            // 
            this.PlayerB6B.AutoSize = true;
            this.PlayerB6B.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerB6B.Location = new System.Drawing.Point(165, 0);
            this.PlayerB6B.Name = "PlayerB6B";
            this.PlayerB6B.Size = new System.Drawing.Size(76, 44);
            this.PlayerB6B.TabIndex = 41;
            this.PlayerB6B.TabStop = true;
            this.PlayerB6B.Text = "6B";
            this.PlayerB6B.UseVisualStyleBackColor = true;
            // 
            // PlayerB5B
            // 
            this.PlayerB5B.AutoSize = true;
            this.PlayerB5B.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerB5B.Location = new System.Drawing.Point(83, 0);
            this.PlayerB5B.Name = "PlayerB5B";
            this.PlayerB5B.Size = new System.Drawing.Size(76, 44);
            this.PlayerB5B.TabIndex = 40;
            this.PlayerB5B.TabStop = true;
            this.PlayerB5B.Text = "5B";
            this.PlayerB5B.UseVisualStyleBackColor = true;
            // 
            // PlayerB4B
            // 
            this.PlayerB4B.AutoSize = true;
            this.PlayerB4B.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerB4B.Location = new System.Drawing.Point(0, 0);
            this.PlayerB4B.Name = "PlayerB4B";
            this.PlayerB4B.Size = new System.Drawing.Size(77, 44);
            this.PlayerB4B.TabIndex = 39;
            this.PlayerB4B.TabStop = true;
            this.PlayerB4B.Text = "4B";
            this.PlayerB4B.UseVisualStyleBackColor = true;
            // 
            // PlayerBX
            // 
            this.PlayerBX.AutoSize = true;
            this.PlayerBX.Font = new System.Drawing.Font("Pretendard Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerBX.Location = new System.Drawing.Point(772, 79);
            this.PlayerBX.Name = "PlayerBX";
            this.PlayerBX.Size = new System.Drawing.Size(55, 44);
            this.PlayerBX.TabIndex = 43;
            this.PlayerBX.TabStop = true;
            this.PlayerBX.Text = "X";
            this.PlayerBX.UseVisualStyleBackColor = true;
            // 
            // BanModeCheckBox
            // 
            this.BanModeCheckBox.AutoSize = true;
            this.BanModeCheckBox.Font = new System.Drawing.Font("Pretendard Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BanModeCheckBox.Location = new System.Drawing.Point(443, 132);
            this.BanModeCheckBox.Name = "BanModeCheckBox";
            this.BanModeCheckBox.Size = new System.Drawing.Size(345, 28);
            this.BanModeCheckBox.TabIndex = 45;
            this.BanModeCheckBox.Text = "벤 픽 모드 (선택 키위에 X를 표시합니다.)";
            this.BanModeCheckBox.UseVisualStyleBackColor = true;
            this.BanModeCheckBox.CheckedChanged += new System.EventHandler(this.BanModeCheckBox_CheckedChanged);
            // 
            // ScoreA
            // 
            this.ScoreA.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreA.Location = new System.Drawing.Point(386, 21);
            this.ScoreA.Name = "ScoreA";
            this.ScoreA.Size = new System.Drawing.Size(47, 31);
            this.ScoreA.TabIndex = 46;
            this.ScoreA.Text = "0";
            this.ScoreA.TextChanged += new System.EventHandler(this.ScoreA_TextChanged);
            // 
            // ScoreB
            // 
            this.ScoreB.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreB.Location = new System.Drawing.Point(386, 85);
            this.ScoreB.Name = "ScoreB";
            this.ScoreB.Size = new System.Drawing.Size(47, 31);
            this.ScoreB.TabIndex = 47;
            this.ScoreB.Text = "0";
            this.ScoreB.TextChanged += new System.EventHandler(this.ScoreB_TextChanged);
            // 
            // PlayerAP
            // 
            this.PlayerAP.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerAP.Location = new System.Drawing.Point(314, 22);
            this.PlayerAP.Name = "PlayerAP";
            this.PlayerAP.Size = new System.Drawing.Size(30, 30);
            this.PlayerAP.TabIndex = 48;
            this.PlayerAP.Text = "+";
            this.PlayerAP.UseVisualStyleBackColor = true;
            this.PlayerAP.Click += new System.EventHandler(this.PlayerAP_Click);
            // 
            // PlayerAM
            // 
            this.PlayerAM.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerAM.Location = new System.Drawing.Point(350, 22);
            this.PlayerAM.Name = "PlayerAM";
            this.PlayerAM.Size = new System.Drawing.Size(30, 30);
            this.PlayerAM.TabIndex = 49;
            this.PlayerAM.Text = "-";
            this.PlayerAM.UseVisualStyleBackColor = true;
            this.PlayerAM.Click += new System.EventHandler(this.PlayerAM_Click);
            // 
            // PlayerBM
            // 
            this.PlayerBM.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerBM.Location = new System.Drawing.Point(350, 85);
            this.PlayerBM.Name = "PlayerBM";
            this.PlayerBM.Size = new System.Drawing.Size(30, 30);
            this.PlayerBM.TabIndex = 51;
            this.PlayerBM.Text = "-";
            this.PlayerBM.UseVisualStyleBackColor = true;
            this.PlayerBM.Click += new System.EventHandler(this.PlayerBM_Click);
            // 
            // PlayerBP
            // 
            this.PlayerBP.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerBP.Location = new System.Drawing.Point(314, 85);
            this.PlayerBP.Name = "PlayerBP";
            this.PlayerBP.Size = new System.Drawing.Size(30, 30);
            this.PlayerBP.TabIndex = 50;
            this.PlayerBP.Text = "+";
            this.PlayerBP.UseVisualStyleBackColor = true;
            this.PlayerBP.Click += new System.EventHandler(this.PlayerBP_Click);
            // 
            // ResetTimer
            // 
            this.ResetTimer.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetTimer.Location = new System.Drawing.Point(276, 171);
            this.ResetTimer.Margin = new System.Windows.Forms.Padding(0);
            this.ResetTimer.Name = "ResetTimer";
            this.ResetTimer.Size = new System.Drawing.Size(157, 41);
            this.ResetTimer.TabIndex = 52;
            this.ResetTimer.Text = "타이머 초기화";
            this.ResetTimer.UseVisualStyleBackColor = true;
            this.ResetTimer.Click += new System.EventHandler(this.ResetTimer_Click);
            // 
            // EnableTimer
            // 
            this.EnableTimer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.EnableTimer.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnableTimer.Location = new System.Drawing.Point(457, 171);
            this.EnableTimer.Margin = new System.Windows.Forms.Padding(0);
            this.EnableTimer.Name = "EnableTimer";
            this.EnableTimer.Size = new System.Drawing.Size(180, 41);
            this.EnableTimer.TabIndex = 53;
            this.EnableTimer.Text = "타이머 활성화";
            this.EnableTimer.UseVisualStyleBackColor = false;
            this.EnableTimer.Click += new System.EventHandler(this.EnableTimer_Click);
            // 
            // DisableTimer
            // 
            this.DisableTimer.BackColor = System.Drawing.Color.LightCoral;
            this.DisableTimer.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisableTimer.Location = new System.Drawing.Point(647, 171);
            this.DisableTimer.Margin = new System.Windows.Forms.Padding(0);
            this.DisableTimer.Name = "DisableTimer";
            this.DisableTimer.Size = new System.Drawing.Size(180, 41);
            this.DisableTimer.TabIndex = 54;
            this.DisableTimer.Text = "타이머 비활성화";
            this.DisableTimer.UseVisualStyleBackColor = false;
            this.DisableTimer.Click += new System.EventHandler(this.DisableTimer_Click);
            // 
            // TimerInitValue
            // 
            this.TimerInitValue.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerInitValue.Location = new System.Drawing.Point(135, 176);
            this.TimerInitValue.Name = "TimerInitValue";
            this.TimerInitValue.Size = new System.Drawing.Size(66, 31);
            this.TimerInitValue.TabIndex = 55;
            this.TimerInitValue.Text = "60";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Pretendard", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 50);
            this.label1.TabIndex = 56;
            this.label1.Text = "타이머";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(870, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerInitValue);
            this.Controls.Add(this.DisableTimer);
            this.Controls.Add(this.EnableTimer);
            this.Controls.Add(this.ResetTimer);
            this.Controls.Add(this.PlayerBM);
            this.Controls.Add(this.PlayerBP);
            this.Controls.Add(this.PlayerAM);
            this.Controls.Add(this.PlayerAP);
            this.Controls.Add(this.ScoreB);
            this.Controls.Add(this.ScoreA);
            this.Controls.Add(this.BanModeCheckBox);
            this.Controls.Add(this.PlayerBX);
            this.Controls.Add(this.PanelB);
            this.Controls.Add(this.PanelA);
            this.Controls.Add(this.OpenOverlay);
            this.Controls.Add(this.DoCollect);
            this.Controls.Add(this.PlayerB);
            this.Controls.Add(this.PlayerA);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "CPanel";
            this.ShowIcon = false;
            this.Text = "오버레이 제어판";
            this.PanelA.ResumeLayout(false);
            this.PanelA.PerformLayout();
            this.PanelB.ResumeLayout(false);
            this.PanelB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private TextBox PlayerA;
        private TextBox PlayerB;
        private Button DoCollect;
        private Button OpenOverlay;
        private Panel PanelA;
        private Panel PanelB;
        private RadioButton PlayerA8B;
        private RadioButton PlayerA4B;
        private RadioButton PlayerA6B;
        private RadioButton PlayerA5B;
        private RadioButton PlayerB8B;
        private RadioButton PlayerB6B;
        private RadioButton PlayerB5B;
        private RadioButton PlayerB4B;
        private RadioButton PlayerAX;
        private RadioButton PlayerBX;
        private CheckBox BanModeCheckBox;
        private TextBox ScoreA;
        private TextBox ScoreB;
        private Button PlayerAP;
        private Button PlayerAM;
        private Button PlayerBM;
        private Button PlayerBP;
        private Button ResetTimer;
        private Button EnableTimer;
        private Button DisableTimer;
        private TextBox TimerInitValue;
        private Label label1;
    }
}
