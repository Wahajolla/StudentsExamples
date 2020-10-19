using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Static
    {
        public void MakeAction()
        {
            StaticExample.text = "altText";
            StaticExample.Text = "ttteeexxt";
            StaticExample.MakeSmth();
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
