using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTreeList;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System.Reflection;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Utils.Text;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;


namespace DXSample {
    public partial class Main : XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {

            DataTable dt = CreateData();

            gridControl1.DataSource = dt;
            RepositoryItemHtmlLabel edit = new RepositoryItemHtmlLabel();
            edit.AllowHtmlString = true;
            gridControl1.RepositoryItems.Add(edit);
            gridControl1.ForceInitialize();

            gridView1.Columns["Html"].ColumnEdit = edit;
        }

        private static DataTable CreateData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Html");
            dt.Columns.Add("String");

            dt.Rows.Add("<size=14>Size = 14<br>" +
                     "<b>Bold</b> <i>Italic</i> <u>Underline</u><br>" +
                     "<size=11>Size = 11<br>" +
                     "<color=255, 0, 0>Sample Text</color></size>", "String a");
            dt.Rows.Add("<size=15>Size = 15<br>" +
                     "<b>Bold</b> <i>Italic</i> <u>Underline</u><br>" +
                     "<size=10>Size = 10<br>" +
                     "<color=255, 255, 0>Sample Text</color></size>", "String b");
            dt.Rows.Add("<size=18>Size = 18<br>" +
                     "<b>Bold</b> <i>Italic</i> <u>Underline</u><br>" +
                     "<size=8>Size = 8<br>" +
                     "<color=255, 0, 255>Sample Text</color></size>", "String c");
            return dt;
        }
    }

    
}
