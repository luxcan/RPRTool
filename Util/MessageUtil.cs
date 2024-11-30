namespace RPRTool.Util {
    public class MessageUtil {
        public static void Error(string message, string title = "Error") {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}