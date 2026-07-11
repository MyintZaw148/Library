namespace Library.Pages
{
    using System;

    public class ToastService
    {
        public event Action<string, string, string>? OnShow;

        // Toast အမျိုးအစားအလိုက် ခေါ်ယူမည့် မက်သတ်များ
        public void ShowSuccess(string message, string title = "Success") => OnShow?.Invoke(message, title, "success");
        public void ShowError(string message, string title = "Error") => OnShow?.Invoke(message, title, "danger");
        public void ShowWarning(string message, string title = "Warning") => OnShow?.Invoke(message, title, "warning");
    }
}
