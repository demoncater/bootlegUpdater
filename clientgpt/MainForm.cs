using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class MainForm : Form
    {
        private ComboBox windowmodeComboBox;
        private ComboBox gpuComboBox;
        private ComboBox resolutionsizeComboBox;
        private ComboBox chatfontsizeComboBox;
        private GroupBox ClientBox;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private LinkLabel linkLabel1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private LinkLabel linkLabel2;
        private GroupBox groupBox1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Button okButton;

        public MainForm()
        {
            InitializeComponent();
            PopulateGpuComboBox();
            LoadVersionLabel();
            ReadCompClientFile();
            updatelinkdownload();

        }

        private void InitializeComponent()
        {
            this.windowmodeComboBox = new System.Windows.Forms.ComboBox();
            this.gpuComboBox = new System.Windows.Forms.ComboBox();
            this.resolutionsizeComboBox = new System.Windows.Forms.ComboBox();
            this.chatfontsizeComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.ClientBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ClientBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowmodeComboBox
            // 
            this.windowmodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.windowmodeComboBox.Items.AddRange(new object[] {
            "Windowed",
            "Fullscreen"});
            this.windowmodeComboBox.Location = new System.Drawing.Point(131, 19);
            this.windowmodeComboBox.Name = "windowmodeComboBox";
            this.windowmodeComboBox.Size = new System.Drawing.Size(226, 21);
            this.windowmodeComboBox.TabIndex = 0;
            // 
            // gpuComboBox
            // 
            this.gpuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gpuComboBox.Location = new System.Drawing.Point(131, 46);
            this.gpuComboBox.Name = "gpuComboBox";
            this.gpuComboBox.Size = new System.Drawing.Size(226, 21);
            this.gpuComboBox.TabIndex = 1;
            // 
            // resolutionsizeComboBox
            // 
            this.resolutionsizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionsizeComboBox.Items.AddRange(new object[] {
            "800 x 600   4:3",
            "1024 x 768   4:3",
            "1280 x 720   16:9",
            "1280 x 800   16:10",
            "1366 x 768   16:9",
            "1440 x 900   16:10",
            "1600 x 900   16:9",
            "1680 x 1050   16:10",
            "1920 x 1080   16:9",
            "1920 x 1200   16:10",
            "2560 x 1440   16:9",
            "2560 x 1600   16:10",
            "3840 x 2160   16:9"});
            this.resolutionsizeComboBox.Location = new System.Drawing.Point(131, 73);
            this.resolutionsizeComboBox.Name = "resolutionsizeComboBox";
            this.resolutionsizeComboBox.Size = new System.Drawing.Size(226, 21);
            this.resolutionsizeComboBox.TabIndex = 2;
            // 
            // chatfontsizeComboBox
            // 
            this.chatfontsizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chatfontsizeComboBox.Items.AddRange(new object[] {
            "Small (12pt)",
            "Medium (14pt)",
            "Large (16pt)",
            "Small (12pt) - No antialiasing",
            "Medium (14pt) - No antialiasing",
            "Large (16pt) - No antialiasing"});
            this.chatfontsizeComboBox.Location = new System.Drawing.Point(131, 100);
            this.chatfontsizeComboBox.Name = "chatfontsizeComboBox";
            this.chatfontsizeComboBox.Size = new System.Drawing.Size(226, 21);
            this.chatfontsizeComboBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(6, 131);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ClientBox
            // 
            this.ClientBox.Controls.Add(this.label4);
            this.ClientBox.Controls.Add(this.label3);
            this.ClientBox.Controls.Add(this.chatfontsizeComboBox);
            this.ClientBox.Controls.Add(this.label1);
            this.ClientBox.Controls.Add(this.okButton);
            this.ClientBox.Controls.Add(this.windowmodeComboBox);
            this.ClientBox.Controls.Add(this.resolutionsizeComboBox);
            this.ClientBox.Controls.Add(this.label2);
            this.ClientBox.Controls.Add(this.gpuComboBox);
            this.ClientBox.Location = new System.Drawing.Point(12, 185);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(363, 165);
            this.ClientBox.TabIndex = 5;
            this.ClientBox.TabStop = false;
            this.ClientBox.Text = "Game Settigns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chat font size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resolution:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Window Mode:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Display adapter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Client Base Download";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(245, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(322, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://129.80.113.218/download/imagine_base.zip";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Latest Update";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Retriving";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Your Update Version";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(430, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Latest update link";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(176, 66);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(72, 17);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel2";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 123);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Version Info";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(314, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "(extract in same location of game and select yes to any overwrite)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(443, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "have this app in same";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(443, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "location of game folder";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(443, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "update 1667 is a test";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(443, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "it just changes comp_client";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(375, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(190, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "should create shortcut of ImagineClient";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(375, 271);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(173, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "and put in C:\\Users\\billy\\AppData\\";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(375, 284);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(173, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Roaming\\Microsoft\\Windows\\Start";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(375, 297);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(182, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Menu\\Programs so you can windows";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(375, 310);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(181, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "search it instead of manually opening";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(582, 362);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClientBox);
            this.Name = "MainForm";
            this.Text = "SMT imagine settings";
            this.ClientBox.ResumeLayout(false);
            this.ClientBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PopulateGpuComboBox()
        {
            string[] gpus = GetAvailableGPUs();
            if (gpus.Length > 0)
            {
                this.gpuComboBox.Items.AddRange(gpus);
                this.gpuComboBox.SelectedIndex = 0;
            }
            else
            {
                this.gpuComboBox.Enabled = false;
                MessageBox.Show("No GPUs detected on the system.");
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string windowmodestring = this.windowmodeComboBox.SelectedItem.ToString();
            string gpu = this.gpuComboBox.SelectedItem.ToString();
            string resolutionsizestring = this.resolutionsizeComboBox.SelectedItem.ToString();
            string chatfontsizestring = this.chatfontsizeComboBox.SelectedItem.ToString();
            string fileName = string.Format("OutsideOptions.txt");
            string windowModeString = "Windowed";
            // turn chatfontsize choice to index
            // Get the index of the selected item
            int selectedIndex = chatfontsizeComboBox.SelectedIndex;
            // Convert the index to a string
            string selectedItemIndex = selectedIndex.ToString();
            // Get the selected resolution from resoltutionsizeComboBox
            string selectedResolution = resolutionsizeComboBox.SelectedItem.ToString();
            //Console.WriteLine($"Selected resolution: {selectedResolution}");

            string[] words = selectedResolution.Split(' '); // Split the input string by space
            string firstWord = words[0]; // Extract the first word

            int index = selectedResolution.IndexOf("x") + 2; // Find the index of "x" and add 1 to skip it
            string secondWord = selectedResolution.Substring(index).Split(' ')[0]; // Extract the word after "x"
            //Console.WriteLine(firstWord); // Outputs "cat"
            //Console.WriteLine(secondWord); // Outputs "dog"

            // getting resoultion X and Y
            //string[] parts = selectedResolution.Split('x');
            //Console.WriteLine($"Parts: {string.Join(",", parts)}");

            //int width = int.Parse(parts[0].Trim());
            //int height = int.Parse(parts[1].Split(' ')[0].Trim());
            //string widthStr = width.ToString();
            //string heightStr = height.ToString();
            //Console.WriteLine($"ResolutionX: {width}");
            //Console.WriteLine($"ResolutionY: {height}");

            // generating OutsideOption.txt
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // get gpu
                writer.WriteLine("-Adapter \"" + gpu + "\"");
                writer.WriteLine("-ChatFontSizeType " + selectedItemIndex);
                writer.WriteLine("-Color 32");
                // turn fullscreen choice to *boolean*
                if (this.windowmodeComboBox.SelectedItem.ToString() == "Windowed")
                {
                    string windowmodebooleanString = "false";
                    writer.WriteLine("-FullScreen " + windowmodebooleanString);
                }
                else if (this.windowmodeComboBox.SelectedItem.ToString() == "Fullscreen")
                {
                    string windowmodebooleanString = "true";
                    writer.WriteLine("-FullScreen " + windowmodebooleanString);
                }
                else
                {
                    Console.WriteLine("Invalid window mode");
                }
                // making resolution x and y
                writer.WriteLine("-ResolutionX " + firstWord);
                writer.WriteLine("-ResolutionY " + secondWord);

            }
            MessageBox.Show("Options saved to file " + fileName);
            //Application.Exit();
        }

        private string[] GetAvailableGPUs()
        {
            List<string> gpus = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject videoController in searcher.Get())
            {
                string name = videoController["Name"].ToString();
                gpus.Add(name);
            }
            return gpus.ToArray();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://129.80.113.218/download/imagine_base.zip");
        }

        // Latest Update Section
        private void LoadVersionLabel()
        {
            try
            {
                // Create a web request to get the text file
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://129.80.113.218/version/ver.txt");
                request.Method = "GET";

                // Get the response from the web request
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Read the response stream and get the first line of text
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string firstLine = reader.ReadLine();

                // Set the label text to the first line of text
                label7.Text = firstLine;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error loading version label: " + ex.Message);
                label7.Text = "Error";
            }
        }
        //Your Update version section
        private void ReadCompClientFile()
        {
            try
            {
                // Open the file
                using (StreamReader reader = new StreamReader("comp_client.xml"))
                {
                    // Read the file line by line until we reach line 6
                    for (int i = 1; i <= 6; i++)
                    {
                        if (i == 6)
                        {
                            // We've reached line 6, so read the version number
                            string line = reader.ReadLine();
                            string version = line.Substring(line.IndexOf("<version>") + "<version>".Length, line.IndexOf("</version>") - line.IndexOf("<version>") - "<version>".Length);

                            // Update label9 with the version number
                            label9.Text = version;
                        }
                        else
                        {
                            // Not line 6 yet, so just read the line and move on
                            reader.ReadLine();
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                // File not found, handle the error as desired
                label9.Text = "not found";
            }
        }

        // Latest Update link download Section
        private void updatelinkdownload()
        {
            try
            {
                // Create a web request to get the text file
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://129.80.113.218/version/ver.txt");
                request.Method = "GET";

                // Get the response from the web request
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Read the response stream and get the second line of text
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string firstLine = reader.ReadLine(); // read and discard the first line
                string secondLine = reader.ReadLine(); // read the second line of text

                // Set the label text to the first line of text
                linkLabel2.Text = secondLine;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error loading version label: " + ex.Message);
                linkLabel2.Text = "Error";
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Create a web request to get the text file
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://129.80.113.218/version/ver.txt");
                request.Method = "GET";

                // Get the response from the web request
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Read the response stream and get the second line of text
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string firstLine = reader.ReadLine(); // read and discard the first line
                string secondLine = reader.ReadLine(); // read the second line of text

                // Set the label text to the first line of text
                linkLabel2.Text = secondLine;
                System.Diagnostics.Process.Start(secondLine);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error loading version label: " + ex.Message);
                linkLabel2.Text = "Error";
            }
        }

    }
}
