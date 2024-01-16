using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridayNightFruitSalade
{
    public partial class FRM_Game : Form
    {
        // Fields
        const int ShiftSpeedArrow = 3;
        const int ShiftSpeedLabel = 1;
        const int DeadLine = -99;
        int score = 0;
        ArrowCollection _arrowCollection;
        LabelCollection _labelCollection;

        // Methods
        public FRM_Game()
        {
            InitializeComponent();
            _arrowCollection = new ArrowCollection();
            _labelCollection = new LabelCollection();
            CollectAllArrows();
            CollectAllLabels();
            _arrowCollection.SortAllLists();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left || keyData == Keys.D)
            {
                if (CheckCollision(PB_LeftArrow, _arrowCollection.SortedLeftArrowList[0]))
                {
                    CalculateScoreAndShow(PB_LeftArrow.Location.Y, _arrowCollection.SortedLeftArrowList[0].Location.Y, LBL_Left);
                    RemoveFirstValue(_arrowCollection.SortedLeftArrowList);
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }

            if (keyData == Keys.Up || keyData == Keys.F)
            {
                if (CheckCollision(PB_UpArrow, _arrowCollection.SortedUpArrowList[0]))
                {
                    CalculateScoreAndShow(PB_UpArrow.Location.Y, _arrowCollection.SortedUpArrowList[0].Location.Y, LBL_Up);
                    RemoveFirstValue(_arrowCollection.SortedUpArrowList);
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }

            if (keyData == Keys.Down || keyData == Keys.J)
            {
                if (CheckCollision(pictureBox54, _arrowCollection.SortedDownArrowList[0]))
                {
                    CalculateScoreAndShow(PB_DownArrow.Location.Y, _arrowCollection.SortedDownArrowList[0].Location.Y, LBL_Down);
                    RemoveFirstValue(_arrowCollection.SortedDownArrowList);
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }

            if (keyData == Keys.Right || keyData == Keys.K)
            {
                if (CheckCollision(pictureBox654, _arrowCollection.SortedRightArrowList[0]))
                {
                    CalculateScoreAndShow(PB_RightArrow.Location.Y, _arrowCollection.SortedRightArrowList[0].Location.Y, LBL_Right);
                    RemoveFirstValue(_arrowCollection.SortedRightArrowList);
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }

            if (keyData == Keys.Enter)
            {
                TMR_ShiftPictureBoxes.Start();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        void CalculateScoreAndShow(int baseArrow, int movingArrow, Label label)
         {
            int distance = baseArrow - movingArrow;

            label.Location = new Point(label.Location.X, 37);
            if (distance <= 14 && distance >= -14)
            {
                label.Text = "Good";
                label.BackColor = Color.Green;
                label.ForeColor = Color.Cyan;
                label.Visible = Enabled;
                score++;
            }
            else if (distance >= 99)
            {
                label.Text = "Miss";
                label.BackColor = Color.DarkRed;
                label.ForeColor = Color.Red;
                label.Visible = Enabled;
                score--;
            }
            else if (distance > 14)
            {
                label.Text = "Late";
                label.BackColor = Color.DarkRed;
                label.ForeColor = Color.Red;
                label.Visible = Enabled;
            }
            else if (distance < -14)
            {
                label.Text = "Early";
                label.BackColor = Color.DarkRed;
                label.ForeColor = Color.Red;
                label.Visible = Enabled;
            }
        }

        void RemoveFirstValue(List<PictureBox> pictureBoxList)
        {
            Controls.Remove(pictureBoxList[0]);
            pictureBoxList.RemoveAt(0);
        }

        bool CheckCollision(PictureBox Ctrl_One, PictureBox Ctrl_Two)
        {
            return (Ctrl_One.Bounds.IntersectsWith(Ctrl_Two.Bounds));
        }

        private void CollectAllLabels()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.Name.Contains("LBL"))
                {
                    _labelCollection.LabelList.Add((Label)ctrl);
                }
            }
        }

        void CollectAllArrows()
        {
            CollectAllLeftArrows();
            CollectAllUpArrows();
            CollectAllDownArrows();
            CollectAllRightArrows();
        }

        void CollectAllLeftArrows()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.BackColor == Color.Green)
                {
                    _arrowCollection.UnsortedLeftArrowList.Add((PictureBox)ctrl);
                }
            }
        }

        void CollectAllUpArrows()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.BackColor == Color.Red)
                {
                    _arrowCollection.UnsortedUpArrowList.Add((PictureBox)ctrl);
                }
            }
        }

        void CollectAllDownArrows()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.BackColor == Color.Magenta)
                {
                    _arrowCollection.UnsortedDownArrowList.Add((PictureBox)ctrl);
                }
            }
        }

        void CollectAllRightArrows()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.BackColor == Color.Blue)
                {
                    _arrowCollection.UnsortedRightArrowList.Add((PictureBox)ctrl);
                }
            }
        }


        // Events
        private void TMR_ShiftControls_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox pb in _arrowCollection.SortedLeftArrowList)
            {
                pb.Location = new Point(pb.Location.X, pb.Location.Y - ShiftSpeedArrow);
            }
            if (_arrowCollection.SortedLeftArrowList.Count > 0 && _arrowCollection.SortedLeftArrowList[0].Location.Y <= DeadLine)
            {
                CalculateScoreAndShow(PB_LeftArrow.Location.Y, _arrowCollection.SortedLeftArrowList[0].Location.Y, LBL_Left);
                RemoveFirstValue(_arrowCollection.SortedLeftArrowList);
            }

            foreach (PictureBox pb in _arrowCollection.SortedUpArrowList)
            {
                pb.Location = new Point(pb.Location.X, pb.Location.Y - ShiftSpeedArrow);
            }
            if (_arrowCollection.SortedUpArrowList.Count > 0 && _arrowCollection.SortedUpArrowList[0].Location.Y <= DeadLine)
            {
                CalculateScoreAndShow(PB_UpArrow.Location.Y, _arrowCollection.SortedUpArrowList[0].Location.Y, LBL_Up);
                RemoveFirstValue(_arrowCollection.SortedUpArrowList);
            }

            foreach (PictureBox pb in _arrowCollection.SortedDownArrowList)
            {
                pb.Location = new Point(pb.Location.X, pb.Location.Y - ShiftSpeedArrow);
            }
            if (_arrowCollection.SortedDownArrowList.Count > 0 && _arrowCollection.SortedDownArrowList[0].Location.Y <= DeadLine)
            {
                CalculateScoreAndShow(PB_DownArrow.Location.Y, _arrowCollection.SortedDownArrowList[0].Location.Y, LBL_Down);
                RemoveFirstValue(_arrowCollection.SortedDownArrowList);
            }

            foreach (PictureBox pb in _arrowCollection.SortedRightArrowList)
            {
                pb.Location = new Point(pb.Location.X, pb.Location.Y - ShiftSpeedArrow);
            }
            if (_arrowCollection.SortedRightArrowList.Count > 0 && _arrowCollection.SortedRightArrowList[0].Location.Y <= DeadLine)
            {
                CalculateScoreAndShow(PB_RightArrow.Location.Y, _arrowCollection.SortedRightArrowList[0].Location.Y, LBL_Right);
                RemoveFirstValue(_arrowCollection.SortedRightArrowList);
            }

            foreach (Label lbl in _labelCollection.LabelList)
            {
                lbl.Location = new Point(lbl.Location.X, lbl.Location.Y - ShiftSpeedLabel);
            }

            lblScore.Text = "Score: " + score.ToString();
        }

        private void FRM_Game_Load(object sender, EventArgs e)
        {
            //TMR_ShiftPictureBoxes.Start();
        }
    }
}

//bugs notes dont die by themself
