using RPRTool.Util;

namespace RPRTool {
    public partial class Form : System.Windows.Forms.Form {
        public Form() {
            InitializeComponent();
        }

        private void btnClearResult_Click(object sender, EventArgs e) {
            tboxResult.Clear();
        }

        #region Sim Time
        private void btnSimTime_Click(object sender, EventArgs e) {
            CalculateSimTime(0);
        }

        private void btnSimTimeAddMins_Click(object sender, EventArgs e) {
            if (!int.TryParse(txtSimTimeAddMins.Text.Trim(), out int addMins)) {
                MessageUtil.Error("Please key in a valid value.");
                return;
            }

            CalculateSimTime(addMins);
        }

        private void CalculateSimTime(int minutes) {
            var nowInSec = DateTimeOffset.UtcNow.AddMinutes(minutes).ToUnixTimeSeconds();
            var totalHrs = nowInSec / 3600.0;
            var hrsSinceEpoch = Math.Floor(totalHrs);

            tboxResult.AppendText("Hours: " + hrsSinceEpoch);

            var fractionalHr = totalHrs - hrsSinceEpoch;
            var timePastTheHr = Math.Floor(fractionalHr * (Math.Pow(2, 31) - 1));
            tboxResult.AppendText("\nTimePastTheHour: " + timePastTheHr);
            tboxResult.AppendText("\n\n");
        }
        #endregion

        private void btnAsciiConvert_Click(object sender, EventArgs e) {
            var textToAscii = txtAscii.Text.Trim();
            tboxResult.AppendText($"Converting [{textToAscii}] to ASCII:");
            foreach (var c in textToAscii) {
                tboxResult.AppendText($"\nCharacter: {c}, ASCII Code: " + (int)c);
            }
            tboxResult.AppendText("\n\n");
        }

        private void btnDoubleToByteArray_Click(object sender, EventArgs e) {
            var textToDouble = txtDoubleToByteArray.Text.Trim();
            if (!double.TryParse(textToDouble, out double doubleValue)) {
                MessageUtil.Error("Please key in a valid value.");
                return;
            }

            tboxResult.AppendText($"Converting [{doubleValue}] to byte arrays (big-endian):");
            var bytes = BitConverter.GetBytes(doubleValue);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(bytes);
            }

            foreach (var b in bytes) {
                tboxResult.AppendText($"\n{b}");
            }

            tboxResult.AppendText("\n\n");
        }
    }
}