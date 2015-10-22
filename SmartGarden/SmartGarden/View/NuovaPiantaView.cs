﻿using SmartGarden.Model;
using System;

namespace SmartGarden.View
{
    partial class NuovaPiantaView : MainView
    {
        private string _nomeSettore;

        public NuovaPiantaView(string nomeSettore)
        {
            InitializeComponent();

            _nomeSettore = nomeSettore;
        }

        private void _aggiungiButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_nomeBotanicoTextBox.Text) && !string.IsNullOrWhiteSpace(_nomeComuneTextBox.Text) && 
                _inizioDatePicker.Value < _fineDatePicker.Value)
            {
                double area = double.Parse(_areaTextBox.Text);
                double fabbisogno = double.Parse(_fabbisognoTextBox.Text);
                FabbisognoGiornalieroPeriodo fabbisognoGiornalieroPianta = new FabbisognoGiornalieroPeriodo(_inizioDatePicker.Value, _fineDatePicker.Value, fabbisogno);
                Controller.CreaNuovaPianta(_nomeBotanicoTextBox.Text, _nomeComuneTextBox.Text, area, _nomeSettore, fabbisognoGiornalieroPianta);
            }
        }
    }
}
