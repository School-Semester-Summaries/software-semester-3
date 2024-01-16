using System;
using System.Collections.Generic;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridayNightFruitSalade
{
    class ArrowCollection
    {
        // Properties
        public List<PictureBox> SortedLeftArrowList { get { return _sortedLeftArrowList; } }
        public List<PictureBox> UnsortedLeftArrowList = new List<PictureBox>();
        public List<PictureBox> SortedUpArrowList { get { return _sortedUpArrowList; } }
        public List<PictureBox> UnsortedUpArrowList = new List<PictureBox>();
        public List<PictureBox> SortedDownArrowList { get { return _sortedDownArrowList; } }
        public List<PictureBox> UnsortedDownArrowList = new List<PictureBox>();
        public List<PictureBox> SortedRightArrowList { get { return _sortedRightArrowList; } }
        public List<PictureBox> UnsortedRightArrowList = new List<PictureBox>();

        // Fields
        List<PictureBox> _sortedLeftArrowList = new List<PictureBox>();
        List<PictureBox> _sortedUpArrowList = new List<PictureBox>();
        List<PictureBox> _sortedDownArrowList = new List<PictureBox>();
        List<PictureBox> _sortedRightArrowList = new List<PictureBox>();

        // Methods
        // sorts pb with lowest y vlaue to first spot and highest to last spot
        public void SortAllLists()
        {
            SortList(UnsortedLeftArrowList, _sortedLeftArrowList);
            SortList(UnsortedUpArrowList, _sortedUpArrowList);
            SortList(UnsortedDownArrowList, _sortedDownArrowList);
            SortList(UnsortedRightArrowList, _sortedRightArrowList);
        }

        void SortList(List<PictureBox> unsortedList, List<PictureBox> sortedList)
        {
            while (unsortedList.Count > 0)
            {
                PictureBox pictureBoxWithLowestY = new PictureBox();
                pictureBoxWithLowestY.Location = new Point(0, int.MaxValue);

                foreach (PictureBox pb in unsortedList)
                {
                    if (pb.Location.Y < pictureBoxWithLowestY.Location.Y)
                    {
                        pictureBoxWithLowestY = pb;
                    }
                }
                sortedList.Add(pictureBoxWithLowestY);
                unsortedList.Remove(pictureBoxWithLowestY);
            }
        }
    }
}
