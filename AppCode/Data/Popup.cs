namespace AppCode.Data
{
    public partial class Popup
    {
        // Add your own properties and methods here

        public new PopupSettings Presentation => _presentation ??= As<PopupSettings>(base.Presentation);
        private PopupSettings _presentation;

    }
}
