using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var postit1 = new PostIt();
            var postit2 = new PostIt();
            var postit3 = new PostIt();

            postit1.BackgroundColor = "orange";
            postit1.Text = "Idea 1";
            postit1.TextColor = "blue";

            postit2.BackgroundColor = "pink";
            postit2.Text = "Awesome";
            postit2.TextColor = "black";

            postit3.BackgroundColor = "yellow";
            postit3.Text = "Superb!";
            postit3.TextColor = "green";
        }

        struct PostIt
        {
            public string BackgroundColor;
            public string Text;
            public string TextColor;
        }
    }
}
