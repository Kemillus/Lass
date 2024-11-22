namespace Crossing
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPointX = new System.Windows.Forms.TextBox();
            this.textBoxPointY = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxPosX = new System.Windows.Forms.TextBox();
            this.textBoxPosY = new System.Windows.Forms.TextBox();
            this.buttonCreateFigure = new System.Windows.Forms.Button();
            this.buttonCloseFigure = new System.Windows.Forms.Button();
            this.buttonMoveShape = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.buttonChanheSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PointX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PointY";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(590, 118);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(27, 13);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Move The Shape To";
            // 
            // textBoxPointX
            // 
            this.textBoxPointX.Location = new System.Drawing.Point(593, 35);
            this.textBoxPointX.Name = "textBoxPointX";
            this.textBoxPointX.Size = new System.Drawing.Size(136, 20);
            this.textBoxPointX.TabIndex = 5;
            // 
            // textBoxPointY
            // 
            this.textBoxPointY.Location = new System.Drawing.Point(593, 86);
            this.textBoxPointY.Name = "textBoxPointY";
            this.textBoxPointY.Size = new System.Drawing.Size(136, 20);
            this.textBoxPointY.TabIndex = 6;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(593, 134);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(136, 20);
            this.textBoxWidth.TabIndex = 7;
            // 
            // textBoxPosX
            // 
            this.textBoxPosX.Location = new System.Drawing.Point(622, 313);
            this.textBoxPosX.Name = "textBoxPosX";
            this.textBoxPosX.Size = new System.Drawing.Size(36, 20);
            this.textBoxPosX.TabIndex = 8;
            // 
            // textBoxPosY
            // 
            this.textBoxPosY.Location = new System.Drawing.Point(688, 313);
            this.textBoxPosY.Name = "textBoxPosY";
            this.textBoxPosY.Size = new System.Drawing.Size(36, 20);
            this.textBoxPosY.TabIndex = 9;
            // 
            // buttonCreateFigure
            // 
            this.buttonCreateFigure.Location = new System.Drawing.Point(593, 222);
            this.buttonCreateFigure.Name = "buttonCreateFigure";
            this.buttonCreateFigure.Size = new System.Drawing.Size(65, 35);
            this.buttonCreateFigure.TabIndex = 11;
            this.buttonCreateFigure.Text = "Create Figure";
            this.buttonCreateFigure.UseVisualStyleBackColor = true;
            this.buttonCreateFigure.Click += new System.EventHandler(this.buttonCreateFigure_Click);
            // 
            // buttonCloseFigure
            // 
            this.buttonCloseFigure.Location = new System.Drawing.Point(665, 222);
            this.buttonCloseFigure.Name = "buttonCloseFigure";
            this.buttonCloseFigure.Size = new System.Drawing.Size(64, 35);
            this.buttonCloseFigure.TabIndex = 12;
            this.buttonCloseFigure.Text = "Close Figure";
            this.buttonCloseFigure.UseVisualStyleBackColor = true;
            this.buttonCloseFigure.Click += new System.EventHandler(this.buttonCloseFigure_Click);
            // 
            // buttonMoveShape
            // 
            this.buttonMoveShape.Location = new System.Drawing.Point(612, 361);
            this.buttonMoveShape.Name = "buttonMoveShape";
            this.buttonMoveShape.Size = new System.Drawing.Size(100, 31);
            this.buttonMoveShape.TabIndex = 13;
            this.buttonMoveShape.Text = "Move Shape";
            this.buttonMoveShape.UseVisualStyleBackColor = true;
            this.buttonMoveShape.Click += new System.EventHandler(this.buttonMoveShape_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "X :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(662, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y :";
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(593, 189);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(137, 23);
            this.buttonChangeColor.TabIndex = 16;
            this.buttonChangeColor.Text = "Change Color";
            this.buttonChangeColor.UseMnemonic = false;
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // buttonChanheSize
            // 
            this.buttonChanheSize.Location = new System.Drawing.Point(654, 160);
            this.buttonChanheSize.Name = "buttonChanheSize";
            this.buttonChanheSize.Size = new System.Drawing.Size(75, 23);
            this.buttonChanheSize.TabIndex = 17;
            this.buttonChanheSize.Text = "button1";
            this.buttonChanheSize.UseVisualStyleBackColor = true;
            this.buttonChanheSize.Click += new System.EventHandler(this.buttonChanheSize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.buttonChanheSize);
            this.Controls.Add(this.buttonChangeColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMoveShape);
            this.Controls.Add(this.buttonCloseFigure);
            this.Controls.Add(this.buttonCreateFigure);
            this.Controls.Add(this.textBoxPosY);
            this.Controls.Add(this.textBoxPosX);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxPointY);
            this.Controls.Add(this.textBoxPointX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPointX;
        private System.Windows.Forms.TextBox textBoxPointY;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxPosX;
        private System.Windows.Forms.TextBox textBoxPosY;
        private System.Windows.Forms.Button buttonCreateFigure;
        private System.Windows.Forms.Button buttonCloseFigure;
        private System.Windows.Forms.Button buttonMoveShape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.Button buttonChanheSize;
    }
}

