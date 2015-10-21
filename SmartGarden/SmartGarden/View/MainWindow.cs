﻿
using SmartGarden.Control;
using SmartGarden.Model;
using SmartGarden.View;
using System;
using System.Windows.Forms;
using System.Xml.XPath;

namespace SmartGarden
{
    partial class MainWindow : Form
    {
        private Controller _controller;

        public MainWindow()
        {
            InitializeComponent();
            _provinceComboBox.SelectedIndexChanged += CambiaProvincia;
        }

        public Controller Controller
        {
            get { return _controller; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GestioneGiardino gestoreGiardino = GestioneGiardino.GetGestoreGiardino();
            _controller = new Controller(gestoreGiardino);

            bool loginOk = _controller.CreateLoginForm();
            if (!loginOk)
                this.Close();
            
            _pannelloDestra.GestoreGiardino = gestoreGiardino; //set del model
            _pannelloDestra.Controller = _controller; //set del controller
            _treeView.GestoreGiardino = gestoreGiardino;
            _treeView.Controller = _controller;
            

            _dateStatusBar.Text = DateTime.Now.ToShortDateString();

            _controller.SettaTimer();

            _controller.CaricaInfoGiardino();

            CaricaProvince();

            GestoreTimerView timerView = new GestoreTimerView();
            using(Form form = new Form())
            {
                timerView.Dock = DockStyle.Fill;
                form.Size = new System.Drawing.Size(500, 400);
                form.Controls.Add(timerView);
                form.ShowDialog();
            }

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
        private void CaricaProvince()
        {
            _controller.CaricaProvinceComboBox(_provinceComboBox.ComboBox);
        }


        private void CambiaProvincia(object sender, EventArgs e)
        {
            _controller.CambiaProvincia(_provinceComboBox.SelectedItem.ToString());
        }

        private void _resetToolStrip_Click(object sender, EventArgs e)
        {
            Controller.NuovoGiardino();
        }

        private void gestisciGiardinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.GestisciSettori();
        }
    }
}
