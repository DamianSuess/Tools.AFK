using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Tools.Afk
{
  public partial class MainForm : Form
  {
    private Timer _timer = new Timer();

    private bool _moveMouse = true;
    private bool _pressKeys = true;
    private int _counter = 0;

    public MainForm()
    {
      InitializeComponent();

      _timer.Elapsed += OnTimerElapsed;

      EnableControls(true);
    }

    private void BtnStart_Click(object sender, EventArgs e)
    {

      _moveMouse = ChkSimMouse.Checked;
      _pressKeys = chkSimKeyPress.Checked;

      if (!_moveMouse && !_pressKeys)
      {
        MessageBox.Show("You must check either move mouse or press keys!");
        return;
      }

      EnableControls(false);

      var ms = TimeSpan.FromMinutes((int)UdInterval.Value).TotalMilliseconds;

      _timer.Interval = ms;
      _timer.Enabled = true;

      MoveCursor();
    }

    private void BtnStop_Click(object sender, EventArgs e)
    {
      _timer.Enabled = false;
      Cursor.Clip = new Rectangle();
      _counter = 0;

      EnableControls(true);
    }

    private void OnTimerElapsed(object sender, ElapsedEventArgs e)
    {
      IncrementCounter();

      if (_moveMouse)
        MoveCursor();

      if (_pressKeys)
        PerformKeyPress();
    }

    private void MoveCursor(bool boundToWindow = false)
    {
      var mainBounds = Screen.PrimaryScreen.Bounds;
      var winBouds = new Rectangle(this.Location, this.Size);

      // int minX = 0, minY = 0;
      int maxX = mainBounds.Width, maxY = mainBounds.Height;

      // Do we really need this?
      // this.Cursor = new Cursor(Cursor.Current.Handle);

      if (boundToWindow)
      {
        // Bound the position to this form's frame
        Cursor.Clip = winBouds;
      }

      // TODO: when hitting boundary, change direction
      ////var oldPos = Cursor.Position;
      ////var newPos = new Point(oldPos.X + 10, oldPos.Y);
      ////Cursor.Position = newPos;
      ////Thread.Sleep(100);
      ////Cursor.Position = oldPos;

      // Linear movement
      Cursor.Position = new Point(Cursor.Position.X - 1, Cursor.Position.Y - 1);
    }

    private void PerformKeyPress()
    {
      SendKeys.SendWait("{F15}");
    }

    private void EnableControls(bool enabled)
    {
      BtnStart.Enabled = enabled;
      BtnStop.Enabled = !enabled;
      UdInterval.Enabled = enabled;
    }

    private void IncrementCounter()
    {
      _counter++;
      LblCounter.Text = _counter.ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }
  }
}
