using System;
using System.Collections.Generic;
using System.Net;
using System.Xml;

namespace RSS_Reader
{
    public class RequestOmg
    {
        public string CreateRequest(string queryString)
        {
            var urlRequest = "http://news.rambler.ru/rss/" +
                             queryString;
            return (urlRequest);
        }

        //Submit the HTTP Request and return the XML response
        public XmlDocument MakeRequest(string requestUrl)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(response.GetResponseStream());
                return (xmlDoc);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                Console.Read();
                return null;
            }
        }

        public List<News> ProcessRequest(XmlDocument newsXml)
        {
            var newsList = new List<News>();
            try
            {
                var channel = newsXml.SelectSingleNode("rss/channel");

                var tempListOfItemsInEachChannel = channel.SelectNodes("item");

                foreach (XmlNode subSubNode in tempListOfItemsInEachChannel)
                {

                    var news = new News();

                    var nodes = subSubNode.ChildNodes;
                    foreach (XmlNode node in nodes)
                    {
                        news.Category = node.Name == "category" ? node.InnerText : news.Category;
                        news.Descrition = node.Name == "description" ? node.InnerText : news.Descrition;
                        news.Link = node.Name == "link" ? node.InnerText : news.Link;
                        news.PubDate = node.Name == "pubDate" ? node.InnerText : news.PubDate;
                        news.Title = node.Name == "title" ? node.InnerText : news.Title;
                    }
                    newsList.Add(news);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
            
            return newsList;
        }
    }
}
