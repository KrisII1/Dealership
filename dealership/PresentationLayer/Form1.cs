using PresentationLayer.UserControls;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl;
        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new ClientControls(), new CarControls()};

            navigationControl = new NavigationControl(userControls, panel2);
            navigationControl.Display(0);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }

 
    }
}