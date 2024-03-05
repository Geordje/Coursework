using Coursework.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        private List<System.Windows.Forms.Label> dragTexts;
        private List<PictureBox> dragPictures;
        private List<PictureBox> dropPictures;
        private Control currentDraggable;
        private Dictionary<Panel, Point> originalLocations = new Dictionary<Panel, Point>();
        private Dictionary<Panel, string> panelToRandomisedDrag = new Dictionary<Panel, string>();
        private Dictionary<Panel, string> dropPointToRandomisedDrop = new Dictionary<Panel, string>();
        private static int amountCorrect = 0;
        private static int guesses = 0;



        public dragAndDrop(questionInfo currentQ, player activePassthrough)
        {
            guesses = 0;
            amountCorrect = 0;
            InitializeComponent();
            Ready.timeKeeperInstance.TimeUpdated += TimerInstance_TimeUpdated;
            activePlayer = activePassthrough;
            questionText.Text = currentQ.question;

            Title.Text = $"Question: {currentQ.questionNo.ToString()}";
            timeLeft.Text = Ready.timeKeeperInstance.GetRemainingTimeInSeconds().ToString();

            Random rng = new Random();
            string[] randomisedDrags = currentQ.correct_answer.Split('-').OrderBy(x => Guid.NewGuid()).ToArray();
            string[] randomisedDrops = currentQ.correct_answer.Split('-').OrderBy(x => Guid.NewGuid()).ToArray();

            draggables = new List<Panel> { draggable1, draggable2, draggable3, draggable4 };

            dropPoints = new List<Panel> { dropPoint1, dropPoint2, dropPoint3, dropPoint4 };
            dragTexts = new List<System.Windows.Forms.Label> { dragLabel1, dragLabel2, dragLabel3, dragLabel4 };
            dragPictures = new List<PictureBox> { draggablePicture1, draggablePicture2, draggablePicture3, draggablePicture4 };
            dropPictures = new List<PictureBox> { dropPointPicture1, dropPointPicture2, dropPointPicture3, dropPointPicture4 };

            for (int x = 0; x <= 3; x++)
            {
                dropPoints[x].AllowDrop = true;
                dropPoints[x].DragOver += DropPoint_DragOver;
                originalLocations[draggables[x]] = draggables[x].Location;
                panelToRandomisedDrag[draggables[x]] = randomisedDrags[x];
                dropPointToRandomisedDrop[dropPoints[x]] = randomisedDrags[x];
                dropPictures[x].Image = new Bitmap(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DragDropImages"), $"{randomisedDrags[x]}Answer.jpg"));
                try
                {
                    dragPictures[x].Image = new Bitmap(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DragDropImages"), $"{randomisedDrags[x]}.jpg"));
                    dragTexts[x].Hide();
                }
                catch
                {
                    dragPictures[x].Hide();
                    dragTexts[x].Text = randomisedDrags[x];
                }
            }
        }
        private void DropPoint_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private bool IsDropped(Panel panel, Panel dropPoint)
        {
            Point centerPoint = new Point(panel.Left + panel.Width / 2, panel.Top + panel.Height / 2);
            return dropPoint.Bounds.Contains(centerPoint);
        }

        void TimerInstance_TimeUpdated(object sender, int remainingTimeInSeconds)
        {
            timeLeft.Text = remainingTimeInSeconds.ToString();
        }
        private void Draggable_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Panel panel = (Panel)sender;
                MouseDownLocation = e.Location;
                panel.Capture = true;
            }
        }

        private void Draggable_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Panel panel = (Panel)sender;
                panel.Left = e.X + panel.Left - MouseDownLocation.X;
                panel.Top = e.Y + panel.Top - MouseDownLocation.Y;
            }
        }

        private void Draggable_MouseUp(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.Capture = false;

            for (int i = 0; i < dropPoints.Count; i++)
            {
                var dropPoint = dropPoints[i];
                if (IsDropped(panel, dropPoint))
                {
                    if (panelToRandomisedDrag[panel] == dropPointToRandomisedDrop[dropPoint])
                    {
                        amountCorrect++;
                        if (amountCorrect == 2 || amountCorrect == 4)
                        {
                            activePlayer.Accumulate();
                        }
                        else
                        {
                            new System.Media.SoundPlayer(Resources.Correct_Ding).Play();
                        }
                        panel.Visible = false;
                        dropPictures[i].Image = new Bitmap(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DragDropImages"), $"{panelToRandomisedDrag[panel]}Correct.jpg"));
                    }
                    else
                    {
                        new System.Media.SoundPlayer(Resources.Incorrect).Play();
                        panel.Visible = false;
                    }
                    guesses++;
                    if (guesses == 4)
                    {
                        this.Close();
                        QuestionData.PlayQuestion(Ready.thisQuestionData, activePlayer);
                    }
                    return;
                }
            }

            panel.Location = originalLocations[panel];
        }
    }
}
