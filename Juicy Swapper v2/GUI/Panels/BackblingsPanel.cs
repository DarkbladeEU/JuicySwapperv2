﻿using Juicy_Swapper_v2.GUI.Forms.Items.Backblings;
using System;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.Panels
{
    public partial class BackblingsPanel : UserControl
    {
        private static BackblingsPanel _instance;      
        public static BackblingsPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BackblingsPanel();
                return _instance;
            }
        }
        public BackblingsPanel()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new GalacticDisc().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new RainbowClover().ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
