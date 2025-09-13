using Android.App;
using Android.Runtime;
<<<<<<< HEAD
using zjgmarketplace.modules.UI;

namespace zjgmarketplace.Modules.UI.Platforms.Android
=======

namespace zjgmarketplace.modules.UI
>>>>>>> origin/main
{
    [Application]
    public class MainApplication : MauiApplication
    {
<<<<<<< HEAD
        public MainApplication(nint handle, JniHandleOwnership ownership)
=======
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
>>>>>>> origin/main
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
