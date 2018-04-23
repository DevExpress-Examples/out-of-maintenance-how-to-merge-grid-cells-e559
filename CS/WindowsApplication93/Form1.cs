using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace WindowsApplication93
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
                dataTable1.Rows.Add(new object[] {i %5, "Product " + i, i %7 });
            gridView1.OptionsView.AllowCellMerge = true;
            for (int i = 0; i < gridView1.Columns.Count; i++)
                if (gridView1.Columns[i].FieldName == "CategoryID")
                    gridView1.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                else
                    gridView1.Columns[i].OptionsColumn.AllowMerge =  DevExpress.Utils.DefaultBoolean.False;
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            GridView view = sender as GridView;
            try
            {
                if ((e.Column.FieldName == "CategoryID"))
                {
                    int value1 = Convert.ToInt32(view.GetRowCellValue(e.RowHandle1, e.Column));
                    int value2 = Convert.ToInt32(view.GetRowCellValue(e.RowHandle2, e.Column));

                    e.Merge = (value1 == value2);
                    e.Handled = true;
                    return;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}