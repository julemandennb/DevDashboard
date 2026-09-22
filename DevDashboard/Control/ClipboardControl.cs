using Clipboard.Windows;
using DevDashboard.Help;
using Settings.Models;
using System;
using System.Windows.Forms;
using ClipboardHistory = Clipboard.ClipboardHistory;

namespace DevDashboard.Control
{
    public partial class ClipboardControl : UserControl
    {
        private ClipboardSetting _clipboardSetting;


        private readonly WindowsClipboardReader _clipboardReader;
        private readonly ClipboardHistory _clipboardHistory;
        private readonly System.Windows.Forms.Timer _timerCheckClipboard;

        public ClipboardControl(bool darkModeOn)
        {
            darkMode = darkModeOn;

            InitializeComponent();

            _clipboardReader =
                new WindowsClipboardReader();

            _clipboardHistory =
                new ClipboardHistory(15);

            _timerCheckClipboard =
                new System.Windows.Forms.Timer
                {
                    Interval = 1000
                };

            _timerCheckClipboard.Tick +=
                SaveToClipboardHistory;

            OpdateSetting();


        }

        public void OpdateSetting()
        {
           
            _clipboardSetting = SettingLibHelp.GetSettingsFile<ClipboardSetting>().Load();
            _clipboardHistory.SetNewMax(_clipboardSetting.Max);
            _timerCheckClipboard.Enabled = _clipboardSetting.Ison;

        }


        private void SaveToClipboardHistory(
            object? sender,
            EventArgs e)
        {
            var item =
                _clipboardReader.Read();

            if (item == null)
                return;

            _clipboardHistory.Add(item);

            ClipboardHistoryChanged();

        }

        private void ClipboardHistoryChanged()
        {
            clipboardHistoryPanel.SuspendLayout();

            try
            {
                clipboardHistoryPanel.Controls.Clear();

                foreach (var item in _clipboardHistory.GetList())
                {
                    var label = new Label
                    {
                        Text = item.TextToShow,

                        AutoSize = false,

                        Width =
                            clipboardHistoryPanel.ClientSize.Width - 20,

                        Height = 60,

                        Padding =
                            new Padding(10),

                        Margin =
                            new Padding(0, 0, 0, 8),

                        BackColor =
                            DarkMode
                                ? Color.FromArgb(28, 28, 30)
                                : Color.White,

                        ForeColor =
                            DarkMode
                                ? Color.Gainsboro
                                : Color.Black,

                        Font =
                            new Font(
                                "Segoe UI",
                                10F),

                        TextAlign =
                            ContentAlignment.MiddleLeft
                    };

                    clipboardHistoryPanel.Controls.Add(label);
                }
            }
            finally
            {
                clipboardHistoryPanel.ResumeLayout();
            }
        }
    }
}