using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lass
{
    public partial class Form1 : Form
    {
        private bool drawFigures = false;
        private FilledCross cross;

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(this.Form1Paint);
        }

        private void Form1Paint(object sender, PaintEventArgs e)
        {
            if (drawFigures)
            {
                if (cross != null)
                {
                    cross.Show(e.Graphics);
                }
            }
            else
            {
                e.Graphics.Clear(BackColor);
            }
        }

        private void buttonCreateFigure_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxPointX.Text, out int x) ||
                !int.TryParse(textBoxPointY.Text, out int y) ||
                !int.TryParse(textBoxWidth.Text, out int size))
            {
                MessageBox.Show("Некорректные координаты или размер");
                return;
            }

            Color fillColor = buttonChangeColor.BackColor;
            cross = new FilledCross(x, y, fillColor, size, fillColor);
            drawFigures = true;

            this.Invalidate();
        }

        private void buttonCloseFigure_Click(object sender, EventArgs e)
        {
            cross = null;
            drawFigures = false;
            this.Invalidate();
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK)
            {
                buttonChangeColor.BackColor = color.Color;

                if (cross != null)
                {
                    cross.SetColor(buttonChangeColor.BackColor);
                    this.Invalidate();
                }
            }
        }

        private void buttonChanheSize_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxWidth.Text, out int size) || size <= 0 || cross == null)
            {
                MessageBox.Show("Проверьте корректность ввода данных");
                return;
            }

            if (cross != null)
            {
                cross.ChangeSide(size);
                this.Invalidate();
            }

            //this.Invalidate();
        }

        private void buttonMoveShape_Click(object sender, EventArgs e)
        {
            
        }
    }

    public abstract class Shapes
    {
        protected int x, y;
        protected Color c;
        private bool visible;
        protected int side;

        public Shapes(int x, int y, Color color, int side)
        {
            this.x = x; //координаты цвета
            this.y = y;
            this.c = color; // граница
            this.side = side;
            this.visible = false;
        }

        protected abstract void Draw(Graphics g);

        public void Move(int newX, int newY, Graphics g)
        {

            if (visible) Hide(g, Form1.DefaultBackColor);
            x = newX;
            y = newY;
            if (visible) Show(g);
        }

        public void Hide(Graphics g, Color backColor)
        {
            if (!visible) return;

            Area(out int x1, out int y1, out int x2, out int y2);

            g.FillRectangle(new SolidBrush(backColor), x1, y1, (x2 - x1), (y2 - y1));
            visible = false;
        }

        public abstract void Area(out int x1, out int y1, out int x2, out int y2);

        public abstract void ChangeSide(int side);

        public abstract void SetColor(Color NewColor);

        public void Show(Graphics g)
        {
            Draw(g);
            visible = true;
        }

        public Color GetBorderColor()
        {
            return c;
        }

        public bool IsVisible()
        {
            return visible;
        }

        public abstract void Update(Graphics g);
    }

    public class FilledCross : Shapes
    {
        private SolidBrush solidBrush;
        private float thick = 6;
        private float drift = 2.3f;

        public FilledCross(int x, int y, Color c, int side, Color fill) : base(x, y, c, side)
        {
            solidBrush = new SolidBrush(fill);
        }

        protected override void Draw(Graphics g)
        {
            g.FillRectangle(solidBrush, (float)x, y + side / drift, side, side / thick);
            g.FillRectangle(solidBrush, (float)x + side / drift, y, side / thick, side);
        }

        public override void Area(out int x1, out int y1, out int x2, out int y2)
        {
            x1 = x;
            y1 = y;
            x2 = x + side;
            y2 = y + side;
        }

        public override void ChangeSide(int side)
        {
            this.side = side;
        }

        public override void Update(Graphics g)
        {
            this.Hide(g, Form1.DefaultBackColor);
            this.Show(g);
        }

        public override void SetColor(Color newColor)
        {
            c = newColor;
            solidBrush.Color = newColor;
        }
    }

}

