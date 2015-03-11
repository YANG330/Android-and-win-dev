using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using $safeprojectname$.Foundation;
using $safeprojectname$.Foundation.Collections;
using $safeprojectname$.UI.Xaml;
using $safeprojectname$.UI.Xaml.Controls;
using $safeprojectname$.UI.Xaml.Controls.Primitives;
using $safeprojectname$.UI.Xaml.Data;
using $safeprojectname$.UI.Xaml.Input;
using $safeprojectname$.UI.Xaml.Media;
using $safeprojectname$.UI.Xaml.Navigation;
using $safeprojectname$.Media.Capture;
using $safeprojectname$.Storage;
using $safeprojectname$.Storage.Streams;
using $safeprojectname$.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace $safeprojectname$
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI capture = new CameraCaptureUI(); 
            capture.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
            StorageFile file = await capture.CaptureFileAsync(CameraCaptureUIMode.Photo);
            IRandomAccessStream filestream = await file.OpenAsync(FileAccessMode.Read);
            BitmapImage img = new BitmapImage();
            img.SetSource(filestream);
            img_viewer.Source = img;
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI capture = new CameraCaptureUI();
            capture.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
            StorageFile file = await capture.CaptureFileAsync(CameraCaptureUIMode.Photo);
            IRandomAccessStream filestream = await file.OpenAsync(FileAccessMode.Read);
            BitmapImage img = new BitmapImage();
            img.SetSource(filestream);
            img_viewer1.Source = img;
        }
    }
}
