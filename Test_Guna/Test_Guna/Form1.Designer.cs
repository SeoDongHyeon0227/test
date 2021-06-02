
namespace Test_Guna
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Value_Bar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.Value_Bar2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Value_Bar3 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Value_Bar4 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Value_Bar5 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Value_Bar6 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Value_Bar7 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Value_Bar1
            // 
            this.Value_Bar1.AnimationSpeed = 0.3F;
            this.Value_Bar1.FillColor = System.Drawing.Color.DimGray;
            this.Value_Bar1.FillOffset = 50;
            this.Value_Bar1.FillThickness = 10;
            this.Value_Bar1.Font = new System.Drawing.Font("한양해서", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Value_Bar1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Value_Bar1.Location = new System.Drawing.Point(12, 12);
            this.Value_Bar1.Name = "Value_Bar1";
            this.Value_Bar1.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.Value_Bar1.ProgressColor = System.Drawing.Color.Aqua;
            this.Value_Bar1.ProgressColor2 = System.Drawing.Color.DarkBlue;
            this.Value_Bar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar1.ProgressOffset = 40;
            this.Value_Bar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar1.ProgressThickness = 20;
            this.Value_Bar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Value_Bar1.ShadowDecoration.Parent = this.Value_Bar1;
            this.Value_Bar1.ShowPercentage = true;
            this.Value_Bar1.Size = new System.Drawing.Size(150, 150);
            this.Value_Bar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Value_Bar2
            // 
            this.Value_Bar2.FillColor = System.Drawing.Color.DimGray;
            this.Value_Bar2.FillOffset = 50;
            this.Value_Bar2.FillThickness = 10;
            this.Value_Bar2.Font = new System.Drawing.Font("한양해서", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Value_Bar2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Value_Bar2.Location = new System.Drawing.Point(12, 168);
            this.Value_Bar2.Name = "Value_Bar2";
            this.Value_Bar2.ProgressColor = System.Drawing.Color.Aqua;
            this.Value_Bar2.ProgressColor2 = System.Drawing.Color.DarkBlue;
            this.Value_Bar2.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar2.ProgressOffset = 40;
            this.Value_Bar2.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar2.ProgressThickness = 20;
            this.Value_Bar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Value_Bar2.ShadowDecoration.Parent = this.Value_Bar2;
            this.Value_Bar2.ShowPercentage = true;
            this.Value_Bar2.Size = new System.Drawing.Size(150, 150);
            this.Value_Bar2.TabIndex = 2;
            // 
            // Value_Bar3
            // 
            this.Value_Bar3.FillColor = System.Drawing.Color.DimGray;
            this.Value_Bar3.FillOffset = 50;
            this.Value_Bar3.FillThickness = 10;
            this.Value_Bar3.Font = new System.Drawing.Font("한양해서", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Value_Bar3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Value_Bar3.Location = new System.Drawing.Point(12, 333);
            this.Value_Bar3.Name = "Value_Bar3";
            this.Value_Bar3.ProgressColor = System.Drawing.Color.Aqua;
            this.Value_Bar3.ProgressColor2 = System.Drawing.Color.DarkBlue;
            this.Value_Bar3.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar3.ProgressOffset = 40;
            this.Value_Bar3.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar3.ProgressThickness = 20;
            this.Value_Bar3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Value_Bar3.ShadowDecoration.Parent = this.Value_Bar3;
            this.Value_Bar3.ShowPercentage = true;
            this.Value_Bar3.Size = new System.Drawing.Size(150, 150);
            this.Value_Bar3.TabIndex = 3;
            // 
            // Value_Bar4
            // 
            this.Value_Bar4.FillColor = System.Drawing.Color.DimGray;
            this.Value_Bar4.FillOffset = 50;
            this.Value_Bar4.FillThickness = 10;
            this.Value_Bar4.Font = new System.Drawing.Font("한양해서", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Value_Bar4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Value_Bar4.Location = new System.Drawing.Point(225, 12);
            this.Value_Bar4.Name = "Value_Bar4";
            this.Value_Bar4.ProgressColor = System.Drawing.Color.Aqua;
            this.Value_Bar4.ProgressColor2 = System.Drawing.Color.DarkBlue;
            this.Value_Bar4.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar4.ProgressOffset = 40;
            this.Value_Bar4.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar4.ProgressThickness = 20;
            this.Value_Bar4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Value_Bar4.ShadowDecoration.Parent = this.Value_Bar4;
            this.Value_Bar4.ShowPercentage = true;
            this.Value_Bar4.Size = new System.Drawing.Size(150, 150);
            this.Value_Bar4.TabIndex = 4;
            // 
            // Value_Bar5
            // 
            this.Value_Bar5.FillColor = System.Drawing.Color.DimGray;
            this.Value_Bar5.FillOffset = 50;
            this.Value_Bar5.FillThickness = 10;
            this.Value_Bar5.Font = new System.Drawing.Font("한양해서", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Value_Bar5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Value_Bar5.Location = new System.Drawing.Point(225, 175);
            this.Value_Bar5.Name = "Value_Bar5";
            this.Value_Bar5.ProgressColor = System.Drawing.Color.Aqua;
            this.Value_Bar5.ProgressColor2 = System.Drawing.Color.DarkBlue;
            this.Value_Bar5.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar5.ProgressOffset = 40;
            this.Value_Bar5.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar5.ProgressThickness = 20;
            this.Value_Bar5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Value_Bar5.ShadowDecoration.Parent = this.Value_Bar5;
            this.Value_Bar5.ShowPercentage = true;
            this.Value_Bar5.Size = new System.Drawing.Size(150, 150);
            this.Value_Bar5.TabIndex = 5;
            // 
            // Value_Bar6
            // 
            this.Value_Bar6.FillColor = System.Drawing.Color.DimGray;
            this.Value_Bar6.FillOffset = 50;
            this.Value_Bar6.FillThickness = 10;
            this.Value_Bar6.Font = new System.Drawing.Font("한양해서", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Value_Bar6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Value_Bar6.Location = new System.Drawing.Point(225, 333);
            this.Value_Bar6.Name = "Value_Bar6";
            this.Value_Bar6.ProgressColor = System.Drawing.Color.Aqua;
            this.Value_Bar6.ProgressColor2 = System.Drawing.Color.DarkBlue;
            this.Value_Bar6.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar6.ProgressOffset = 40;
            this.Value_Bar6.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar6.ProgressThickness = 20;
            this.Value_Bar6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Value_Bar6.ShadowDecoration.Parent = this.Value_Bar6;
            this.Value_Bar6.ShowPercentage = true;
            this.Value_Bar6.Size = new System.Drawing.Size(150, 150);
            this.Value_Bar6.TabIndex = 4;
            // 
            // Value_Bar7
            // 
            this.Value_Bar7.FillColor = System.Drawing.Color.DimGray;
            this.Value_Bar7.FillOffset = 50;
            this.Value_Bar7.FillThickness = 10;
            this.Value_Bar7.Font = new System.Drawing.Font("한양해서", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Value_Bar7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Value_Bar7.Location = new System.Drawing.Point(443, 12);
            this.Value_Bar7.Name = "Value_Bar7";
            this.Value_Bar7.ProgressColor = System.Drawing.Color.Aqua;
            this.Value_Bar7.ProgressColor2 = System.Drawing.Color.DarkBlue;
            this.Value_Bar7.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar7.ProgressOffset = 40;
            this.Value_Bar7.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Value_Bar7.ProgressThickness = 20;
            this.Value_Bar7.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Value_Bar7.ShadowDecoration.Parent = this.Value_Bar7;
            this.Value_Bar7.ShowPercentage = true;
            this.Value_Bar7.Size = new System.Drawing.Size(150, 150);
            this.Value_Bar7.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(716, 557);
            this.Controls.Add(this.Value_Bar7);
            this.Controls.Add(this.Value_Bar6);
            this.Controls.Add(this.Value_Bar5);
            this.Controls.Add(this.Value_Bar4);
            this.Controls.Add(this.Value_Bar3);
            this.Controls.Add(this.Value_Bar2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Value_Bar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar Value_Bar1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Value_Bar2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Value_Bar3;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Value_Bar4;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Value_Bar5;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Value_Bar6;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Value_Bar7;
        private System.Windows.Forms.Timer timer1;
    }
}

