using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Modif
    {
        // все равно, что private int defaultVar;
        int defaultVar;
        // поле доступно только из текущего класса
        private int privateVar;
        // доступно из текущего класса и производных классов, которые определены в этом же проекте
        protected private int protectedPrivateVar;
        // доступно из текущего класса и производных классов
        protected int protectedVar;
        // доступно в любом месте текущего проекта
        internal int internalVar;
        // доступно в любом месте текущего проекта и из классов-наследников в других проектах
        protected internal int protectedInternalVar;
        // доступно в любом месте программы, а также для других программ и сборок
        public int publicVar;

        // по умолчанию имеет модификатор private
        void defaultMethod() { Console.WriteLine($"defaultVar = {defaultVar}"); }

        // метод доступен только из текущего класса
        private void privateMethod() { Console.WriteLine($"privateVar = {privateVar}"); }

        // доступен из текущего класса и производных классов, которые определены в этом же проекте
        protected private void protectedPrivateMethod() { Console.WriteLine($"protectedPrivateVar = {protectedPrivateVar}"); }

        // доступен из текущего класса и производных классов
        protected void protectedMethod() { Console.WriteLine($"protectedVar = {protectedVar}"); }

        // доступен в любом месте текущего проекта
        internal void internalMethod() { Console.WriteLine($"internalVar = {internalVar}"); }

        // доступен в любом месте текущего проекта и из классов-наследников в других проектах
        protected internal void protectedInternalMethod() { Console.WriteLine($"protectedInternalVar = {protectedInternalVar}"); }

        // доступен в любом месте программы, а также для других программ и сборок
        public void publicMethod() { Console.WriteLine($"publicVar = {publicVar}"); }
    }
}
}
