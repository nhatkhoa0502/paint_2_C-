namespace Paint2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_shapes_Click(object sender, EventArgs e)
        {
            if(panel_shapes.Height == 306)
            {
                panel_shapes.Height = 100;                
            }
            else
            {
                panel_shapes.Height = 306;                
            }
        }   
    }
}