using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-GFLTFQM\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadHoadDon() //Tai lai man hinh chinh
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //Ham nay dung de ket noi du lieu
        {
            this.Text = "Thong tin hoa don application";
            connection = new SqlConnection(str);
            connection.Open();
            loadHoadDon();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)//Hien thi textbox khi ta chon mot cell nao do
        {
            int count = 0;
            count = dgv.CurrentRow.Index;
            tb_MAHD.Text = dgv.Rows[count].Cells[0].Value.ToString();
            tb_MAKH.Text= dgv.Rows[count].Cells[1].Value.ToString();
            dtime_ngaylap.Text = dgv.Rows[count].Cells[2].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)//Button them insert vao bang Hoadon
        {
            if(tb_MAHD.Text==""|| tb_MAKH.Text == "")
            {
                MessageBox.Show("Phai nhap du lieu truoc !!!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if(tb_MAHD.Text.Length != 9 || tb_MAKH.Text.Length != 9)
            {
                MessageBox.Show("Du lieu khong hop le !!!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command = connection.CreateCommand();
            command.CommandText = "insert into HoaDon(MAHD,MAKH,NGAYLAP) values('"+tb_MAHD.Text+"','"+tb_MAKH.Text+"','"+dtime_ngaylap.Value.ToString()+"')";
            command.ExecuteNonQuery();
            loadHoadDon();
            
        }

        void loadThongKeTheoThang(int thang)
        {
            command = connection.CreateCommand();
            command.CommandText = "select MaHD,Month(NgayLap) as Thang, " +
                "Sum(TongTien) as DoanhThuTheoThang from HoaDon where MONTH(NgayLap) = '"+thang+"' group by MAHD,NgayLap ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }






        private void panel1_Paint(object sender, PaintEventArgs e)//Dummy function
        {

        }

        private void tb_doanhthu_TextChanged(object sender, EventArgs e) //Thong ke theo thang
        {
            if (tb_doanhthu.Text == "")
            {
                loadHoadDon();
                return;
            }
            if (tb_doanhthu.Text.All(char.IsDigit) == false)
            {
                loadHoadDon();
                MessageBox.Show("Nhap Thang Sai!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int num = int.Parse(tb_doanhthu.Text);
            if(num >=1 && num <= 12)
            {
                loadThongKeTheoThang(num);
            }
            else
            {
                MessageBox.Show("Nhap Thang Sai!!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                loadHoadDon();
            }
        }

        private void bt_khoitao_Click(object sender, EventArgs e)
        {
            tb_MAHD.Text = "";
            tb_MAKH.Text = "";
        }
    }
}
