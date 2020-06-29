using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace FrameControl
{

    public partial class MoveTB : UserControl
    {
        public event Action<object, EventArgs> MClick;

        public event Action<object, KeyEventArgs> MKeyDown;
        enum MousePosOnCtrl
        {
            NONE = 0,
            TOP = 1,
            RIGHT = 2,
            BOTTOM = 3,
            LEFT = 4,
            TOPLEFT = 5,
            TOPRIGHT = 6,
            BOTTOMLEFT = 7,
            BOTTOMRIGHT = 8,
        }

        Dictionary<Panel, MousePosOnCtrl> _dictPanl = new Dictionary<Panel, MousePosOnCtrl>();
        MousePosOnCtrl _mpoc;  //鼠标在控件中位置
        const int MinWidth = 20; //最小宽度
        const int MinHeight = 20;//最小高度

        public ShowTB TextBox
        {
            get { return this.textBox1; }
            set { this.textBox1 = value; }
        }

        public MoveTB()
        {
            InitializeComponent();
            _dictPanl[this.panelTL] = MousePosOnCtrl.TOPLEFT;
            _dictPanl[this.panelT] = MousePosOnCtrl.TOP;
            _dictPanl[this.panelTR] = MousePosOnCtrl.TOPRIGHT;
            _dictPanl[this.panelL] = MousePosOnCtrl.LEFT;
            _dictPanl[this.panelR] = MousePosOnCtrl.RIGHT;
            _dictPanl[this.panelBL] = MousePosOnCtrl.BOTTOMLEFT;
            _dictPanl[this.panelB] = MousePosOnCtrl.BOTTOM;
            _dictPanl[this.panelBR] = MousePosOnCtrl.BOTTOMRIGHT;
            foreach (var kv in _dictPanl)
            {
                kv.Key.BringToFront();
                kv.Key.MouseMove += Panel_MouseMove;
                kv.Key.MouseLeave += Panel_MouseLeave;
                kv.Key.MouseDown += Panel_MouseDown;
            }
            Tools.SetControlEnabled(this.textBox1, false);
            boundVisible(false);
        }


        Point _lastLocation; //上个鼠标坐标
        Size _lastSize;
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            _lastMousePoint = Cursor.Position;
            _lastLocation = this.Location;
            _lastSize = this.Size;
        }

        bool SetCursorShape(int x, int y)
        {
            switch (_mpoc)
            {
                case MousePosOnCtrl.TOPLEFT:
                case MousePosOnCtrl.BOTTOMRIGHT:
                    Cursor.Current = Cursors.SizeNWSE;  //左上
                    break;
                case MousePosOnCtrl.TOPRIGHT:
                case MousePosOnCtrl.BOTTOMLEFT:
                    Cursor.Current = Cursors.SizeNESW;  //右上
                    break;
                case MousePosOnCtrl.TOP:
                case MousePosOnCtrl.BOTTOM:
                    Cursor.Current = Cursors.SizeNS;  //上
                    break;
                case MousePosOnCtrl.LEFT:
                case MousePosOnCtrl.RIGHT:
                    Cursor.Current = Cursors.SizeWE;  //左
                    break;
                default:
                    Cursor.Current = Cursors.SizeAll;
                    break;
            }
            return true;
        }

        void ControlMove()
        {
            Point currMousePoint = Cursor.Position;
            int x = currMousePoint.X - _lastMousePoint.X;
            int y = currMousePoint.Y - _lastMousePoint.Y;
            switch (this._mpoc)
            {
                case MousePosOnCtrl.TOP:
                    this.Top = _lastLocation.Y + y;
                    this.Height = _lastSize.Height - y;
                    Cursor.Current = Cursors.SizeNS;  //上
                    break;
                case MousePosOnCtrl.BOTTOM:
                    this.Height = _lastSize.Height + y;
                    Cursor.Current = Cursors.SizeNS;  //上
                    break;
                case MousePosOnCtrl.LEFT:
                    this.Left = _lastLocation.X + x;
                    this.Width = _lastSize.Width - x;
                    Cursor.Current = Cursors.SizeWE;  //左
                    break;
                case MousePosOnCtrl.RIGHT:
                    this.Width = _lastSize.Width + x;
                    Cursor.Current = Cursors.SizeWE;  //左
                    break;
                case MousePosOnCtrl.TOPLEFT:
                    this.Top = _lastLocation.Y + y;
                    this.Height = _lastSize.Height - y;
                    this.Left = _lastLocation.X + x;
                    this.Width = _lastSize.Width - x;
                    Cursor.Current = Cursors.SizeNWSE;  //左上
                    break;
                case MousePosOnCtrl.TOPRIGHT:
                    this.Top = _lastLocation.Y + y;
                    this.Height = _lastSize.Height - y;
                    this.Width = _lastSize.Width + x;
                    Cursor.Current = Cursors.SizeNESW;  //右上
                    break;
                case MousePosOnCtrl.BOTTOMLEFT:
                    this.Height = _lastSize.Height + y;
                    this.Left = _lastLocation.X + x;
                    this.Width = _lastSize.Width - x;
                    Cursor.Current = Cursors.SizeNESW;  //右上
                    break;
                case MousePosOnCtrl.BOTTOMRIGHT:
                    this.Width = _lastSize.Width + x;
                    this.Height = _lastSize.Height + y;
                    Cursor.Current = Cursors.SizeNWSE;  //左上
                    break;
                default:
                    Cursor.Current = Cursors.SizeAll;
                    break;

            }
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            _mpoc = MousePosOnCtrl.NONE;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Panel p = sender as Panel;
            _mpoc = _dictPanl[p];
            SetCursorShape(e.X, e.Y);
            if (e.Button == MouseButtons.Left)
            {
                ControlMove();
            }
        }

        void boundVisible(bool isVisible)
        {
            this.panelContain.BorderStyle = isVisible ? BorderStyle.FixedSingle : BorderStyle.None;
            foreach (var kv in _dictPanl)
            {
                kv.Key.Visible = isVisible;
            }
        }

        bool _tbEnable = false;
        public void SetFocus(bool focus)
        {
            boundVisible(focus);
            if (!focus)
            {
                if (_tbEnable)
                {
                    Tools.SetControlEnabled(this.textBox1, false);
                    _tbEnable = false;
                }
            }
        }

        private void UserControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!_tbEnable)
            {
                Tools.SetControlEnabled(this.textBox1, true);
                _tbEnable = true;
            }
            boundVisible(false);
        }

        Point _lastMousePoint; //上个鼠标坐标
        private void MoveCtr_MouseDown(object sender, MouseEventArgs e)
        {
            boundVisible(true);
            _lastMousePoint = Cursor.Position;
            if (MClick != null)
            {
                MClick(this, e);
            }
        }

        private void MoveCtr_MouseMove(object sender, MouseEventArgs e)
        {
            Point curPoint = Cursor.Position;
            if (e.Button == MouseButtons.Left)
            {
                if (_mpoc == MousePosOnCtrl.NONE)
                {
                    Cursor.Current = Cursors.SizeAll;
                    int x = curPoint.X - _lastMousePoint.X;
                    int y = curPoint.Y - _lastMousePoint.Y;
                    this.Location = new Point(this.Location.X + x, this.Location.Y + y);
                    _lastMousePoint = curPoint;
                    this.BringToFront();
                }
            }
        }

        private void MoveTB_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    this.Top += 1;
                    break;
                case Keys.Down:
                    this.Top -= 1;
                    break;
                case Keys.Left:
                    this.Left -= 1;
                    break;
                case Keys.Right:
                    this.Left += 1;
                    break;
            }
            if (MKeyDown != null)
            {
                MKeyDown(this, e);
            }
        }

        private void MoveTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("R");
        }

        public MoveTB Copy()
        {
            MoveTB moveTB = new MoveTB();
            moveTB.TextBox.Font = this.textBox1.Font;
            moveTB.TextBox.ForeColor = this.textBox1.ForeColor;
            moveTB.TextBox.BackColor = this.textBox1.BackColor;
            moveTB.TextBox.Text = this.textBox1.Text;
            moveTB.TextBox.Code = this.textBox1.Code;
            moveTB.TextBox.CodeType = this.textBox1.CodeType;
            moveTB.BackgroundImage = this.BackgroundImage;
            return moveTB;
        }

        private void textBox1_CodeTypeChange(object obj)
        {
            switch (this.textBox1.CodeType)
            {
                case CodeType.无:
                    {
                        this.BackgroundImage = null;
                    }
                    break;
                case CodeType.一维码:
                    {
                        this.Text = "";
                        Image image = Tools.CreateQuickMark(this.Width, this.Height, this.textBox1.Code, BarcodeFormat.CODE_128);
                        this.BackgroundImage = Tools.ResizeImage(image, new Size(this.Width, this.Height));
                    }
                    break;
                case CodeType.二维码:
                    {
                        this.Text = "";
                        Image image = Tools.CreateQuickMark(this.Width, this.Height, this.textBox1.Code, BarcodeFormat.QR_CODE);
                        this.BackgroundImage = Tools.ResizeImage(image, new Size(this.Width, this.Height));
                    }
                    break;
            }

        }
    }
}
