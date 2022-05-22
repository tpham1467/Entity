﻿using BLL;
using Entity;
using PBL3_Remake.frmGUISeller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.frmGUISeller
{
    public partial class frmOrder : Form
    {
        public int IDTable { get; set; }
        private int IDLoaiMonAn = 1;
        private int CurrentNumberOfDish = 0;
        List<MonAn_View> listMonAnViewDaDat;
        List<MonAn_View> listMonAnViewDangDat;
        public frmOrder(int id)
        {
            IDTable = id;
            InitializeComponent();
            listMonAnViewDangDat = new List<MonAn_View>();
            listMonAnViewDaDat = BLLNVNH.Instance.GetListMonAnByIDBan(IDTable);
            dgvOrder.DataSource = listMonAnViewDaDat;
            LoadDataGridView(listMonAnViewDaDat);
            //AddButtonDataGridView();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            lblIDTable.Text = BLL.BLLNVNH.Instance.GetBanByID_Ban(IDTable).ID_Ban.ToString();
            lblNameTable.Text = BLL.BLLNVNH.Instance.GetBanByID_Ban(IDTable).TenBan;
            pnDish.AutoScroll = true;
            GetDishByKind(IDLoaiMonAn);
            foreach (MonAn_View view in listMonAnViewDaDat)
            {
                Console.WriteLine(view.TenMonAn);
            }
        }
        private void SetDish(Panel pn, DishForOrdering dsh)
        {
            dsh.Width = 180;
            dsh.Height = 180;
            pn.Controls.Add(dsh);
            //dsh.GUIForDish();
        }
        private void AddButtonDataGridView(List<MonAn_View> lt)
        {
            if (lt.Count != CurrentNumberOfDish)
            {
                dgvOrder.Columns.Clear();
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Text = "Delete";
                btn.HeaderText = "";
                btn.Name = "btnDeleteDish";
                btn.UseColumnTextForButtonValue = true;
                dgvOrder.Columns.Add(btn);
            }
        }
        private void LoadDataGridView(List<MonAn_View> lt)
        {
            if (lt != null)
            {
                dgvOrder.Columns[0].Visible = false;
                dgvOrder.Columns[1].HeaderText = "Name dish";
                dgvOrder.Columns[2].HeaderText = "Number";
                dgvOrder.Columns[3].HeaderText = "Total";
                dgvOrder.DataSource = lt;
                AddButtonDataGridView(lt);
            }
        }
        private void RemoveDish()
        {
            pnDish.Controls.Clear();
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        private void LoadDishOnDatagridview(MonAn MonAn)
        {
            bool checkMonAnExisted = false;
            foreach (MonAn_View i in listMonAnViewDangDat)
            {
                if (i.ID_MonAn == MonAn.ID_MonAn)
                {
                    i.SoLuong++;
                    i.ThanhTien += MonAn.ThanhTien;
                    checkMonAnExisted = true;
                    break;
                }
            }
            if (!checkMonAnExisted)
            {
                listMonAnViewDangDat.Add(new MonAn_View { ID_MonAn = MonAn.ID_MonAn, TenMonAn = MonAn.TenMonAn, SoLuong = 1, ThanhTien = MonAn.ThanhTien });
            }
            List<MonAn_View> list = new List<MonAn_View>();
            list.AddRange(listMonAnViewDaDat);
            list.AddRange(listMonAnViewDangDat);
            LoadDataGridView(list);
            CurrentNumberOfDish = list.Count;

        }
        private void GetDishByKind(int idloaimonan)
        {
            int somon = BLL.BLLNVNH.Instance.NumberOfKindDish(idloaimonan);
            DishForOrdering[] dsh = new DishForOrdering[somon];
            int dem1 = 0;
            foreach (MonAn i in BLL.BLLNVNH.Instance.GetAllDishByIDKindOfDish(idloaimonan))
            {
                dsh[dem1] = new DishForOrdering(i);
                dsh[dem1].d = new DishForOrdering.Mydel(LoadDishOnDatagridview);
                dem1++;
            }
            if (somon != 0)
            {
                for (int i = 0; i < dsh.Length; i++)
                {
                    int Lx = 0, Ly = 0;
                    if (i % 4 == 0) Lx = 25;
                    else if (i % 4 == 1)
                    {
                        Lx = 235;
                    }
                    else if (i % 4 == 2)
                    {
                        Lx = 440;
                    }
                    else if (i % 4 == 3)
                    {
                        Lx = 645;
                    }
                    int thuong = Convert.ToInt32(i / 4);
                    Ly = 25 + 230 * thuong;
                    dsh[i].SetLocation(Lx, Ly);
                    SetDish(pnDish, dsh[i]);
                }
            }

        }

        private void btnAppetizer_Click(object sender, EventArgs e)
        {
            IDLoaiMonAn = 1;
            RemoveDish();
            GetDishByKind(IDLoaiMonAn);
        }

        private void btnMainDish_Click(object sender, EventArgs e)
        {
            IDLoaiMonAn = 2;
            RemoveDish();
            GetDishByKind(IDLoaiMonAn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDLoaiMonAn = 3;
            RemoveDish();
            GetDishByKind(IDLoaiMonAn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDLoaiMonAn = 4;
            RemoveDish();
            GetDishByKind(IDLoaiMonAn);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            btnPay.Enabled = false;
            RemoveDish();
            frmPay frm = new frmPay(IDTable);
            frm.MdiParent = this;
            pnDish.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            pnDish.AutoScroll = false;
            frm.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dgvOrder.CurrentRow.Cells[0].Value.ToString() + " " + dgvOrder.CurrentRow.Cells[1].Value.ToString()
                                + " " + dgvOrder.CurrentRow.Cells[2].Value.ToString());
            if (e.ColumnIndex == 0)
            {
                //string message = "You have deleted " + dgvOrder.CurrentRow.Cells[2].Value.ToString();
                //NoticeBox nt = new NoticeBox(message);
                //nt.Show();
                //foreach (MonAn_View i in listMonAnViewDaDat)
                //{
                //    if (i.TenMonAn == dgvOrder.CurrentRow.Cells[2].Value.ToString())
                //    {
                //        Console.WriteLine(dgvOrder.CurrentRow.Cells[2].Value.ToString());
                //        listMonAnViewDaDat.Remove(i);
                //        break;
                //    }
                //}
                //LoadDataGridView(listMonAnViewDaDat);
            }
        }
    }
}
