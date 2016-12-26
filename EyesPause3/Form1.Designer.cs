namespace EyesPause3
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonTerminate = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelControl.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(125, 56);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(358, 91);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Отдохни";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(306, 30);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(170, 120);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "20";
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(113, 21);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(75, 23);
            this.buttonHide.TabIndex = 2;
            this.buttonHide.Text = "Завершить";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonTerminate
            // 
            this.buttonTerminate.Location = new System.Drawing.Point(113, 51);
            this.buttonTerminate.Name = "buttonTerminate";
            this.buttonTerminate.Size = new System.Drawing.Size(75, 23);
            this.buttonTerminate.TabIndex = 3;
            this.buttonTerminate.Text = "Terminate";
            this.buttonTerminate.UseVisualStyleBackColor = true;
            this.buttonTerminate.Click += new System.EventHandler(this.buttonTerminate_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.panelRight);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 375);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(484, 86);
            this.panelControl.TabIndex = 4;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.buttonHide);
            this.panelRight.Controls.Add(this.buttonTerminate);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(284, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 86);
            this.panelRight.TabIndex = 4;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.labelTime);
            this.panelMain.Controls.Add(this.labelInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(484, 375);
            this.panelMain.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EyesPause 3";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelControl.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonTerminate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelMain;
    }
}

