using DownloadMuti.Properties;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace DownloadMuti
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        private string path = null;

        public RadForm1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string[] api = File.ReadAllLines("api.txt");
            int number;
            int key = 0;
            if (path == null)
            {
                MessageBox.Show("Chưa chọn thư mục lưu hình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (int.TryParse(txtNum.Text, out number))
            {
                int num = int.Parse(txtNum.Text);
                IRestResponse response = null;
                string topic = this.ckbTopic.SelectedValue.ToString();
                this.lblStatus.Text = "Đang lấy ảnh từ nguồn ...";
                Thread thread = new Thread(delegate ()
                {
                    int i = 0;
                    int complete = 0;
                ChangeAPI:
                    RestClient restClient = new RestClient(string.Concat(new object[]
                    {
                    "https://api.unsplash.com/photos/random?",
                    topic,
                    "count=",
                    30,
                    "&client_id="+api[key]
                    }));
                    RestRequest request = new RestRequest(Method.GET);
                    response = restClient.Execute(request);
                    if (response.IsSuccessful)
                    {
                        RadForm1.RootObject[] result = JsonConvert.DeserializeObject<RadForm1.RootObject[]>(response.Content);
                        string[] collection = File.ReadAllLines("listid.txt");
                        List<string> list = new List<string>();
                        list.AddRange(collection);
                        foreach (RadForm1.RootObject rootObject in result)
                        {
                            if (!list.Contains(rootObject.id))
                            {
                                using (StreamWriter streamWriter = new StreamWriter("listid.txt", true))
                                {
                                    streamWriter.WriteLine(rootObject.id);
                                }
                            }
                        }
                        collection = File.ReadAllLines("listid.txt");
                        this.lblStatus.Text = string.Concat(new object[]
                        {
                        "Lấy được ",
                        result.Count<RadForm1.RootObject>(),
                        " /",
                        this.txtNum.Text,
                        " ảnh không bị trùng"
                        });

                        RadForm1.RootObject[] result2 = result;
                        for (int j = 0; j < result2.Length; j++)
                        {
                            RadForm1.RootObject obj = result2[j];
                            using (WebClient webClient = new WebClient())
                            {
                                Uri myUri = new Uri(obj.urls.regular, UriKind.Absolute);
                                webClient.DownloadFileAsync(myUri, this.path + "//Tata-" + obj.id + ".jpg");
                                while (webClient.IsBusy)
                                {
                                    Application.DoEvents();
                                }
                            }
                            int i2 = i;
                            i = i2 + 1;
                            this.lblStatus.Text = string.Concat(new object[]
                            {
                                "Tải về ",
                                i,
                                " /",
                                num,
                                " ảnh"
                            });
                        }
                        complete = complete + result2.Length;
                        if (complete > num)
                            return;
                        else
                            goto ChangeAPI;

                    }
                    key++;
                    goto ChangeAPI;
                })
                {
                    IsBackground = true
                };
                thread.Start();
                while (thread.IsAlive)
                {
                    Application.DoEvents();
                    this.btnStart.Enabled = false;
                }
                btnStart.Enabled = true;
            }
            else
                MessageBox.Show("Số lượng hình không đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_SetFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    this.path = folderBrowserDialog.SelectedPath;
                    Settings.Default.path = folderBrowserDialog.SelectedPath;
                    Settings.Default.Save();
                    this.lblStatus.Text = "Thư mục đang lưu: " + this.path;
                    MessageBox.Show("Đã chọn thư mục lưu. Hệ thống tự lưu lại lần kế tiếp.");
                }
            }
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("key");
            dataTable.Columns.Add("name");
            dataTable.Rows.Add(new object[]
            {
                "",
                "Không chủ đề"
            });
            dataTable.Rows.Add(new object[]
            {
                "query=architecture&",
                "Kiến trúc"
            });
            dataTable.Rows.Add(new object[]
            {
                "query=sport&",
                "Thể thao"
            });
            dataTable.Rows.Add(new object[]
            {
                "query=travel&",
                "Du lịch"
            });
            dataTable.Rows.Add(new object[]
            {
                "query=beauty&",
                "Làm đẹp"
            });
            dataTable.Rows.Add(new object[]
            {
                "query=fashion&",
                "Thời trang"
            });
            dataTable.Rows.Add(new object[]
            {
                "query=pet&",
                "Vật nuôi"
            });
            dataTable.Rows.Add(new object[]
            {
                "query=art&",
                "Nghệ thuật"
            });
            dataTable.Rows.Add(new object[]
            {
                "query=photography&",
                "Nhiếp ảnh"
            });
            dataTable.Rows.Add(new object[]
            {
                "query=food&",
                "Ẩm thực"
            });
            if (Properties.Settings.Default.path != null)
                this.path = Properties.Settings.Default.path;
            this.ckbTopic.DataSource = dataTable;
            this.ckbTopic.ValueMember = "key";
            this.ckbTopic.DisplayMember = "name";
            this.lblStatus.Text = "Thư mục đang lưu: " + this.path;
        }
        public class Urls
        {
            public string raw { get; set; }
            public string full { get; set; }
            public string regular { get; set; }
            public string small { get; set; }
            public string thumb { get; set; }
        }
        public class RootObject
        {
            public string id { get; set; }
            public RadForm1.Urls urls { get; set; }
        }
    }
}
