using System;

namespace Lab3_Part1_Ex2
{
    class Window
    {
        // constructor takes two integers to
        // fix location on the console
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        // simulates drawing the window
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}",
            top, left);
        }
        // these members are protected and thus visible
        // to derived class methods. We&#39;ll examine this
        // later in the chapter
        protected int top;
        protected int left;
    }

    class ListBox : Window
    {
        private string listBoxContents;
        public ListBox(int top, int left, string contents) : base(top, left)
        {
            listBoxContents = contents;
        }
        public override void DrawWindow()
        {
            base.DrawWindow(); // invoke the base method
            Console.WriteLine("Writing string to the listbox:{0}",
            listBoxContents);
        }
    }

    class Button : Window
    {
        public Button(int top, int left) : base(top, left)
        {
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top,left);
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Window win = new Window(1, 2);
            ListBox lb = new ListBox(3, 4, "Stand alone list box");
            Button b = new Button(5, 6);
            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();
            Window[] winArray = new Window[3];
            winArray[0] = new Window(1, 2);
            winArray[1] = new ListBox(3, 4, "List box in array");
            winArray[2] = new Button(5, 6);
            for (int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }
            Console.ReadLine();
        }
    }
}