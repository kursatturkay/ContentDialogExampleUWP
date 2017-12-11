using System;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;


namespace ContentDialogExample.UserControls
{
    public sealed partial class SystemAccessControl : UserControl
    {
        public async static void SystemAccess()
        {
            var access = new SystemAccessControl();
            ContentDialog dlg = new ContentDialog();
            dlg.PrimaryButtonText = "Proceed";
            dlg.PrimaryButtonClick += Dlg_PrimaryButtonClick;

            dlg.SecondaryButtonText = "Cancel";
            dlg.SecondaryButtonClick += Dlg_SecondaryButtonClick;

            dlg.Title = "System Access";
            dlg.Content = access;
            await dlg.ShowAsync();
        }

        private static void Dlg_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private async static void Dlg_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            var dlg = sender.Content as SystemAccessControl;

            if (dlg.textBoxUserName.Text == "kursat" && dlg.textBoxPassword.Password == "123456")
            { }
            else
            {
                args.Cancel = true;
                MessageDialog msgdlg = new MessageDialog("", "Access Denied");
                await msgdlg.ShowAsync();
            }
        }

        public SystemAccessControl()
        {
            this.InitializeComponent();
        }
    }
}
