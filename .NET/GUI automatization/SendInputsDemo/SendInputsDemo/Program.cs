using System;
using System.Threading;

namespace SendInputsDemo
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Script started!");

            // // If we want to click a special (extended) key like Volume up
            // // We need to send to inputs with ExtendedKey and Scancode flags
            // // First is 0xe0 and the second is the special key scancode we want
            // // You can read more on that here -> https://www.win.tue.nl/~aeb/linux/kbd/scancodes-6.html#microsoft
            // InputSender.SendKeyboardInput(new InputSender.KeyboardInput[]
            // {
            //     new InputSender.KeyboardInput
            //     {
            //         wScan = 0xe0,
            //         dwFlags = (uint)(InputSender.KeyEventF.ExtendedKey | InputSender.KeyEventF.Scancode),
            //     },
            //     new InputSender.KeyboardInput
            //     {
            //         wScan = 0x30,
            //         dwFlags = (uint)(InputSender.KeyEventF.ExtendedKey | InputSender.KeyEventF.Scancode)
            //     }
            // });  // Volume +

            // Using our ClickKey wrapper to press W
            // To see more scancodes see this site -> https://www.win.tue.nl/~aeb/linux/kbd/scancodes-1.html
            // InputSender.ClickKey(0x11); // W

            // InputSender.test();

            // // Setting the cursor position
            // InputSender.SetCursorPosition(100, 100);
            // Thread.Sleep(2000);

            // Thread.Sleep(1000);


            // Thread.Sleep(1000);

            // // Setting the cursor position RELATIVE to the current position
            // InputSender.SendMouseInput(new InputSender.MouseInput[]
            // {
            //     new InputSender.MouseInput
            //     {
            //         dx = -600,
            //         dy = 0,
            //         dwFlags = (uint)InputSender.MouseEventF.Move
            //     }
            // });

// ========================================

            // Util.MonitorCursorPos();

            for(int i = 0; i < 30; i++){
                Recipes.Marigold_decotion();
            }

// ========================================

            System.Console.WriteLine("Script ended!");
        }
    }
}
