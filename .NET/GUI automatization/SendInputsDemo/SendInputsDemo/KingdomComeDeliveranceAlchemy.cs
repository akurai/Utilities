using System;
using System.Threading;

namespace SendInputsDemo
{
    public class Recipes
    {
        public static void Marigold_decotion()
        {
            Inventory.FirstTwo();
            Util.Calibrate();
            Base.Water();
            Herbs.First();
            Herbs.First();
            Herbs.Second();
            Store.Phial();
        }
    }

    public class Base
    {
        public static void Water()
        {
            Util.GetCursorPos();
            int x1 = -640;
            int y1 = -210;
            int x2 = 594;
            int y2 = 208;
            int stepNumber = 50;

            Util.MoveEaseRelative(x1,y1, stepNumber, 500);

            InputSender.ClickKey(0x12);
            Thread.Sleep(11000);

            Util.MoveEaseRelative(x2,y2, stepNumber, 500);

            Util.GetCursorPos();
        }
    }
    public class Inventory
    {
        public static void FirstTwo()
        {
            InputSender.ClickKey(0x17);
            Thread.Sleep(500);
            InputSender.ClickKey(0x12);
            Thread.Sleep(250);
            InputSender.ClickKey(0x1f);
            Thread.Sleep(250);
            InputSender.ClickKey(0x12);
            Thread.Sleep(250);
            InputSender.ClickKey(0x01);
            Thread.Sleep(500);
        }
    }
    public class Herbs
    {
        public static void First()
        {
            Util.GetCursorPos();
            int x1 = 620;
            int y1 = -180;
            int x2 = -650;
            int y2 = 188;
            int stepNumber = 50;

            Util.MoveEaseRelative(x1,y1, stepNumber, 500);

            InputSender.ClickKey(0x12);
            Thread.Sleep(3500);

            Util.MoveEaseRelative(x2,y2, stepNumber, 500);

            InputSender.ClickKey(0x12);

            Thread.Sleep(3500);

            Util.MoveEaseRelative(15,10, 5, 50);

            Util.GetCursorPos();
        }

        public static void Second()
        {
            Util.GetCursorPos();
            int x1 = 490;
            int y1 = -180;
            int x2 = -485;
            int y2 = 200;
            int stepNumber = 50;

            Util.MoveEaseRelative(x1,y1, stepNumber, 500);

            InputSender.ClickKey(0x12);
            Thread.Sleep(3500);

            Util.MoveEaseRelative(x2,y2, stepNumber, 500);

            InputSender.ClickKey(0x12);

            Thread.Sleep(3500);

            Util.MoveEaseRelative(15,10, 5, 50);

            Util.GetCursorPos();
        }
    }
    public class Store
    {
        // 280 960
        public static void Phial(){
            Util.GetCursorPos();
            int x1 = -580;
            int y1 = 30;
            int x2 = 430;
            int y2 = -40;
            int stepNumber = 50;

            Util.MoveEaseRelative(x1,y1, stepNumber, 500);

            InputSender.ClickKey(0x12);
            Thread.Sleep(3500);

            Util.MoveEaseRelative(x2,y2, stepNumber, 500);

            InputSender.HoldKey(0x12, 1500);

            Thread.Sleep(7000);

            Util.GetCursorPos();

            Console.WriteLine("Potion brewed successfully!");
        }
    }
    public class Util{
        public static void GetCursorPos(){
            // Getting the cursor position
            var point = InputSender.GetCursorPosition();
            Console.WriteLine("X: " + point.X + ", Y: " + point.Y);
        }
        public static void MonitorCursorPos(){
            while(true){
                GetCursorPos();
                Thread.Sleep(10);
            }
        }
        public static void MoveRelative(int x, int y){
            InputSender.SendMouseInput(new InputSender.MouseInput[]
            {
                new InputSender.MouseInput
                {
                    dx = x,
                    dy = y,
                    dwFlags = (uint)InputSender.MouseEventF.Move
                }
            });
            System.Console.Write("Moved to: ");
            Util.GetCursorPos();
            Thread.Sleep(100);
        }

        public static void MoveEaseRelative(int x, int y, int stepNumber, int length){
            double currentX;
            double currentY;

            double prevX;
            double prevY;
            int deltaX;
            int deltaY;

            InputSender.POINT point = InputSender.GetCursorPosition();
            int baseX = point.X;
            int baseY = point.Y;
            double ease;


            for (int i = 1; i < stepNumber + 1; i++)
            {
                ease = EasingFunctions.OutCubic((float)i/stepNumber);
                
                currentX = ease * x;
                currentY = ease * y;

                point = InputSender.GetCursorPosition();
                prevX =  point.X - baseX;
                prevY  = point.Y - baseY;

                deltaX = (int) (currentX - prevX);
                deltaY = (int) (currentY - prevY);
                // System.Console.WriteLine(i + ": deltaX = " + deltaX + ", deltaY = " + deltaY);
                // System.Console.WriteLine(i + ": X = " + currentX + ", Y = " + currentY);

                InputSender.SendMouseInput(new InputSender.MouseInput[]
                {
                    new InputSender.MouseInput
                    {
                        dx = deltaX,
                        dy = deltaY,
                        dwFlags = (uint)InputSender.MouseEventF.Move
                    }
                });

                // System.Console.Write("Moved to: ");
                // Util.GetCursorPos();
                Thread.Sleep(length/stepNumber);
            }
            System.Console.WriteLine("moved succesfully!");
        }
        public static void Calibrate(){
            System.Console.WriteLine("============ Calibrating ============");
            Util.MoveEaseRelative(-5000,-5000,50,100);
            Util.MoveEaseRelative(860,930,50,100);
            Util.GetCursorPos();
            System.Console.WriteLine("============ Calibrated ============");
            Thread.Sleep(500);
        }
    }
}
