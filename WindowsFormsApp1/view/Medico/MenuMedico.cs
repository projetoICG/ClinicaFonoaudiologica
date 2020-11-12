﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace WindowsFormsApp1.view.Medico
{
    public partial class MenuMedico : Form
    {
       
        public MenuMedico()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            this.CenterToScreen();
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Red, Color.Black);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void campoIdade_Click(object sender, EventArgs e)
        {

        }

        private void campoDataNascimento_Click(object sender, EventArgs e)
        {
            int startPos = this.campoDataNascimento.MaskedTextProvider.FindUnassignedEditPositionFrom(this.campoDataNascimento.MaskedTextProvider.LastAssignedPosition + 1, true);
            this.campoDataNascimento.Select(startPos, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarMedico cadastrarmedico = new CadastrarMedico();
            
            cadastrarmedico.ShowDialog();
            atualizarLista();
        }
        private void atualizarLista()
        {
            
        }

        private void limparLista()
        {

        }
        private void MenuMedico_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("kk");
        }
    }
}
