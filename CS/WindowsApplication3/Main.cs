using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using DevExpress.XtraEditors;
using DXSample.Data;

namespace DXSample {

    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
            recordBindingSource.DataSource = DataHelper.GetData(50);
        }
        private void OnCustomDrawCell(object sender, DevExpress.XtraEditors.Popup.LookUpCustomDrawCellArgs e) {
            LookUpEdit edit = sender as LookUpEdit;
            if (IsServiceColumn(edit, e.Column.FieldName)) {
                e.Appearance.BackColor = Color.Blue;
                e.Appearance.ForeColor = Color.White;   
            }
        }
        private bool IsServiceColumn(LookUpEdit edit, string fieldName) {
            return fieldName == edit.Properties.ValueMember || fieldName == edit.Properties.DisplayMember;
        }
        private void OnCustomDrawHeader(object sender, DevExpress.XtraEditors.Popup.LookUpCustomDrawHeaderArgs e) {
            LookUpEdit edit = sender as LookUpEdit;
            if (IsServiceColumn(edit, e.Header.Column.FieldName)) {
                e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
                e.Graphics.DrawString(e.Header.Caption, e.Header.Appearance.Font, Brushes.White, e.Header.CaptionRect);
                e.Handled = true;
            }
        }
        private void OnCustomDrawRow(object sender, DevExpress.XtraEditors.Popup.LookUpCustomDrawRowArgs e) {
            if (e.IsSelected)
                using (HatchBrush brush = new HatchBrush(HatchStyle.Weave, Color.FromArgb(30, Color.Orange), Color.FromArgb(120, Color.White))) {
                    e.DefaultDraw();
                    e.Cache.FillRectangle(brush, e.Bounds);
                    e.Handled = true;
                }
        }
    }
}