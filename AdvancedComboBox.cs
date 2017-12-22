using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionHeckingCode
{
    public class AdvancedComboBox : ComboBox
    {
        public new DrawMode DrawMode { get; set; }
        public Color HighlightColor { get; set; }

        public AdvancedComboBox()
        {
            base.DrawMode = DrawMode.OwnerDrawFixed;
            DrawItem += AdvancedComboBox_DrawItem;
        }

        private void AdvancedComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            var comboBox = sender as ComboBox;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(HighlightColor), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(comboBox.BackColor), e.Bounds);
            }

            e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), e.Font,
                new SolidBrush(comboBox.ForeColor),
                new Point(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }
    }
}
