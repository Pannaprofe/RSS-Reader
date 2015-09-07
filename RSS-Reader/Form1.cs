using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace RSS_Reader
{
    public partial class Form1 : Form
    {
        private readonly RequestOmg _requestOmg;
        private List<News> _newsList;
        private Dictionary<string, string> _newsCategoriesDict;
        private Dictionary<string, string> _newsCategoriesToShowDict;

        public Form1()
        {
            _newsCategoriesDict = CreateDownloadPathDictionary();
            _newsCategoriesToShowDict = new Dictionary<string, string>();
            _requestOmg = new RequestOmg();
            _newsList = DownloadAllNews();
            InitializeComponent();
        }

        private List<News> DownloadAllNews()
        {
            var newsList = new List<News>();
            foreach (var elem in _newsCategoriesDict)
            {
                string strRequest =_requestOmg.CreateRequest(elem.Value);
                XmlDocument xmlDoc =_requestOmg.MakeRequest(strRequest);
                newsList.AddRange(_requestOmg.ProcessRequest(xmlDoc));
            }
            return newsList;
        }
        

        private void Show1CategoryNews(string newsRequest)
        {
            
            Panel.RowCount = 1;
            Panel.VerticalScroll.Visible = true;
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            Panel.Padding = new Padding(0, 0, vertScrollWidth, 0);

            var newsResponse = _requestOmg.MakeRequest(newsRequest);
            _newsList = _requestOmg.ProcessRequest(newsResponse);


            foreach (var elem in _newsList)
            {
                var text = new RichTextBox()
                {
                    BorderStyle = BorderStyle.None,
                    Text = elem.Title,
                    Multiline = true,
                    Dock = DockStyle.Top,
                    BackColor = Panel.BackColor,
                    ForeColor = Color.Black,
                    ReadOnly = true
                };

                text.MouseDoubleClick += 
                    (object senderForPanel, MouseEventArgs eForPanel) =>
                    {
                        txt_CurrentNews.Text =
                            elem.Title + "\n\n" +
                            elem.Descrition + "\n\n" +
                            "Link: " + elem.Link;
                    };

                Panel.Controls.Add(text);
                Panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                Panel.Refresh();
            }
        }


        private static Dictionary<string, string> CreateDownloadPathDictionary()
        {
            var dict = new Dictionary<string, string>
            {
                {"Sport", "sport/"},
                {"StarLife", "starlife/"},
                {"Business", "business/"},
                {"Technology", "scitech/"}
            };
            return dict;
        }

        private void txt_CurrentNews_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void SportCB_CheckedChanged(object sender, EventArgs e)
        {
            Panel.Controls.Clear();
            if(SportCB.Checked)
                _newsCategoriesToShowDict.Add("Sport",_newsCategoriesDict["Sport"]);
            else
            {
                _newsCategoriesToShowDict.Remove("Sport");
            }
            ShowNews();
                
        }

        private void BusinessCB_CheckedChanged(object sender, EventArgs e)
        {
            Panel.Controls.Clear();
            if (BusinessCB.Checked)
                _newsCategoriesToShowDict.Add("Business",_newsCategoriesDict["Business"]);
            else
            {
                _newsCategoriesToShowDict.Remove("Business");
            }
            ShowNews();
        }

        private void TechnologyCB_CheckedChanged(object sender, EventArgs e)
        {
            Panel.Controls.Clear();
            if (TechnologyCB.Checked)
                _newsCategoriesToShowDict.Add("Technology",_newsCategoriesDict["Technology"]);
            else
            {
                _newsCategoriesToShowDict.Remove("Technology");
            }
            ShowNews();
        }

        private void StarLifeCB_CheckedChanged(object sender, EventArgs e)
        {
            Panel.Controls.Clear();
            if (StarLifeCB.Checked)
                _newsCategoriesToShowDict.Add("StarLife",_newsCategoriesDict["StarLife"]);
            else
            {
                _newsCategoriesToShowDict.Remove("StarLife");
            }
            ShowNews();
        }

        private void ShowNews()
        {
            foreach (var elem in _newsCategoriesToShowDict)
            {
                Show1CategoryNews(_requestOmg.CreateRequest(elem.Value));
            }
        }
    }
}
