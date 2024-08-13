using System.Drawing.Design;
using System.Drawing.Text;

namespace FontExplorer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowFonts();
        }

        private void ShowFonts()
        {
            string text = tbText.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(this, "Empty text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fontContainer.Controls.Clear();

            // get all the fonts
            Padding padding = new Padding(10);
            using (InstalledFontCollection installedFontCollection = new())
            {
                var families = installedFontCollection.Families;
                foreach (var family in families.Where(f => f.IsStyleAvailable(FontStyle.Bold)))
                {
                    Label label = new()
                    {
                        Text = text,
                        Tag = family,
                        Font = new Font(family, 16.0f),
                        Margin = padding
                    };

                    label.Click += (sender, e) =>
                    {
                        fontContainer.Controls.Remove(label);
                    };

                    toolTip1.SetToolTip(label, family.Name);
                    fontContainer.Controls.Add(label);
                }
            }


        }

        private void Main_Shown(object sender, EventArgs e)
        {
            tbText.Focus();
        }
    }
}
