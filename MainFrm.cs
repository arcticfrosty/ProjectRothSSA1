using ProjectRothSSA1.Models.Data;

namespace ProjectRothSSA1 {
    public partial class MainFrm : Form {
        private readonly Ssa1bikeStoreContext _context;

        public MainFrm(Ssa1bikeStoreContext context) {
            InitializeComponent();
            _context = context;
        }

        private void brandToolStripMenuItem_Click(object sender , EventArgs e) {
            Form frm = new Forms.BrandFrm(_context);
            frm.Show();
            return;
        }
    }
}
