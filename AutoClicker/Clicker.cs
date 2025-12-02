using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace AutoClicker
{
    public struct Info
    {
        public bool Left;
        public bool Right;
        public bool Middle;

        public int Max;
        public bool Loop;
        public bool DoubleClick;

        public int Hours;
        public int Minutes;
        public int Seconds;
        public int Milliseconds;
    }

    public static class Clicker
    {
        private const int MOUSEEVENTF_LEFTDOWN = 0x2;
        private const int MOUSEEVENTF_LEFTUP = 0x4;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x8;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const int MOUSEEVENTF_MIDDLEUP = 0x40;

        private static CancellationTokenSource Cancellable { get; set; } = new();

        public static bool Running => Cancellable.IsCancellationRequested;

        public static Task Start(Info info) => Task.Run(async () =>
        {
            int index = 0;
            int interval = ComputeInterval(info);

            int clicks = 1;
            if (info.DoubleClick)
                clicks++;

            Cancellable.Dispose();
            Cancellable = new();

            while (info.Loop || index < info.Max)
            {
                if (Cancellable.IsCancellationRequested)
                    break;

                if (info.Left)
                {
                    for (int i = 0; i < clicks; i++)
                    {
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    }
                }
                if (info.Right)
                {
                    for (int i = 0; i < clicks; i++)
                    {
                        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                    }
                }
                if (info.Middle)
                {
                    for (int i = 0; i < clicks; i++)
                    {
                        mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
                    }
                }
                await Task.Delay(interval);
                index++;
            }
        });

        public static void Stop()
        {
            Cancellable.Cancel();
        }

        private static int ComputeInterval(Info info)
        {
            int hours = info.Hours *= 3600000;
            int minutes = info.Minutes *= 60000;
            int seconds = info.Seconds *= 1000;
            int milliseconds = info.Milliseconds;

            return hours + minutes + seconds + milliseconds;
        }

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
    }
}
