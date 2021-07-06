using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.Net.Http;
using WMPLib;

namespace DorkNet.Defines
{
    class Comands
    {
        public string result;
        public void DorkGem()
        {
            Defines.Data data = new();
            data.DataConsole();
            string
                hora = DateTime.Now.ToString("HH"),
                min  = DateTime.Now.ToString("mm"),
                seg  = DateTime.Now.ToString("ss"),
                temp = ($"{hora}-{min}-{seg}"),
                temp2 = ($"{hora}:{min}:{seg}");

            string[] types = new string[] {
                ".php?", ".php3?", ".php4?", ".aps?", ".aspx?",
                ".jsp?", ".cgi?", ".cfm?", ".flv?", ".pdf?", ".jsf?",
                ".asinx?", ".psml?", ".raw?", ".file?", ".tss?", ".blog?",
                ".html?", ".cshtml?", ".htm?"
            };
            string[] parans = new string[] {
                "item=", "itens=", "carrinho=", "games=", "jogos=", 
                "card=", "cartao=", "id=", "itens/carrinho=",
                "item/id=", "carrinho/id=", "item_id=", "page=",
                "page_id=", "item/page=", "item/page_id=", "item/page/id=",
                "admin=", "page/admin=", "admin/login=", "/admin/login.asp",
                "/admin/login.php", "/client/login.php", "/client/login.asp"
            };
            string[] parans2 = new string[] {  "site: ", "intitle: ", "title: ", "inurl: ", "budget site: " };

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("Content dork -> ");
                string contentDork = Console.ReadLine();

                if (!string.IsNullOrEmpty(contentDork))
                {
                    if (string.Equals(contentDork, "!close")) { Console.Clear(); break; }
                    else
                    {
                        Defines.Data dt = new();
                        foreach (var lineType in types)
                        {
                            foreach (var line in parans2)
                            {
                                result = $"{line}{contentDork}{lineType}";
                                File.AppendAllText("Dorks/Lists/list-" + temp + ".txt", result + "\n");
                                dt.DataConsole(); RandomColor(); Console.WriteLine(result);
                            }
                        }
                        foreach (var line in parans)
                        {
                            foreach (var lineType in types)
                            {
                                result = $"{contentDork}{lineType}{line}";
                                File.AppendAllText("Dorks/Lists/list-" + temp + ".txt", result + "\n");
                                dt.DataConsole(); RandomColor(); Console.WriteLine(result);
                            }
                        }
                        foreach (var line in parans2)
                        {
                            foreach (var lineType in types)
                            {
                                result = $"{line}{contentDork}{lineType}";
                                File.AppendAllText("Dorks/Lists/list-" + temp + ".txt", result + "\n");
                                dt.DataConsole(); RandomColor(); Console.WriteLine(result);
                            }
                        }
                        foreach (var line in parans2)
                        {
                            foreach (var line2 in parans)
                            {
                                foreach(var lineType in types)
                                {
                                    result = $"{line}{contentDork}{lineType}{line2}";
                                    File.AppendAllText("Dorks/Lists/list-" + temp + ".txt", result + "\n");
                                    dt.DataConsole(); RandomColor(); Console.WriteLine(result);
                                }
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        dt.DataConsole(); Console.WriteLine("Patch: Salvo -> " + temp2);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
        public void DorkSearch()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Defines.Data data = new(); data.DataConsole();
            Console.Write("Digite o caminho do arquivo -> ");
            string patch = Console.ReadLine();
            if (!string.IsNullOrEmpty(patch)) { DkSearch(patch); }
        }
        public void Creator()
        {
            int cont = 0;
            while (cont < 80)
            {
                cont++;
                RandomColor();
                Console.WriteLine(" ::::::::  :::    :::     :::     ::::    ::::  ::::::::::: ");
                Console.WriteLine(":+:    :+: :+:   :+:    :+: :+:   +:+:+: :+:+:+     :+:     ");
                Console.WriteLine("+:+    +:+ +:+  +:+    +:+   +:+  +:+ +:+:+ +:+     +:+     ");
                Console.WriteLine("+#+    +:+ +#++:++    +#++:++#++: +#+  +:+  +#+     +#+     ");
                Console.WriteLine("+#+    +#+ +#+  +#+   +#+     +#+ +#+       +#+     +#+     ");
                Console.WriteLine("#+#    #+# #+#   #+#  #+#     #+# #+#       #+#     #+#     ");
                Console.WriteLine(" ########  ###    ### ###     ### ###       ### ########### \n");

                Console.ForegroundColor = ConsoleColor.White; Console.Write("Telegram User   : ");
                Console.ForegroundColor = ConsoleColor.Cyan;  Console.WriteLine("https://t.me/okamiMks");
                Console.ForegroundColor = ConsoleColor.White; Console.Write("Telegram Group  : ");
                Console.ForegroundColor = ConsoleColor.Cyan;  Console.WriteLine("https://t.me/mksDecode");
                Console.ForegroundColor = ConsoleColor.White; Console.Write("GitHub          : ");
                Console.ForegroundColor = ConsoleColor.Cyan;  Console.WriteLine("https://github.com/OkamiStudioMks");
                Console.ForegroundColor = ConsoleColor.White; Console.Write("Telegram Channel: ");
                Console.ForegroundColor = ConsoleColor.Cyan;  Console.WriteLine("https://t.me/mksDecodeChannel \n");

                Thread.Sleep(100);
                Console.Clear();
            }
        }
        public static async void DkSearch(string patchArquive)
        {
            string musicPatch = $"Config/Musics/Kikuo.mp3";
            WindowsMediaPlayer mPlayer = new();

            try { mPlayer.URL = musicPatch; mPlayer.controls.play(); }
            catch { Console.WriteLine("Patch : music -> não encontrado"); }
            Defines.Data data = new();
            data.DataConsole();
            string
                hora = DateTime.Now.ToString("HH"),
                min = DateTime.Now.ToString("mm"),
                seg = DateTime.Now.ToString("ss"),
                temp = ($"{hora}-{min}-{seg}"),
                temp2 = ($"{hora}:{min}:{seg}");

            data.DataConsole();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Lendo arquivo -> " + patchArquive + "..."); Thread.Sleep(300);
            Console.ForegroundColor = ConsoleColor.White;

            string dorksPatch = await File.ReadAllTextAsync(patchArquive);
            string[] dork = dorksPatch.Split("\n");


            foreach(var line in dork)
            {
                string[] urls = new string[]
                {
                    "https://www.bing.com/search?q=" + line + "&search=&first=415&form=QBLH",
                    "https://www.bing.com/search?q=" + line + "&sp=-1&pq=tes&sc=9-3&qs=n&sk=&cvid=29F838C0194F4F4B983013E5087E7E84&first=9&FORM=PERE",
                    "https://www.bing.com/search?q=" + line + "&sp=-1&pq=tes&sc=9-3&qs=n&sk=&cvid=29F838C0194F4F4B983013E5087E7E84&first=19&FORM=PERE1",
                    "https://www.bing.com/search?q=" + line + "&sp=-1&pq=tes&sc=9-3&qs=n&sk=&cvid=29F838C0194F4F4B983013E5087E7E84&first=29&FORM=PERE2",
                    "https://search.yahoo.com/search;_ylt=A2KLfSfZtydgnW0AGEJDDWVH;_ylc=X1MDMTE5NzgwNDg2NwRfcgMyBGZyAwRmcjIDc2ItdG9wLXNlYXJjaARncHJpZANHcGJwWE05S1RuYVJhcTF0VEpUaGRBBG5fcnNsdAMwBG5fc3VnZwMxMARvcmlnaW4Dc2VhcmNoLnlhaG9vLmNvbQRwb3MDMARwcXN0cgMEcHFzdHJsAzAEcXN0cmwDNgRxdWVyeQNwYXlwYWwEdF9zdG1wAzE2MTMyMTU3MTY-?p=" + line + "&fr=sfp&iscqry=&fr2=sb-top-search",
                    "https://search.yahoo.com/search;_ylt=A2KLfR7n7ONgEDIAheVXNyoA;_ylu=Y29sbwNiZjEEcG9zAzEEdnRpZAMEc2VjA3BhZ2luYXRpb24-?p=" + line + "&fr=sfp&fr2=sb-top-search&b=11&pz=10&bct=0&xargs=0",
                    "https://search.yahoo.com/search;_ylt=A2KIbNAH7eNgO9MA9P1XNyoA;_ylu=Y29sbwNiZjEEcG9zAzEEdnRpZAMEc2VjA3BhZ2luYXRpb24-?p=" + line + "&pz=10&fr=sfp&fr2=sb-top-search&bct=0&b=21&pz=10&bct=0&xargs=0",
                    "https://search.aol.com/aol/search;_ylt=A2KIbZwtwidgTw0AFlNpCWVH;_ylc=X1MDMTE5NzgwMzg4MQRfcgMyBGZyA25hBGdwcmlkA1JhUXdPdDJYUkRxUE5rdnBseWF5MEEEbl9yc2x0AzAEbl9zdWdnAzEwBG9yaWdpbgNzZWFyY2guYW9sLmNvbQRwb3MDMARwcXN0cgMEcHFzdHJsAzAEcXN0cmwDNgRxdWVyeQNwYXlwYWwEdF9zdG1wAzE2MTMyMTgzNjg-?q=" + line + "&s_it=sb-top&v_t=na",
                    "https://search.aol.com/aol/search;_ylt=AwrJ7JuX7eNgUt0A5TJpCWVH;_ylu=Y29sbwNiZjEEcG9zAzEEdnRpZAMEc2VjA3BhZ2luYXRpb24-?q=" + line + "&fr2=sb-top-search&v_t=na&b=11&pz=10&bct=0&pstart=2",
                    "https://yandex.com/search/?oprnd=7208367573&text=" + line + "&lr=21221",
                    "https://duckduckgo.com/?q=" + line + "&t=opera&ia=web",
                    "https://www.google.com/search?q=" + line + "&sxsrf=ALeKk00Gc-DnoXjO1CyyH9CP5PpViko6gw%3A1625525514974&source=hp&ei=Co3jYO6dOavI1sQPh6CdoAE&iflsig=AINFCbYAAAAAYOObGrcL3JrlwkF4KXZRBsOgr0ftUaRP&oq=teste&gs_lcp=Cgdnd3Mtd2l6EAMyBAgjECcyBAgjECcyBAgjECcyCAgAELEDEIMBMgUIABCxAzIFCAAQsQMyBQgAELEDMgUIABCxAzIFCAAQsQMyBQgAELEDOgcIIxAnEJ0COgcIABCxAxBDOgQIABBDOgoIABCxAxCDARBDOhAIABCxAxCDARDHARCjAhBDOgcIIxCxAhAnOgIIADoECAAQCjoHCAAQsQMQClDWAljTDGDsD2gCcAB4AYAB1wOIAagLkgEJMC41LjEuMC4xmAEAoAEBqgEHZ3dzLXdperABAA&sclient=gws-wiz&ved=0ahUKEwjuypC3gs3xAhUrpJUCHQdQBxQQ4dUDCAY&uact=5"
                },
                node = new string[] 
                {
                    "//*[@id='b_results']/li[1]/div[2]/div/cite",                         // bing
                    "//*[@id='b_results']/li[1]/div/div[1]/div/cite",                     // bing
                    "//*[@id='b_results']/li[1]/div/div/cite",                            // bing
                    "//*[@id='b_results']/li[1]/div/div/cite",                            // bing
                    "//*[@id='web']/ol/li[1]/div/div[1]/div/span[1]",                     // yahoo
                    "//*[@id='web']/ol/li[1]/div/div[1]/div/span[1]",                     // yahoo
                    "//*[@id='web']/ol/li[1]/div/div[1]/div/span[1]",                     // yahoo
                    "//*[@id='web']/ol/li[2]/div/div[1]/div/span",                        // aol
                    "//*[@id='yui_3_10_0_1_1625550260435_39']/li[2]/div/div[1]/div/span", // oal
                    "//*[@id='search-result']/li[2]/div/div[1]/div[1]/a[@href]",          // yandex
                    "//*[@id='r1-0']/div/h2/a[1][@href]",                                 // duckduckgo
                    "//*[@id='rso']/div[1]/div/div/div[1]/a[@href]"                       // google

                };
                               
                for (var i = 0; i < urls.Length; i++)
                {
                    var html = new HtmlWeb().Load(urls[i]);
                    var nodes = html.DocumentNode.SelectNodes(node[i]);
                    if (nodes != null)
                    {
                        foreach(var lineNodes in nodes)
                        {
                            string href = lineNodes.InnerText;
                            RandomColor(); Console.WriteLine("[+] " + href);
                            File.AppendAllText("Dorks/Links - Resultados/-" + temp + ".txt", href + "\n");
                        }
                    }
                }
            }
        }
        public static void RandomColor()
        {
            Random rdm = new();
            int ret = rdm.Next(0, 5);

            if (ret == 0) { Console.ForegroundColor = ConsoleColor.Yellow; }
            else if (ret == 1) { Console.ForegroundColor = ConsoleColor.Green; }
            else if (ret == 3) { Console.ForegroundColor = ConsoleColor.Red; }
            else if (ret == 4) { Console.ForegroundColor = ConsoleColor.Magenta; }
            else if (ret == 5) { Console.ForegroundColor = ConsoleColor.Cyan; }
            else { Console.ForegroundColor = ConsoleColor.Green; }
        }
    }
}
