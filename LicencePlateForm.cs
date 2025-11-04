namespace LicencePlateManager
{
    public partial class LicencePlateForm : Form
    {
        public LicencePlateForm()
        {
            InitializeComponent();
            var FocusText = new MouseEventHandler((s, e) => textBox1.Focus());
            lstUntagged.MouseDoubleClick += FocusText;
            lstTagged.MouseDoubleClick += FocusText;
        }

    }
}
