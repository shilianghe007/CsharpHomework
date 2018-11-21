using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace homework9
{
    class Program
    {
        private ConcurrentDictionary<string, bool> connection = new ConcurrentDictionary<string, bool>();
        private ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
        private int count = 0;
        static void Main(string[] args)
        {
            Program myCrawler = new Program();
            string startUrl = "http://www.epochtimes.com/gb/news418.htm";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.queue.Enqueue(startUrl);
            myCrawler.myCraw();
            Console.ReadKey();
        }
        private void myCraw()
        {
            Console.WriteLine("开始爬行了....");
            List<Task> ts = new List<Task>();
            while (count <= 25)
            {
                string outstring;
                queue.TryDequeue(out outstring);
                if (outstring != null)
                    ts.Add(Task.Run(() => Fun(outstring)));
            }
            Task.WaitAll(ts.ToArray());
            Console.WriteLine("爬行结束");
        }
        public void Fun(string url)
        {
            if (count >= 25 || connection.ContainsKey(url)) return;
            string html;
            Console.WriteLine("爬行" + url + "页面!");
            count++;
            connection[url] = true;
            Console.WriteLine("count++    count=" + count);
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                html = webClient.DownloadString(url);

                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                html = "";
            }
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\\', '#', ' ', '>');
                if (strRef.Length == 0) continue;
                else if (!connection.ContainsKey(strRef) && count <= 25)
                    queue.Enqueue(strRef);
            }
        }
    }
}
