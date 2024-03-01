using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Coursework
{

    public partial class dragAndDrop : Form
    {
        private Point MouseDownLocation;
        public static player activePlayer;
        private List<Panel> dropPoints;
        private List<Panel> draggables;
        private List<Label> dragTexts;
        private List<PictureBox> dragPictures;
        private List<PictureBox> dropPictures;
        public dragAndDrop(questionInfo currentQ, player activePassthrough)
        {
            InitializeComponent();

            Ready.timeKeeperInstance.TimeUpdated += TimerInstance_TimeUpdated;
            activePlayer = activePassthrough;
            questionText.Text = currentQ.question;

            Title.Text = $"Question Number: {currentQ.questionNo.ToString()}";
            timeLeft.Text = Ready.timeKeeperInstance.GetRemainingTimeInSeconds().ToString();

            Random rng = new Random();
            string[] randomisedDrags = currentQ.correct_answer.Split('-').OrderBy(x => Guid.NewGuid()).ToArray();
            string[] randomisedDrops = currentQ.correct_answer.Split('-').OrderBy(x => Guid.NewGuid()).ToArray();

            draggables = new List<Panel> { draggable1, draggable2, draggable3, draggable4 };
            dropPoints = new List<Panel> { dropPoint1, dropPoint2, dropPoint3, dropPoint4 };
            dragTexts = new List<Label> { dragLabel1, dragLabel2, dragLabel3, dragLabel4 };
            dragPictures = new List<PictureBox> { draggablePicture1, draggablePicture2, draggablePicture3, draggablePicture4 };
            dropPictures = new List<PictureBox> { dropPointPicture1, dropPointPicture2, dropPointPicture3, dropPointPicture4 };

            for (int x = 0; x <= 3; x++)
            {
                draggables[x].MouseDown += Draggable_MouseDown;
                try
                {
                    dragPictures[x].Image = new Bitmap(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DragDropImages"), $"{randomisedDrags[x]}.jpg"));
                    dragTexts[x].Hide();
                }
                catch
                {
                    // Inside the for loop
                    dragPictures[x].Hide();
                    dragTexts[x].Text = randomisedDrags[x];
                }
            }
            for (int x = 0; x <= 3; x++)
            {
                draggables[x].MouseDown += Draggable_MouseDown;
                dropPoints[x].DragEnter += DropPoint_DragEnter;
                dropPoints[x].DragDrop += DropPoint_DragDrop;
                dropPictures[x].Image = new Bitmap(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DragDropImages"), $"{randomisedDrags[x]}Answer.jpg"));
            }
            
        }


        private void Draggable_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;

            int offsetX = e.X;
            int offsetY = e.Y;

            control.DoDragDrop(control, DragDropEffects.Move);

            Point originalLocation = control.Location; // Store the original location of the control

            control.MouseMove += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    int newX = ee.X + control.Left - offsetX;
                    int newY = ee.Y + control.Top - offsetY;

                    control.Left = newX;
                    control.Top = newY;
                }
            };

            control.MouseUp += (ss, ee) =>
            {
                control.MouseMove -= (ss, ee) => { }; // Remove the mouse move event handler

                if (!IsDropped(control)) // Check if the control is dropped onto a drop point
                {
                    // If not dropped, return the control to its original location
                    control.Location = originalLocation;
                }
            };
        }

        bool IsDropped(Control control)
        {
            foreach (Panel dropPoint in dropPoints)
            {
                if (dropPoint.ClientRectangle.IntersectsWith(control.Bounds))
                {
                    return true;
                }
            }
            return false;
        }


        private void DropPoint_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Control)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DropPoint_DragDrop(object sender, DragEventArgs e)
        {
            Control control = (Control)e.Data.GetData(typeof(Control));
            Panel dropPoint = (Panel)sender;
            dropPoint.Controls.Add(control);
        }
        void TimerInstance_TimeUpdated(object sender, int remainingTimeInSeconds)
        {
            timeLeft.Text = remainingTimeInSeconds.ToString();
        }

        private void dragAndDrop_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dragAndDrop_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
