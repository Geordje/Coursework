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
        public dragAndDrop(questionInfo currentQ, player activePassthrough)
        {
            InitializeComponent();

            Ready.timeKeeperInstance.TimeUpdated += TimerInstance_TimeUpdated;
            activePlayer = activePassthrough;
            questionText.Text = currentQ.question;

            Title.Text = $"Question Number: {currentQ.questionNo}";
            timeLeft.Text = Ready.timeKeeperInstance.GetRemainingTimeInSeconds().ToString();

            Random rng = new Random();
            string[] randomisedDrags = currentQ.correct_answer.Split('-').OrderBy(x => Guid.NewGuid()).ToArray();

            var draggables = new List<Panel> { draggable1, draggable2, draggable3, draggable4 };
            var dropPoints = new List<Panel> { dropPoint1, dropPoint2, dropPoint3, dropPoint4 };
            var dragTexts = new List<Label> { dragLabel1, dragLabel2, dragLabel3, dragLabel4 };
            var draggPictures = new List<PictureBox> { draggablePicture1, draggablePicture2, draggablePicture3, draggablePicture4 };
            var dropPictures = new List<PictureBox> { dropPointPicture1, dropPointPicture2, dropPointPicture3, dropPointPicture4 };

            for (int x = 0; x <= 4; x++)
            {
                draggables[x].MouseDown += Draggable_MouseDown;
                try
                {
                    draggPictures[x].Image = new Bitmap(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DragDropImages"), $"{randomisedDrags[x]}.jpg"));
                    dragTexts[x].Hide();
                    draggPictures[x].BackgroundImageLayout = ImageLayout.Zoom;
                }
                catch
                {
                    // Inside the for loop
                    draggPictures[x].Hide();
                    dragTexts[x].Text = randomisedDrags[x];
                }
            }
            for (int x = 0; x <= 4; x++)
            {
                dropPoints[x].DragEnter += DropPoint_DragEnter;
                dropPoints[x].DragDrop += DropPoint_DragDrop;
                dropPoints[x].BackColor = Color.White;
                dropPictures[x].Image = new Bitmap(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DragDropImages"), $"{randomisedDrags[x]}Answer.jpg"));
            }
            
        }


        private void Draggable_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.DoDragDrop(control, DragDropEffects.Move);
            control.MouseMove += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    control.Left = ee.X + control.Left - MouseDownLocation.X;
                    control.Top = ee.Y + control.Top - MouseDownLocation.Y;
                }
            };
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
    }
}
