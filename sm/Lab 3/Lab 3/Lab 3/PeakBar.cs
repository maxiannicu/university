using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab_3
{
    /// &lt;summary>
    /// Draw a progress image from two images.
    /// &lt;/summary>
    /// &lt;remarks>
    /// To use this control, add it to your form.
    /// Set the Max and Min properties to a sensible value for your task
    /// Set the ImageCompleted and ImageUncompleted images to the appropriate
    /// pictures. For example, set the Completed image to a full colour picture,
    /// and the Uncompleted image to a monochrome version.
    /// As your task progesses, set the Value proprty to the new status.
    /// Assuming Max is 100, Min is 0, and teh images are set as above, a
    /// gradual change of Value from 0 to 100 will convert the Monochrome 
    /// picture to full colour, showing the progress.
    /// &lt;/remarks>
    public class PeakBar : UserControl
    {
        #region Constructors

        /// &lt;summary>
        /// Construct a PeakBar instance
        /// &lt;/summary>
        public PeakBar()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            
        }

        #endregion

        #region Events

        #region Event Constructors

        #endregion

        #region Event Handlers

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            _linearGradientBrush = new LinearGradientBrush(
                new Point(0, 10),
                new Point(Width, 10),
                Color.Green,
                Color.Red
                );
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var graphics = e.Graphics;
            DoHorizontalImageReveal(graphics);
        }

        #endregion

        #endregion

        #region Private Methods

        /// &lt;summary>
        /// Draw an image as the bar component
        /// Reveal an image with the current value.
        /// I.e. If the uncompleted image is a monochrome version of the 
        /// completed image, then as the value increases, the progress bar 
        /// would fill with colour, but the images would not appear to move.
        /// &lt;/summary>
        /// &lt;param name="graphics">&lt;/param>
        private void DoHorizontalImageReveal(Graphics graphics)
        {
            var range = (max - min);
            var border = Width * value / range;
            
            graphics.FillRectangle(_linearGradientBrush,new Rectangle(0,0,Width,Height));
            graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(border,0,Width,Height));
        }

        #endregion

        #region Constants

        #endregion

        #region Fields

        #region Property Bases

        /// &lt;summary>
        /// Internal, minimum value for progress
        /// &lt;/summary>
        private int min;

        /// &lt;summary>
        /// Internal, current value of progress
        /// &lt;/summary>
        private int value = 50;

        /// &lt;summary>
        /// Internal, maximum value for progress
        /// &lt;/summary>
        private int max = 100;

        private SolidBrush _redBrush;
        private SolidBrush _greenBrush;
        private SolidBrush _yellowBrush;
        private LinearGradientBrush _linearGradientBrush;

        #endregion

        #endregion
        
        #region Visible Properties

        /// &lt;summary>
        /// Minimum value for progress
        /// &lt;/summary>
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Minimum value for progress")]
        [Category("Progress")]
        public int Min
        {
            get => min;
            set
            {
                min = value;
                Invalidate();
            }
        }

        /// &lt;summary>
        /// Current value of progress
        /// &lt;/summary>
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Current value of progress")]
        [Category("Progress")]
        public int Value
        {
            get => value;
            set
            {
                this.value = value;
                Invalidate();
            }
        }

        /// &lt;summary>
        /// Maximum value for progress
        /// &lt;/summary>
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Maximum value for progress")]
        [Category("Progress")]
        public int Max
        {
            get => max;
            set
            {
                max = value;
                Invalidate();
            }
        }

        #endregion

        #region Hide these properties

        /// &lt;summary>
        /// Hidden property, inherited from UserControl but irrelevant
        /// &lt;/summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool AllowDrop { get; set; }

        /// &lt;summary>
        /// Hidden property, inherited from UserControl but irrelevant
        /// &lt;/summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new AutoScaleMode AutoScaleMode { get; set; }

        /// &lt;summary>
        /// Hidden property, inherited from UserControl but irrelevant
        /// &lt;/summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool AutoScroll { get; set; }

        /// &lt;summary>
        /// Hidden property, inherited from UserControl but irrelevant
        /// &lt;/summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Size AutoScrollMargin { get; set; }

        /// &lt;summary>
        /// Hidden property, inherited from UserControl but irrelevant
        /// &lt;/summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Size AutoScrollMinSize { get; set; }

        /// &lt;summary>
        /// Hidden property, inherited from UserControl but irrelevant
        /// &lt;/summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool AutoSize { get; set; }

        /// &lt;summary>
        /// Hidden property, inherited from UserControl but irrelevant
        /// &lt;/summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new AutoSizeMode AutoSizeMode { get; set; }

        /// &lt;summary>
        /// Hidden property, inherited from UserControl but irrelevant
        /// &lt;/summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override AutoValidate AutoValidate { get; set; }

        /// &lt;summary>
        /// Hidden property, inherited from UserControl but irrelevant
        /// &lt;/summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ImageLayout BackgroundImageLayout { get; set; }

        /// &lt;summary>
        /// Hidden property, inherited from UserControl but irrelevant
        /// &lt;/summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ContextMenuStrip ContextMenuStrip { get; set; }

        /// &lt;summary>
        /// Hidden property, inherited from UserControl but irrelevant
        /// &lt;/summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override RightToLeft RightToLeft { get; set; }

        #endregion
        
    }
}