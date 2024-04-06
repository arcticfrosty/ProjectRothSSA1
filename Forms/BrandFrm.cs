using ProjectRothSSA1.Models.Data;
using ProjectRothSSA1.Services;

namespace ProjectRothSSA1.Forms {
    public partial class BrandFrm : Form {
        private readonly Ssa1bikeStoreContext _context;
        private string? status, message;
        public BrandFrm(Ssa1bikeStoreContext context) {
            InitializeComponent();
            _context = context;
        }

        private void BrandFrm_Load(object sender , EventArgs e) {
            getBrand();
            dgBrand.Columns[0].HeaderText = "Brand ID";
            dgBrand.Columns[1].HeaderText = "Brand Name";
        }

        protected void getBrand() {
            string[,] sp_par = {
                { "brand_id", "" },
            };
            dgBrand.DataSource = CRUDService.execCRUD(_context , "production.brand_list" , sp_par);
        }

        protected void cudBrand(string cud) {
            string[,] sp_par = {
                { "brand_id", txtBrId.Text },
                { "brand_name", txtBrName.Text },
                { "cud", cud },
            };
            var rv = CRUDService.execCRUD(_context , "production.brand_cud" , sp_par);
            if (rv != null) {
                status = rv.Rows[0][0].ToString();
                message = rv.Rows[0]["cud_msg"].ToString();
                if (status == "Succeed") {
                    getBrand();
                }
                txtBrId.Clear();
                txtBrName.Clear();
            } else {
                status = "Error";
                message = "Something went wrong!";
            }
            MsgService.doMsg(status , message);
        }

        private void saveBtn_Click(object sender , EventArgs e) {
            if (MsgService.doQuestion("Do you want to save?") == DialogResult.Yes) {
                cudBrand("C");
            }
        }

        private void dgBrand_CellContentDoubleClick(object sender , DataGridViewCellEventArgs e) {
            txtBrId.Text = dgBrand.SelectedRows[0].Cells[0].Value.ToString();
            txtBrName.Text = dgBrand.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void updateBtn_Click(object sender , EventArgs e) {
            if (MsgService.doQuestion("Do you want to update?") == DialogResult.Yes) {
                if (!string.IsNullOrEmpty(txtBrId.Text) && !string.IsNullOrEmpty(txtBrName.Text)) {
                    cudBrand("U");
                } else {
                    MsgService.doMsg("Error" , "Missing input value!");
                }
            }
        }

        private void deleteBtn_Click(object sender , EventArgs e) {
            if (MsgService.doQuestion("Do you want to delete?") == DialogResult.Yes) {
                if (!string.IsNullOrEmpty(txtBrId.Text) && !string.IsNullOrEmpty(txtBrName.Text)) {
                    cudBrand("D");
                } else {
                    MsgService.doMsg("Error" , "Missing input value!");
                }
            }
        }
    }
}
