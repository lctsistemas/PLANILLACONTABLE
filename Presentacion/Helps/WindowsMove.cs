using System.Runtime.InteropServices;

namespace Presentacion.Helps
{
    public class WindowsMove
    {
        //PARA MOVER EL FORMULARIO
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
    }
}
