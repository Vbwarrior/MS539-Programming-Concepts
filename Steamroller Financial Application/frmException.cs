﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steamroller_Financial_Application
{
    public partial class frmException : Form
    {
        public frmException(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}