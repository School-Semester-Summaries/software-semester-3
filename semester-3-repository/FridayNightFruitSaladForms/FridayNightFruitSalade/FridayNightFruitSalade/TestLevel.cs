using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

// to do
// clean up code
// code solid and oop
// keep track of misses late's and early's

namespace FridayNightFruitSalade
{
    public partial class TestLevel : Form
    {

        // Fields
        const int ShiftSpeedLabel = 1;
        const int DeadLine = -99;
        int score = 0;
        int lateCounter = 0;
        int missCounter = 0;
        int earlyCounter = 0;
        ArrowCollection _arrowCollection;
        LabelCollection _labelCollection;
        SoundPlayer sP = new SoundPlayer(Properties.Resources.Ellare);

        // Methods
        public TestLevel()
        {
            InitializeComponent();
            _arrowCollection = new ArrowCollection();
            _labelCollection = new LabelCollection();
            AssembleAllArrows();
            CollectAllArrows();
            CollectAllLabels();
            _arrowCollection.SortAllLists();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left || keyData == Keys.D)
            {
                if (_arrowCollection.SortedLeftArrowList.Count > 0 && CheckCollision(PB_LeftArrow, _arrowCollection.SortedLeftArrowList[0]))
                {
                    CalculateScoreAndShow(PB_LeftArrow.Location.Y, _arrowCollection.SortedLeftArrowList[0].Location.Y, LBL_Left);
                    RemoveFirstValue(_arrowCollection.SortedLeftArrowList);
                }
                text += "LeftArrowAssemble(" + count + ");" + Environment.NewLine;
            }

            if (keyData == Keys.Up || keyData == Keys.F)
            {
                if (_arrowCollection.SortedUpArrowList.Count > 0 && CheckCollision(PB_UpArrow, _arrowCollection.SortedUpArrowList[0]))
                {
                    CalculateScoreAndShow(PB_UpArrow.Location.Y, _arrowCollection.SortedUpArrowList[0].Location.Y, LBL_Up);
                    RemoveFirstValue(_arrowCollection.SortedUpArrowList);
                }
                text += "UpArrowAssemble(" + count + ");" + Environment.NewLine;
            }

            if (keyData == Keys.Down || keyData == Keys.J)
            {
                if (_arrowCollection.SortedDownArrowList.Count > 0 && CheckCollision(PB_DownArrow, _arrowCollection.SortedDownArrowList[0]))
                {
                    CalculateScoreAndShow(PB_DownArrow.Location.Y, _arrowCollection.SortedDownArrowList[0].Location.Y, LBL_Down);
                    RemoveFirstValue(_arrowCollection.SortedDownArrowList);
                }
                text += "DownArrowAssemble(" + count + ");" + Environment.NewLine;
            }

            if (keyData == Keys.Right || keyData == Keys.K)
            {
                if (_arrowCollection.SortedRightArrowList.Count > 0 && CheckCollision(PB_RightArrow, _arrowCollection.SortedRightArrowList[0]))
                {
                    CalculateScoreAndShow(PB_RightArrow.Location.Y, _arrowCollection.SortedRightArrowList[0].Location.Y, LBL_Right);
                    RemoveFirstValue(_arrowCollection.SortedRightArrowList);
                }
                text += "RightArrowAssemble(" + count + ");" + Environment.NewLine;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        void CalculateScoreAndShow(int baseArrow, int movingArrow, Label label)
        {
            int distance = baseArrow - movingArrow;

            label.Location = new Point(label.Location.X, 37);
            if (distance <= 25 && distance >= -50)
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
            else if (distance > 25)
            {
                label.Text = "Late";
                label.BackColor = Color.DarkRed;
                label.ForeColor = Color.Red;
                label.Visible = Enabled;
            }
            else if (distance < -50)
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

        const int ShiftSpeedArrow = 9;
        const int StartLine = 0;
        void AssembleAllArrows()
        {
            // delta y 106



            //Patterns
            LeftArrowAssemble(3204);
            UpArrowAssemble(3267);
            DownArrowAssemble(3348);
            RightArrowAssemble(3429);
            DownArrowAssemble(3501);
            UpArrowAssemble(3573);
            LeftArrowAssemble(3627);
            UpArrowAssemble(3717);
            DownArrowAssemble(3798);
            RightArrowAssemble(3861);
            DownArrowAssemble(3933);
            UpArrowAssemble(4005);
            DownArrowAssemble(4086);

            RightArrowAssemble(5085);
            DownArrowAssemble(5175);
            RightArrowAssemble(5256);
            DownArrowAssemble(5319);
            UpArrowAssemble(5409);
            LeftArrowAssemble(5490);
            UpArrowAssemble(5580);
            DownArrowAssemble(5688);
            RightArrowAssemble(5742);
            DownArrowAssemble(5823);
            UpArrowAssemble(5895);
            LeftArrowAssemble(5994);

            LeftArrowAssemble(7047);
            UpArrowAssemble(7155);
            DownArrowAssemble(7236);
            RightArrowAssemble(7317);
            DownArrowAssemble(7398);
            UpArrowAssemble(7488);
            LeftArrowAssemble(7596);
            UpArrowAssemble(7695);
            DownArrowAssemble(7785);
            UpArrowAssemble(7866);
            DownArrowAssemble(7947);
            RightArrowAssemble(8010);
            DownArrowAssemble(8073);
            DownArrowAssemble(9027);
            RightArrowAssemble(9108);
            DownArrowAssemble(9171);
            UpArrowAssemble(9270);
            LeftArrowAssemble(9360);
            UpArrowAssemble(9468);
            DownArrowAssemble(9585);
            RightArrowAssemble(9648);
            DownArrowAssemble(9729);
            UpArrowAssemble(9801);
            LeftArrowAssemble(9873);
            DownArrowAssemble(9963);
            UpArrowAssemble(10026);
            DownArrowAssemble(10107);
            LeftArrowAssemble(11826);
            UpArrowAssemble(11907);
            DownArrowAssemble(12006);
            RightArrowAssemble(12078);
            DownArrowAssemble(12258);
            RightArrowAssemble(12321);
            DownArrowAssemble(12402);
            UpArrowAssemble(12465);
            LeftArrowAssemble(12546);
            UpArrowAssemble(12627);

            LeftArrowAssemble(12816);
            UpArrowAssemble(12816);
            DownArrowAssemble(12816);
            RightArrowAssemble(12816);

            DownArrowAssemble(13077);
            RightArrowAssemble(13167);
            DownArrowAssemble(13239);
            UpArrowAssemble(13320);
            LeftArrowAssemble(13392);
            UpArrowAssemble(13482);

            LeftArrowAssemble(13788);
            UpArrowAssemble(13788);
            DownArrowAssemble(13788);
            RightArrowAssemble(13788);

            RightArrowAssemble(14058);
            DownArrowAssemble(14157);
            UpArrowAssemble(14238);
            LeftArrowAssemble(14301);
            UpArrowAssemble(14400);
            DownArrowAssemble(14508);
            RightArrowAssemble(14571);
            DownArrowAssemble(14661);
            DownArrowAssemble(15012);
            UpArrowAssemble(15120);
            DownArrowAssemble(15264);
            RightArrowAssemble(15318);
            DownArrowAssemble(15408);
            UpArrowAssemble(15480);
            LeftArrowAssemble(15552);
            UpArrowAssemble(15642);
            DownArrowAssemble(15750);
            UpArrowAssemble(15876);
            DownArrowAssemble(15948);
            UpArrowAssemble(16020);
            DownArrowAssemble(16110);
            DownArrowAssemble(16254);
            UpArrowAssemble(16317);
            DownArrowAssemble(16407);
            LeftArrowAssemble(16497);
            UpArrowAssemble(16569);
            RightArrowAssemble(16695);
            DownArrowAssemble(16758);
            DownArrowAssemble(16866);
            UpArrowAssemble(17091);
            DownArrowAssemble(17172);
            UpArrowAssemble(17262);
            DownArrowAssemble(17289);
            LeftArrowAssemble(17415);
            RightArrowAssemble(17514);
            DownArrowAssemble(17586);
            UpArrowAssemble(17685);
            DownArrowAssemble(17775);
            DownArrowAssemble(18072);
            UpArrowAssemble(18162);
            RightArrowAssemble(18243);
            DownArrowAssemble(18324);
            LeftArrowAssemble(18423);
            UpArrowAssemble(18513);
            DownArrowAssemble(18621);
            UpArrowAssemble(18693);
            DownArrowAssemble(18783);
            DownArrowAssemble(19026);
            LeftArrowAssemble(19134);
            UpArrowAssemble(19242);
            RightArrowAssemble(19368);
            DownArrowAssemble(19431);
            UpArrowAssemble(19521);
            LeftArrowAssemble(19764);
            DownArrowAssemble(19854);
            UpArrowAssemble(19935);
            RightArrowAssemble(19998);


        }

        void LeftArrowAssemble(int yIndex)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(107, yIndex);
            pb.BackColor = Color.Green;
            pb.Image = Properties.Resources.LeftArrow;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(75, 75);
            Controls.Add(pb);
        }

        //void AssembleLeftArrow(int yIndex)
        //{
        //    PictureBox pb = new PictureBox();
        //    pb.Location = new Point(107, StartLine + (86 * yIndex));
        //    pb.BackColor = Color.Green;
        //    pb.Image = Properties.Resources.LeftArrow;
        //    pb.SizeMode = PictureBoxSizeMode.StretchImage;
        //    pb.Size = new Size(75, 75);
        //    Controls.Add(pb);
        //}

        void UpArrowAssemble(int yIndex)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(205, yIndex);
            pb.BackColor = Color.Red;
            pb.Image = Properties.Resources.UpArrow;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(75, 75);
            Controls.Add(pb);
        }

        void DownArrowAssemble(int yIndex)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(302, yIndex);
            pb.BackColor = Color.Magenta;
            pb.Image = Properties.Resources.DownArrow;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(75, 75);
            Controls.Add(pb);
        }

        void RightArrowAssemble(int yIndex)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(400, yIndex);
            pb.BackColor = Color.Blue;
            pb.Image = Properties.Resources.RightArrow;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(75, 75);
            Controls.Add(pb);
        }

        int count = 0;
        // Events
        private void TMR_ShiftControls_Tick(object sender, EventArgs e)
        {
            count += ShiftSpeedArrow;

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

        string text = "//Pattern" + Environment.NewLine;
        private void TestLevel_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText(@"C:\Users\kaan-\source\Git\FridayNightFruitSaladForms\FridayNightFruitSalade\FridayNightFruitSalade\Resources\Pattern.txt", text);
        }

        private void TestLevel_Load(object sender, EventArgs e)
        {
            sP.Play();
            TMR_ShiftPictureBoxes.Start();
        }
    }
}


//bugs notes dont die by themself
