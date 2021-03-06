﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDataAccess
{
    public partial class Dashboard : Form
    {

        List<Person> people = new List<Person>();

        public Dashboard()
        {
            InitializeComponent();
            updateBinding();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void updateBinding()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.getPeopleByLastName(lastNameText.Text);
            updateBinding();
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.insertPerson(firstNameTextBox.Text, lastNameTextBox.Text, emailAddressTextBox.Text, phoneTextBox.Text);
        }
    }
}
