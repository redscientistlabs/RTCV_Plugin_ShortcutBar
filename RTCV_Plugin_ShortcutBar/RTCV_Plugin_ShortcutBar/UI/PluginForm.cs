namespace SHORTCUTBAR.UI
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using NLog;
    using RTCV.CorruptCore;

    using RTCV.Common;
    using RTCV.UI;
    using static RTCV.CorruptCore.RtcCore;
    using RTCV.Vanguard;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Runtime.InteropServices;
    using System.Drawing.Imaging;
    using RTCV.NetCore;
    using System.Diagnostics;
    using System.Net;
    using System.Collections.Specialized;

    using System.IO.Compression;
    using System.Windows.Documents.Serialization;
    using RTCV.UI.Modular;
    using RTCV.NetCore.NetCoreExtensions;

    public partial class PluginForm : ComponentForm, IColorize
    {
        public SHORTCUTBAR plugin;

        public volatile bool HideOnClose = true;

        Logger logger = NLog.LogManager.GetCurrentClassLogger();

        WebClient wc = new WebClient();

        //This dictionary will inflate forever but it would take quite a while to be noticeable.
        Dictionary<string, bool> encounteredIds = new Dictionary<string, bool>();


        List<Button> registeredButtons = new List<Button>();

        public PluginForm(SHORTCUTBAR _plugin)
        {
            plugin = _plugin;

            this.InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.PluginForm_FormClosing);
            this.Text = "Shortcut Bar";// CORRUPTCLOUD_LIVE.CamelCase(nameof(CORRUPTCLOUD_LIVE).Replace("_", " ")); //automatic window title

        }


        private void PluginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HideOnClose)
            {
                e.Cancel = true;
                this.Hide();
            }
        }


        private void PluginForm_Load(object sender, EventArgs e)
        {
            Controls.Remove(btnTest);

            ReloadFromParams();
            RefreshButtons();

        }

        private void btnAddShortcut_MouseDown(object sender, MouseEventArgs e)
        {
            var Hotkeys = UICore.HotkeyBindings;


            Point locate = e.GetMouseLocation(sender);

            ContextMenuStrip openCustomLayoutMenu = new ContextMenuStrip();

            foreach (var binding in Hotkeys)
            {
                openCustomLayoutMenu.Items.Add($"{binding.TabGroup} -> {binding.DisplayName}", null, new EventHandler((ob, ev) =>
                {
                    AddHotkeyToButtons(binding);
                    RefreshButtons();
                    SaveToParams();
                }));
            }

            openCustomLayoutMenu.Show(this, locate);

        }

        private void AddHotkeyToButtons(RTCV.UI.Input.Binding binding)
        {
            var exist = registeredButtons.FirstOrDefault(iterator => iterator.Text == binding.DisplayName);
            if (exist != null)
                registeredButtons.Remove(exist);

            Button b = new Button();// (Button)ObjectCopier.Clone(btnTest
            b.BackColor = btnTest.BackColor;
            b.ForeColor = btnTest.ForeColor;
            b.FlatAppearance.BorderSize = btnTest.FlatAppearance.BorderSize;
            b.FlatStyle = btnTest.FlatStyle;
            b.Size = btnTest.Size;
            b.Tag = binding.DisplayName;
            b.Text = $"{ binding.TabGroup} -> { binding.DisplayName}";

            b.Click += (o, e) =>
            {
                LocalNetCoreRouter.Route(RTCV.NetCore.Endpoints.UI, RTCV.NetCore.Commands.Remote.TriggerHotkey, binding.DisplayName);
            };

            registeredButtons.Add(b);
        }

        private void btnRemoveShortcut_MouseDown(object sender, MouseEventArgs e)
        {
            var Hotkeys = UICore.HotkeyBindings;


            Point locate = e.GetMouseLocation(sender);

            ContextMenuStrip openCustomLayoutMenu = new ContextMenuStrip();

            foreach (var button in registeredButtons)
            {
                openCustomLayoutMenu.Items.Add($"{button.Text}", null, new EventHandler((ob, ev) =>
                {
                    registeredButtons.Remove(button);
                    if (Controls.Contains(button))
                        Controls.Remove(button);

                    RefreshButtons();
                    SaveToParams();
                }));
            }

            openCustomLayoutMenu.Show(this, locate);

        }

        public void RefreshButtons()
        {
            for (int i = 0; i < registeredButtons.Count; i++)
            {
                var button = registeredButtons[i];

                int xpos = btnTest.Location.X;
                int ypos = ((btnTest.Location.Y + btnTest.Size.Height) * (i + 1)) - btnTest.Size.Height;

                if (!Controls.Contains(button))
                    Controls.Add(button);

                button.Location = new Point(xpos, ypos);
                button.Visible = true;

            }
        }

        public void ReloadFromParams()
        {
            if (Params.IsParamSet("PLUGIN_SHORTCUTBAR"))
            {
                var param = Params.ReadParam("PLUGIN_SHORTCUTBAR");

                var values = param.Split('|');
                var binds = GetBindingsFromStrings(values);
                foreach (var bind in binds)
                    AddHotkeyToButtons(bind);

                SaveToParams();
            }
        }

        public void SaveToParams()
        {
            string value = String.Join("|", registeredButtons.Select(it => it.Tag.ToString()));
            Params.SetParam("PLUGIN_SHORTCUTBAR", value);

        }

        public List<RTCV.UI.Input.Binding> GetBindingsFromStrings(string[] values)
        {
            var Hotkeys = UICore.HotkeyBindings;
            List<RTCV.UI.Input.Binding> binds = new List<RTCV.UI.Input.Binding>();

            foreach(var value in values)
            {
                var bind = UICore.HotkeyBindings.FirstOrDefault(iterator => iterator.DisplayName == value);
                if (bind != null)
                    binds.Add(bind);
            }

            return binds;
        }

    }

}
