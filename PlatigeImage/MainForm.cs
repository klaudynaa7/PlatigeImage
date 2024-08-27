using PlatigeImage.Data;

namespace PlatigeImage
{
    public partial class MainForm : Form
    {
        private readonly ApplicationDbContext _dbContext;

        public MainForm(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
        }
    }
}
