using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUO
{
    public class TablesLayout
    {
        public TablesLayout()
        {

        }

        public void setTablesLayout(TableLayoutPanel table, MainPlayer player)
        {
            //The maximum amount of cards
            table.ColumnCount = 9;
            table.RowCount = 2;
            for (int i = 0; i < player.Cartes.Count; i++)
            {
                ImageList imagelist1 = new ImageList();
                imagelist1.ImageSize = new Size(81, 124);
                string from = "Images/" + player.Cartes[i] + ".png";
                imagelist1.Images.Add(Image.FromFile(from));
                Button cmdImage = new Button();
                cmdImage.BackgroundImage = imagelist1.Images[0];
                cmdImage.Text = "";
                cmdImage.Size = new Size(81, 124);
                cmdImage.Anchor = AnchorStyles.None;
                cmdImage.Cursor = Cursors.Hand;
                if (i >= 9)
                {
                    table.Controls.Add(cmdImage, (i - 9), 1);
                }
                else
                {
                    table.Controls.Add(cmdImage, i, 0);
                }
            }
            //Pour arranger les tablelayout pour que tout fonctionne
            table.ColumnStyles.Clear();
            for (int i = 0; i < table.ColumnCount; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            table.RowStyles.Clear();
            for (int i = 0; i < table.RowCount; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }

        public void setTablesLayoutHorizontal(TableLayoutPanel table)
        {
            table.ColumnCount = 9;
            table.RowCount = 2;
            for (int i = 0; i < 18; i++)
            {
                Button cmdImage = new Button();
                cmdImage.BackgroundImage = Properties.Resources.unoVersoVertical;
                cmdImage.BackgroundImageLayout = ImageLayout.Stretch;
                cmdImage.Text = "";
                cmdImage.Size = new Size(81, 124);
                cmdImage.Anchor = AnchorStyles.None;
                cmdImage.Enabled = false;
                if (i >= 9)
                {
                    table.Controls.Add(cmdImage, (i - 9), 1);
                }
                else
                {
                    table.Controls.Add(cmdImage, i, 0);
                }
            }
            //Pour arranger les tablelayout pour que tout fonctionne
            table.ColumnStyles.Clear();
            for (int i = 0; i < table.ColumnCount; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            table.RowStyles.Clear();
            for (int i = 0; i < table.RowCount; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }

        public void setTablesLayoutVertical(TableLayoutPanel table)
        {
            table.ColumnCount = 2;
            table.RowCount = 9;
            for (int i = 0; i < 18; i++)
            {
                Button cmdImage = new Button();
                cmdImage.BackgroundImage = Properties.Resources.unoVersoHorizontal;
                cmdImage.BackgroundImageLayout = ImageLayout.Stretch;
                cmdImage.Text = "";
                cmdImage.Size = new Size(124, 81);
                cmdImage.Anchor = AnchorStyles.None;
                cmdImage.Enabled = false;
                if (i >= 9)
                {
                    table.Controls.Add(cmdImage, 0, (i - 9));
                }
                else
                {
                    table.Controls.Add(cmdImage, 1, i);
                }
            }
            //Pour arranger les tablelayout pour que tout fonctionne
            table.ColumnStyles.Clear();
            for (int i = 0; i < table.ColumnCount; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            table.RowStyles.Clear();
            for (int i = 0; i < table.RowCount; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }
    }
}
