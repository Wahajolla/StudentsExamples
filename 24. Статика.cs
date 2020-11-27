using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Static
    {
        public void MakeAction()
        {
            Console.WriteLine();
            StaticExample.text = "altText";
            StaticExample.Text = "ttteeexxt";
            StaticExample.MakeSmth();
            StaticExample st1 = new StaticExample();
            StaticExample st2 = new StaticExample();
            string s = StaticExample.ReturnString();

        }
    }

    class StaticExample
    {

        public static string text = "ttteeexxt";
        public static string Text
        {
            get { return Text; }
            set { text = value; }
        }

        public static void MakeSmth()
        {

        }
        public static string ReturnString()
        {
            return text;

        }
    }
}
