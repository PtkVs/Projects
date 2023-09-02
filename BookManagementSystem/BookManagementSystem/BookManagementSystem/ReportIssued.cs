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
    public partial class ReportIssued : Form
    {
        public ReportIssued()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CReportIssue crpt = new CReportIssue();


            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();


            //for parameter fromdate
            crParameterDiscreteValue.Value = dateTimePickerFrom.Text;
            crParameterFieldDefinitions = crpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["fromdate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);


            //for parameter todate
            crParameterDiscreteValue.Value = dateTimePickerTo.Text;
            crParameterFieldDefinitions = crpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["todate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crystalReportViewer1.ReportSource = crpt;
            crystalReportViewer1.Refresh();

        }
    }
}
