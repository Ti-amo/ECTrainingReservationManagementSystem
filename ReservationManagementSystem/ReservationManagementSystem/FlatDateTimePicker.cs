using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class FlatDateTimePicker : DateTimePicker
    {
        [DllImport("user32.dll", EntryPoint = "sendMessageA")]
        private static extern int SendMessege(IntPtr hwnd, int wMsg, IntPtr wParam, object lParam);
        [DllImport("user32")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);

        [DllImport("user32")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        const int WM_PAINT = 0xF;
        const int WM_NC_PAINT = 0x85;
        public Color BorderColor { get; set; }
        protected override void WndProc(ref Message m)
        {
            IntPtr hDC = IntPtr.Zero;
            Graphics gdc = null;
            switch (m.Msg)
            {
                case WM_NC_PAINT:
                    hDC = GetWindowDC(m.HWnd);
                    gdc = Graphics.FromHdc(hDC);
                    ControlBorder(gdc, BorderColor);
                    m.Result = (IntPtr)1;
                    ReleaseDC(m.HWnd, hDC);
                    gdc.Dispose();
                    break;

                case WM_PAINT:
                    base.WndProc(ref m);
                    hDC = GetWindowDC(m.HWnd);
                    gdc = Graphics.FromHdc(hDC);
                    ControlBorder(gdc, BorderColor);
                    ReleaseDC(m.HWnd, hDC);
                    gdc.Dispose();
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void ControlBorder(Graphics gdc, Color borderColor)
        {
            gdc.DrawRectangle(new Pen(borderColor, 2), new Rectangle(0, 0, this.Width, this.Height));
        }
    }
}