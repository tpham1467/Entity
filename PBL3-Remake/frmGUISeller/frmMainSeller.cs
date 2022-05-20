﻿using System;
using System.Windows.Forms;
using BLL;
namespace GUI.frmGUISeller
{
    public partial class frmMainSeller : Form
    {
        public frmMainSeller()
        {
            InitializeComponent();
            SetCbb();
        }

        private void frmMainSeller_Load(object sender, EventArgs e)
        {
            this.Width = 1300;
            this.Height = 700;
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        void SetCbb()
        {
            cbbStatus.Items.Add("All");
            cbbStatus.Items.Add("Emty");
            cbbStatus.Items.Add("Busy");
        }
        private int Floor = 0;
        private bool statustb;
        void SetTable(Panel pn, TableForOrdering tb, int id, int fl, bool st)
        {
            tb.Width = 250;
            tb.Height = 200;
            pn.Controls.Add(tb);
            tb.IDTable = id;
            tb.Floor = fl;
            tb.statusTable = st;
            tb.GUITable();
        }
        void LoadAllTableWithFloor(int fl)
        {
            int soban = BLLNVNH.Instance.NumberOfStatusAndFloor(true, fl) + BLLNVNH.Instance.NumberOfStatusAndFloor(false, fl);
            TableForOrdering[] tb = new TableForOrdering[soban];
            int dem1 = 0;
            foreach (string i in BLLNVNH.Instance.GetAllBanByTang(fl))
            {
                tb[dem1] = new TableForOrdering();
                tb[dem1].IDTable = BLLNVNH.Instance.GetAllBanByID_Ban(Convert.ToInt32(i.ToString())).ID_Ban;
                tb[dem1].Floor = BLLNVNH.Instance.GetAllBanByID_Ban(Convert.ToInt32(i.ToString())).Tang;
                int ttb = BLLNVNH.Instance.GetAllBanByID_Ban(Convert.ToInt32(i.ToString())).TinhTrangBan;
                if (ttb == 0)
                    tb[dem1].statusTable = false;
                else tb[dem1].statusTable = true;
                dem1++;
            }
            int soluongban = soban;
            if (soluongban != 0)
            {
                for (int i = 0; i < tb.Length; i++)
                {
                    int Lx = 0, Ly = 0;
                    if (i % 4 == 0) Lx = 20;
                    else if (i % 4 == 1)
                    {
                        Lx = 330;
                    }
                    else if (i % 4 == 2)
                    {
                        Lx = 630;
                    }
                    else if (i % 4 == 3)
                    {
                        Lx = 930;
                    }
                    int thuong = Convert.ToInt32(i / 4);
                    Ly = 25 + 260 * thuong;
                    tb[i].SetLocation(Lx, Ly);
                    //Console.WriteLine(tb[i].IDTable + " " + Ly + " " + Lx);
                    SetTable(pnTable, tb[i], tb[i].IDTable, Floor, tb[i].statusTable);
                }
            }
        }
        void RemoveTable()
        {
            pnTable.Controls.Clear();
        }
        private void btnFloor1_Click(object sender, EventArgs e)
        {
            Floor = 1;
            RemoveTable();
            BLLNVNH.Instance.LoadBanWithTinhTrangBanVaTang(statustb, Floor);
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            Floor = 2;
            RemoveTable();
            BLLNVNH.Instance.LoadBanWithTinhTrangBanVaTang(statustb, Floor);
        }



        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbStatus.SelectedIndex == 1)
            {
                statustb = true;
                RemoveTable();
                BLLNVNH.Instance.LoadBanWithTinhTrangBanVaTang(statustb, Floor);
            }
            else if (cbbStatus.SelectedIndex == 2)
            {
                statustb = false;
                RemoveTable();
                BLLNVNH.Instance.LoadBanWithTinhTrangBanVaTang(statustb, Floor);
            }
            else if (cbbStatus.SelectedIndex == 0)
            {
                RemoveTable();
                LoadAllTableWithFloor(Floor);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
