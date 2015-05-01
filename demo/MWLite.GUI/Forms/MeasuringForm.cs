using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapWinGIS;
using MWLite.GUI.Helpers;

namespace MWLite.GUI.Forms
{
    public partial class MeasuringForm : Form
    {
        private readonly IMeasuring _measuring;

        public MeasuringForm(IMeasuring measuring)
        {
            if (measuring == null) throw new ArgumentNullException("measuring");
            _measuring = measuring;

            InitializeComponent();

            ModelToUi();
        }

        private void ModelToUi()
        {
            chkShowBearing.Checked = _measuring.ShowBearing;
            chkShowLength.Checked = _measuring.ShowLength;
            chkShowTotalLength.Checked = _measuring.ShowTotalLength;

            cboAngleFormat.AddItemsFromEnum<tkAngleFormat>();
            cboBearingType.AddItemsFromEnum<tkBearingType>();
            cboLengthUnits.AddItemsFromEnum<tkLengthDisplayMode>();

            cboAngleFormat.SetValue(_measuring.AngleFormat);
            cboBearingType.SetValue(_measuring.BearingType);
            cboLengthUnits.SetValue(_measuring.LengthUnits);

            udLengthPrecision.Value = _measuring.LengthPrecision;
            udBearingPrecision.Value = _measuring.AnglePrecision;
        }

        private void UiToModel()
        {
            _measuring.ShowBearing = chkShowBearing.Checked;
            _measuring.ShowLength = chkShowLength.Checked;
            _measuring.ShowTotalLength = chkShowTotalLength.Checked;

            _measuring.AngleFormat = cboAngleFormat.GetValue<tkAngleFormat>();
            _measuring.BearingType = cboBearingType.GetValue<tkBearingType>();
            _measuring.LengthUnits = cboLengthUnits.GetValue<tkLengthDisplayMode>();

            _measuring.LengthPrecision = (int) udLengthPrecision.Value;
            _measuring.AnglePrecision = (int) udBearingPrecision.Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            UiToModel();
            DialogResult = DialogResult.OK;
        }
    }
}
