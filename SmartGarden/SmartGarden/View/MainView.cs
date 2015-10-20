using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartGarden.Control;
using SmartGarden.Model;

namespace SmartGarden.View
{
    partial class MainView : UserControl
    {
        private GestioneGiardino _gestoreGiardino;
        private IController _controller;

        public MainView()
        {
            InitializeComponent();
        }

        public GestioneGiardino GestoreGiardino
        {
            get { return _gestoreGiardino; }
            set
            {
                if (value != _gestoreGiardino)
                {
                    if (_gestoreGiardino != null)
                    {
                        _gestoreGiardino.Changed -= OnModelChanged; // deregistrazione
                    }
                    _gestoreGiardino = value;

                    if (_gestoreGiardino != null)
                    {
                        _gestoreGiardino.Changed += OnModelChanged; //registrazione al model
                       // _gestoreGiardino.Giardino.Changed += OnModelChanged; //registrazione al model
                    }
                }
            }
        }

        public IController Controller
        {
            get
            {
                if (_controller != null)
                    return _controller;
                else
                {
                    _controller = new Controller(_gestoreGiardino);
                    return _controller;
                }
            }
            set { _controller = value; }
        }

        protected virtual void OnModelChanged(object sender, EventArgs e)
        {
        }
    }
}
