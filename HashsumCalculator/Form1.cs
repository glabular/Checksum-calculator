using System.Diagnostics;
using XAct;

namespace HashsumCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _textBoxes = new List<TextBox>()
            {
                textBoxSHA1,
                textBoxSHA256,
                textBoxSHA384,
                textBoxSHA512,
                textBoxMD5
            };
            _checkBoxes = new List<CheckBox>()
            {
                checkBoxSHA256,
                checkBoxSHA384,
                checkBoxSHA512,
                checkBoxSHA1,
                checkBoxMD5,
                checkBoxSelectAllAlgorithms
            };            
        }

        private bool _toLower = true;
        private ToolTip _fileNameToolTip = new();
        private ToolTip _copyToClipBoardToolTip = new();
        private string? _fileName;
        private List<TextBox> _textBoxes;
        private List<CheckBox> _checkBoxes;
        private string _checksumSHA256;
        private string _checksumSHA384;
        private string _checksumSHA512;
        private string _checksumSHA1;
        private string _checksumMD5;

        private string ChecksumSHA256
        {
            get 
            { 
                return _toLower ? _checksumSHA256.ToLower() : _checksumSHA256; 
            }
            set { _checksumSHA256 = value; }
        }
        
        public string ChecksumSHA384
        {
            get
            {
                return _toLower ? _checksumSHA384.ToLower() : _checksumSHA384;
            }
            set { _checksumSHA384 = value; }
        }        

        public string ChecksumSHA512
        {
            get
            {
                return _toLower ? _checksumSHA512.ToLower() : _checksumSHA512;
            }
            set { _checksumSHA512 = value; }
        }       

        public string ChecksumSHA1
        {
            get
            {
                return _toLower ? _checksumSHA1.ToLower() : _checksumSHA1;
            }
            set { _checksumSHA1 = value; }
        }

        public string ChecksumMD5
        {
            get
            {
                return _toLower ? _checksumMD5.ToLower() : _checksumMD5;
            }
            set { _checksumMD5 = value; }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {            
            Pen pen = new(Color.Black, 3);
            pen.DashPattern = new float[] { 3, 1 };
            Graphics g = panel1.CreateGraphics();
            g.DrawRectangle(pen, 1, 1, panel1.Width - 3, panel1.Height - 3);
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private async void panel1_DragDrop(object sender, DragEventArgs e)
        {
            panel1.Invalidate();

            var algorithmsSelected = false;

            foreach (var item in _checkBoxes)
            {
                if (item.Checked)
                {
                    algorithmsSelected = true;
                    break;
                }
            }

            if (algorithmsSelected == false)
            {
                CommonMethods.ShowPopupErrorMessagebox("Внимание!", "Не выбран ни один алгоритм хэширования");
                return;
            }

            
            ClearAllTextBoxes();
            DisableAllCheckboxes();
            Activate(); // Фокус на окно.
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            var filePath = file[0].ToString();
            _fileName = Path.GetFileName(filePath);
            groupBox2.Text = $"Чек-суммы файла {_fileName}:";

            ChecksumSHA256 = string.Empty;
            ChecksumSHA384 = string.Empty;
            ChecksumSHA512 = string.Empty;
            ChecksumSHA1 = string.Empty;
            ChecksumMD5 = string.Empty;

            if (checkBoxSHA1.Checked)
            {
                ActivateProgressBar(progressBarSHA1);
            }

            if (checkBoxSHA256.Checked)
            {
                ActivateProgressBar(progressBarSHA256);
            }

            if (checkBoxSHA384.Checked)
            {
                ActivateProgressBar(progressBarSHA384);
            }

            if (checkBoxSHA512.Checked)
            {
                ActivateProgressBar(progressBarSHA512);
            }

            if (checkBoxMD5.Checked)
            {
                ActivateProgressBar(progressBarMD5);
            }

            var sw = new Stopwatch();
                         

            if (CommonInfo.EatRAM)
            {
                if (CommonInfo.EnableStopwatch)
                {
                    sw.Start();
                }

                Task<string> SHA1task = null;
                Task<string> SHA256task = null;
                Task<string> SHA384task = null;
                Task<string> SHA512task = null;
                Task<string> MD5task = null;

                var fileToCalculate = await File.ReadAllBytesAsync(filePath);
                var filelist = new List<byte[]>();
                var taskList = new List<Task>();

                if (checkBoxSHA1.Checked)
                {
                    SHA1task = Task.Run(() => SHA1Checksum.GetSHA1Checksum(filePath));
                    taskList.Add(SHA1task);
                }

                await Task.Run(() => 
                {
                    for (int i = 0; i < 3; i++)
                    {
                        filelist.Add((byte[])fileToCalculate.Clone());
                    }
                });                                

                if (checkBoxSHA256.Checked)
                {
                    SHA256task = Task.Run(() => SHA256Checksum.GetSHA256Checksum(fileToCalculate));
                    taskList.Add(SHA256task);
                }

                if (checkBoxSHA384.Checked)
                {
                    SHA384task = Task.Run(() => SHA384Checksum.GetSHA384Checksum(filelist[0]));
                    taskList.Add(SHA384task);
                }

                if (checkBoxSHA512.Checked)
                {
                    SHA512task = Task.Run(() => SHA512Checksum.GetSHA512Checksum(filelist[1]));
                    taskList.Add(SHA512task);
                }

                if (checkBoxMD5.Checked)
                {
                    MD5task = Task.Run(() => MD5Checksum.GetMD5Checksum(filelist[2]));
                    taskList.Add(MD5task);
                }

                await Task.Run(() =>
                {
                    Task.WaitAll(taskList.ToArray());
                });


                if (checkBoxSHA1.Checked)
                {
                    ChecksumSHA1 = SHA1task.Result;
                    textBoxSHA1.Text = ChecksumSHA1;
                }

                if (checkBoxSHA256.Checked)
                {
                    ChecksumSHA256 = SHA256task.Result;
                    textBoxSHA256.Text = ChecksumSHA256;
                }

                if (checkBoxSHA384.Checked)
                {
                    ChecksumSHA384 = SHA384task.Result;
                    textBoxSHA384.Text = ChecksumSHA384;
                }

                if (checkBoxSHA512.Checked)
                {
                    ChecksumSHA512 = SHA512task.Result;
                    textBoxSHA512.Text = ChecksumSHA512;
                }

                if (checkBoxMD5.Checked)
                {
                    ChecksumMD5 = MD5task.Result;
                    textBoxMD5.Text = ChecksumMD5;
                }

                progressBarSHA1.Visible = false;
                progressBarMD5.Visible = false;
                progressBarSHA384.Visible = false;
                progressBarSHA512.Visible = false;
                progressBarSHA256.Visible = false;

                if (CommonInfo.EnableStopwatch)
                {
                    sw.Stop();
                    TimeSpan timeSpan = sw.Elapsed;

                    MessageBox.Show($"Потраченное время:\n{timeSpan.Hours}ч {timeSpan.Minutes}м {timeSpan.Seconds}c {timeSpan.Milliseconds}мс", "Секундомер",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
                
            }
            else
            {
                if (CommonInfo.EnableStopwatch)
                {
                    sw.Start();
                }

                if (checkBoxSHA1.Checked)
                {
                    ChecksumSHA1 = await Task.Run(() => SHA1Checksum.GetSHA1Checksum(filePath));
                    progressBarSHA1.Visible = false;
                    textBoxSHA1.Text = ChecksumSHA1;
                }

                if (checkBoxSHA256.Checked)
                {
                    ChecksumSHA256 = await Task.Run(() => SHA256Checksum.GetSHA256Checksum(filePath));
                    progressBarSHA256.Visible = false;
                    textBoxSHA256.Text = ChecksumSHA256;
                }

                if (checkBoxSHA384.Checked)
                {
                    ChecksumSHA384 = await Task.Run(() => SHA384Checksum.GetSHA384Checksum(filePath));
                    progressBarSHA384.Visible = false;
                    textBoxSHA384.Text = ChecksumSHA384;
                }

                if (checkBoxSHA512.Checked)
                {
                    ChecksumSHA512 = await Task.Run(() => SHA512Checksum.GetSHA512Checksum(filePath));
                    progressBarSHA512.Visible = false;
                    textBoxSHA512.Text = ChecksumSHA512;
                }

                if (checkBoxMD5.Checked)
                {
                    ChecksumMD5 = await Task.Run(() => MD5Checksum.GetMD5Checksum(filePath));
                    progressBarMD5.Visible = false;
                    textBoxMD5.Text = ChecksumMD5;
                }

                if (CommonInfo.EnableStopwatch)
                {
                    sw.Stop();

                    TimeSpan timeSpan = sw.Elapsed;

                    MessageBox.Show($"Потраченное время:\n{timeSpan.Hours}ч {timeSpan.Minutes}м {timeSpan.Seconds}c {timeSpan.Milliseconds}мс", "Секундомер",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
            }            

            EnableAllCheckboxes();
            GC.Collect();

            static void ActivateProgressBar(ProgressBar progressBar)
            {
                progressBar.Visible = true;
                progressBar.Style = ProgressBarStyle.Marquee;
                progressBar.MarqueeAnimationSpeed = 10;
            }
        }        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var textBox in _textBoxes)
            {
                if (textBox.Text != string.Empty || textBox.Text != null)
                {
                    if (checkBox1.Checked)
                    {
                        _toLower = true;
                        textBox.Text = textBox.Text.ToLower();
                    }
                    else
                    {
                        _toLower = false;
                        textBox.Text = textBox.Text.ToUpper();
                    }
                }
            }
        }

        private void ClearAllTextBoxes()
        {
            foreach (var txtBox in _textBoxes)
            {
                txtBox.Text = string.Empty;
            }
        }

        private void DisableAllCheckboxes()
        {
            foreach (var checkBox in _checkBoxes)
            {
                checkBox.Enabled = false;
            }
        }
        private void EnableAllCheckboxes()
        {
            foreach (var checkBox in _checkBoxes)
            {
                checkBox.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(".NET предоставляет следующие алгоритмы хэширования: SHA-2 (включает SHA256, SHA384 и SHA512), MD5 и SHA1. Обратите внимание, что алгоритмы MD5 и SHA-1 были признаны небезопасными, рекомендуется использовать SHA-2.",
                    "Алгоритмы хэширования, предоставляемые .NET",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
        }

        private void checkBoxSelectAllAlgorithms_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var checkBox in _checkBoxes)
            {
                checkBox.Checked = checkBoxSelectAllAlgorithms.Checked;
            }
        }

        // Отобразить имя файла во всплывающей подсказке при наведении
        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            //ToDo 1) Старое имя файла не убирается
            //_fileNameToolTip.SetToolTip(groupBox2, _fileName);
        }

        private void buttonCopyToClipboard_MouseHover(object sender, EventArgs e)
        {
            _copyToClipBoardToolTip.SetToolTip((Control)sender, "Скопировать чек-сумму в буфер обмена");
        }

        private void buttonCopySHA256_Click(object sender, EventArgs e)
        {
            if (!_checksumSHA256.IsNullOrEmpty())
            {
                Clipboard.SetText(ChecksumSHA256);
            }
        }

        private void buttonCopySHA384_Click(object sender, EventArgs e)
        {
            if (!_checksumSHA384.IsNullOrEmpty())
            {
                Clipboard.SetText(ChecksumSHA384);
            }
        }

        private void buttonCopySHA512_Click(object sender, EventArgs e)
        {
            if (!_checksumSHA512.IsNullOrEmpty())
            {
                Clipboard.SetText(ChecksumSHA512);
            }
        }

        private void buttonCopySHA1_Click(object sender, EventArgs e)
        {
            if (!_checksumSHA1.IsNullOrEmpty())
            {
                Clipboard.SetText(ChecksumSHA1);
            }
        }

        private void buttonCopyMD5_Click(object sender, EventArgs e)
        {
            if (!_checksumMD5.IsNullOrEmpty())
            {
                Clipboard.SetText(ChecksumMD5);
            }            
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
            groupBox2.Text = "Статус: ОК";

            //ToDo 1) Старое имя файла не убирается
            //_fileNameToolTip.SetToolTip(groupBox2, "Статус: ОК"); 
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CommonInfo.EatRAM = checkBoxEatRAM.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный режим вычисляет все хэш-суммы быстрее, но расходует большое количество оперативной памяти.\n" +
                    "Рекомендуется использовать в системах с 16 ГБ оперативной памяти или больше", "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
        }

        private void checkBoxStopWatch_CheckedChanged(object sender, EventArgs e)
        {
            CommonInfo.EnableStopwatch = checkBoxStopWatch.Checked;
        }

        private void checkBoxMD5_CheckedChanged(object sender, EventArgs e)
        {
            DisableAllCheckboxes();
            checkBoxEatRAM.Enabled = false;
        }
    }
}