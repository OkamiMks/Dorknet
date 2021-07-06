using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorkNet.Defines
{
    class Banner
    {
        public void Bann()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(
@":::::::::   ::::::::  :::::::::  :::    ::: ::::    ::: :::::::::: ::::::::::: 
:+:    :+: :+:    :+: :+:    :+: :+:   :+:  :+:+:   :+: :+:            :+:     
+:+    +:+ +:+    +:+ +:+    +:+ +:+  +:+   :+:+:+  +:+ +:+            +:+     
+#+    +:+ +#+    +:+ +#++:++#:  +#++:++    +#+ +:+ +#+ +#++:++#       +#+     
+#+    +#+ +#+    +#+ +#+    +#+ +#+  +#+   +#+  +#+#+# +#+            +#+     
#+#    #+# #+#    #+# #+#    #+# #+#   #+#  #+#   #+#+# #+#            #+#     
#########   ########  ###    ### ###    ### ###    #### ##########     ###");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("Autor: ");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("@");
                Console.ForegroundColor = ConsoleColor.Red; Console.Write("o");
                Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("k");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("a");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("m");
                Console.ForegroundColor = ConsoleColor.Red; Console.Write("i");
                Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("M");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("k");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("s");
                Console.ForegroundColor = ConsoleColor.Red; Console.Write(" ~ ");
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" v0.0.1 (beta) ");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("Telegram Group: ");
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("https://t.me/mksDecode\n\n");
        }
        public void alertL()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Write(" [");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("!");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("] ");
        }
        public void errorL()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Write(" [");
            Console.ForegroundColor = ConsoleColor.Red; Console.Write("-");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("] ");
        }
        public void trueL()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Write(" [");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("+");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("] ");
        }
        public void list()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Write(" [");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("+");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("] ");
        }
        public static void alertLStatic()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Write(" [");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("!");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("] ");
        }
        public static void listStatic()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Write(" [");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("+");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("] ");
        }
        public static void listagem(string content1, string content2, string content3)
        {
            listStatic(); Console.Write(content1); Console.Write(content2);
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(content3);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Comands()
        {
            alertLStatic();  Console.Write("Comandos"); alertLStatic(); Console.WriteLine();

            listagem("!dorkGem", "          *    ", "Gerar dorks");
            listagem("!dorkSearch", "       *    ", "Pesquisar dorks"); Console.WriteLine();
        }
    }
    class Data
    {
        public void DataConsole()
        {
            string
                hora = DateTime.Now.ToString("HH"),
                min  = DateTime.Now.ToString("mm"),
                seg  = DateTime.Now.ToString("ss"),
                temp = ($"{hora}:{min}:{seg}");

            Console.ForegroundColor = ConsoleColor.White; Console.Write(" [");
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(temp);
            Console.ForegroundColor = ConsoleColor.White; Console.Write("] ");
        }
        public void DataClient()
        {
            string
                typeClient = DateTime.Now.ToString("tt"),
                anoClient  = DateTime.Now.ToString("HH"),
                mesClient  = DateTime.Now.ToString("MMMM"),
                horaClient = DateTime.Now.ToString("HH"),
                minClient  = DateTime.Now.ToString("mm"),
                segClient  = DateTime.Now.ToString("ss"),
                tempClient = ($" [{anoClient}:{mesClient}-{horaClient}:{minClient}:{segClient} {typeClient}] ");

            Console.ForegroundColor = ConsoleColor.White; Console.Write(" [");
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(tempClient);
            Console.ForegroundColor = ConsoleColor.White; Console.Write("] ");
        }
    }
}
