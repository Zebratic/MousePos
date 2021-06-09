using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MousePosForm
{
    public partial class MousePos : Form
    {
        int MouseX = 0;
        int MouseY = 0;
        Panel XLine = new Panel();
        Panel YLine = new Panel();
        Panel MouseDot = new Panel();
        List<Panel> DrawingDots = new List<Panel>();
        Graphics DrawingArea;
        bool HeldDown = false;
        bool ReadyToReset = false;

        public MousePos()
        {
            InitializeComponent();

            #region Render properties
            XLine.BackColor = Color.Red; // Set XLine color
            YLine.BackColor = Color.Green; // Set YLine color
            MouseDot.Size = new Size(12, 12); // Set dot Size
            MouseDot.BackColor = Color.Blue; // Set dot color

            this.Controls.Add(XLine); // Add the line to the form
            this.Controls.Add(YLine); // Add the line to the form
            this.Controls.Add(MouseDot); // Add the dot to the form
            XLine.BringToFront(); // Put the line infront of the panel
            YLine.BringToFront(); // Put the line infront of the panel
            MouseDot.BringToFront(); // Put the dot infront of the panel
            #endregion

            this.DoubleBuffered = true; // Double buffered to increase performance and stop flickering
        }

        private void MouseRecorder_Tick(object sender, EventArgs e)
        {
            Point point = MouseArea.PointToClient(Cursor.Position); // Get mouse position and compare it to the panel's size
            MouseX = point.X; // Save the X position for this current tick
            MouseY = point.Y;// Save the Y position for this current tick

            #region Calculate Mouse Position Inside Panel
            if (MouseX <= 0) // if X Position is in negative numbers (its outside the panel) then set it to 0
                MouseX = 0;
            if (MouseY <= 0) // if Y Position is in negative numbers (its outside the panel) then set it to 0
                MouseY = 0;

            if (MouseX >= MouseArea.Size.Width) // if X position is greater than the panel's width, then set it to 0
                MouseX = 0;
            if (MouseY >= MouseArea.Size.Height) // if Y position is greater than the panel's height, then set it to 0
                MouseY = 0;

            if (MouseX == 0) // if X position is 0 (most likely been reset because it was outside the panel) then set the Y position to 0 aswell
                MouseY = 0;

            if (MouseY == 0) // if Y position is 0 (most likely been reset because it was outside the panel) then set the X position to 0 aswell
                MouseX = 0;
            #endregion

            #region Update Line Lengths
            XLine.Size = new Size(MouseArea.Width, 4); // set XLine Size
            YLine.Size = new Size(4, MouseArea.Height); // set YLine Size
            #endregion

            #region Render Lines
            if (MouseX != 0 && MouseY != 0) // Only render lines if both values are NOT 0 (aka mouse is inside the panel)
            {
                // remove the //'s if you want the lines to reappear when mouse is enters the panel again
                //XLine.Visible = true;
                //YLine.Visible = true;

                XLine.BackColor = Color.Red; // Make the lines normal coloured again
                YLine.BackColor = Color.Green; // Make the lines normal coloured again

                XLine.Location = new Point(MouseArea.Location.X, MouseY + 7); // Set the lines position to where ever the mouse position is (7, because of alignment failures)
                YLine.Location = new Point(MouseX + 7, MouseArea.Location.Y); // Set the lines position to where ever the mouse position is (7, because of alignment failures)
            }
            else
            {
                // remove the //'s if you want the lines to dissapear when mouse is outside the panel
                //XLine.Visible = false;
                //YLine.Visible = false;

                XLine.BackColor = Color.DarkRed; // Darken the dot's color
                YLine.BackColor = Color.DarkGreen; // Darken the dot's color
            }
            #endregion

            #region Render Dot
            if (MouseX != 0 && MouseY != 0) // Only render dot if both values are NOT 0 (aka mouse is inside the panel)
            {
                // remove the //'s if you want the dot to reappear when mouse is enters the panel again
                //MouseDot.Visible = true;

                MouseDot.BackColor = Color.Blue; // Make the lines normal coloured again

                MouseDot.Location = new Point(MouseX + 3, MouseY + 3); // Set the dot's position to where ever the mouse position is (7, because of alignment failures)
            }
            else
            {
                // remove the //'s if you want the dot to dissapear when mouse is outside the panel
                //MouseDot.Visible = false;

                MouseDot.BackColor = Color.DarkBlue; // Darken the dot's color
            }
            #endregion

            XPos.Text = MouseX.ToString(); // Display the Mouse's X position within the panel on a label
            YPos.Text = MouseY.ToString(); // Display the Mouse's Y position within the panel on a label

            DrawingArea = MouseArea.CreateGraphics(); // Update drawing area (if size change)
        }

        private void Drawer_Tick(object sender, EventArgs e)
        {
            if ((Control.MouseButtons & MouseButtons.Left) != 0 && MouseX != 0 && MouseY != 0) // Check if left mouse button is held down and if mouse is not outside the drawing area.
            {
                lblClickToDraw.Visible = false;
                HeldDown = true;
                ReadyToReset = true;
                #region Add dot
                Panel Dot = new Panel(); // Creates a new dot
                Dot.Size = new Size(4, 4); // Sets the dot size to 4x4 pixels big
                Dot.BackColor = Color.Cyan; // Sets the dot color to Cyan
                Dot.Location = new Point(MouseX + 7, MouseY + 7); // Sets the dot color to Cyan
                this.Controls.Add(Dot); // Add the new dot to the drawing area
                Dot.BringToFront(); // Bring the new dot on top of everything else
                DrawingDots.Add(Dot); // Add the new dot to the saved dot list
                #endregion
            }
            else
            {
                HeldDown = false;
            }

            if (!HeldDown && ReadyToReset)
            {
                Panel SpaceDot = new Panel(); // Creates a new invisible dot
                SpaceDot.Location = new Point(-69420, 0); // Sets the dot to the X position: -69420  (out of bounds)
                DrawingDots.Add(SpaceDot); // Add the invisible dot to the saved dot list
                ReadyToReset = false;
            }

            #region Connect to previous dot
            foreach (Panel ListDot in DrawingDots)
            {
                try
                {
                    this.Invalidate(); // Redraws all the previous added connected lines
                    Panel PreviousListDot = DrawingDots[DrawingDots.FindIndex(a => a == ListDot) - 1]; // Get the previous dot compared to the one in use
                    if (PreviousListDot.Location.X != -69420 && ListDot.Location.X != -69420) // Check if its not a space
                    {
                        Point P1 = new Point(ListDot.Location.X - 9, ListDot.Location.Y - 9); // Get the exact point of the current dot
                        Point P2 = new Point(PreviousListDot.Location.X - 9, PreviousListDot.Location.Y - 9); // Get the exact point of the previous dot
                        DrawingArea.DrawLine(new Pen(Color.Black, 1), P1, P2); // Draw a line connecting the current and previous dot
                    }
                }
                catch { }
            }
            #endregion

            #region Remove last added dot
            if (DrawingDots.Count >= MaxDotsAllowed.Value && MaxDotsAllowed.Value > 0)
            {
                this.Controls.Remove(DrawingDots[0]); // Remove the dot from the panel
                DrawingDots.RemoveAt(0); // Remove the first added dot from the list
                MouseArea.Refresh(); // Refreshes the drawing area to clean all the connected lines
            }
            #endregion
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Panel dot in DrawingDots) // For every saved dot
            {
                this.Controls.Remove(dot); // Remove the dot from the panel
            }
            MouseArea.Refresh(); // Refreshes the drawing area to clean all the connected lines
            DrawingDots.Clear(); // Clear all the saved dots
        }
    }
}