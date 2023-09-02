using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class FormReportFine : Form
    {
        public FormReportFine()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           CrystalReport1  crpt = new CrystalReport1();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();


            //for parameter fromdate
            crParameterDiscreteValue.Value = dateTimePicker1.Text;
            crParameterFieldDefinitions = crpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["FromDate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);


            //for parameter todate
            crParameterDiscreteValue.Value = dateTimePicker2.Text;
            crParameterFieldDefinitions = crpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["ToDate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crystalReportViewer1.ReportSource = crpt;
            crystalReportViewer1.Refresh();
        }
    }
}
