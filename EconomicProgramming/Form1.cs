using System;
using System.Data;
using System.Web.UI.WebControls;

namespace EconomicProgramming
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            LoadResult1();
        }

        private void LoadResult1()
        {
            GC_Result.DataSource = CreateFirstDatatable();
            GV_Result.Columns["№"].Width = 30;
            GV_Result.Columns["Adı"].Width = 130;
            GC_Result2.Visible = false;
            GV_Result.Columns["№"].OptionsColumn.AllowEdit = false;
            GV_Result.Columns["Adı"].OptionsColumn.AllowEdit = false;

        }
        private void LoadResult2()
        {
            GC_Result2.DataSource = CreateSecondDatatable();
            GV_Result2.Columns["№"].Width = 30;
            GV_Result2.Columns["Adı"].Width = 130;
            GC_Result2.Visible = true;
            GC_Result.Visible = false;
            btnCalculate.Visible = false;
            layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        public DataTable CreateFirstDatatable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("№", typeof(int));
            dataTable.Columns.Add("Adı", typeof(string));
            dataTable.Columns.Add("2001", typeof(decimal));
            dataTable.Columns.Add("2002", typeof(decimal));

            var row1 = dataTable.NewRow();
            row1["№"] = 1;
            row1["Adı"] = "Xammal";
            dataTable.Rows.Add(row1);

            var row2 = dataTable.NewRow();
            row2["№"] = 2;
            row2["Adı"] = "Yanacaq";
            dataTable.Rows.Add(row2);

            var row3 = dataTable.NewRow();
            row3["№"] = 3;
            row3["Adı"] = "Əmək haqqı";
            dataTable.Rows.Add(row3);

            var row4 = dataTable.NewRow();
            row4["№"] = 4;
            row4["Adı"] = "Amortizasiya";
            dataTable.Rows.Add(row4);

            var row5 = dataTable.NewRow();
            row5["№"] = 5;
            row5["Adı"] = "Sosial xərclər";
            dataTable.Rows.Add(row5);

            var row6 = dataTable.NewRow();
            row6["№"] = 6;
            row6["Adı"] = "İdarəetmə";
            dataTable.Rows.Add(row6);

            var row7 = dataTable.NewRow();
            row7["№"] = 7;
            row7["Adı"] = "Sex xərci";
            dataTable.Rows.Add(row7);

            var row8 = dataTable.NewRow();
            row8["№"] = 8;
            row8["Adı"] = "Nəqliyyat xərci";
            dataTable.Rows.Add(row8);

            var row9 = dataTable.NewRow();
            row9["№"] = 9;
            row9["Adı"] = "Kommersiya";
            dataTable.Rows.Add(row9);

            var row10 = dataTable.NewRow();
            row10["№"] = 10;
            row10["Adı"] = "Gəlir";
            dataTable.Rows.Add(row10);

            return dataTable;
        }
        public DataTable CreateSecondDatatable()
        {
            DataRow[] rows = new DataRow[GV_Result.RowCount];
            for (int i = 0; i < GV_Result.RowCount; i++)
            {
                rows[i] = GV_Result.GetDataRow(i);
            }
            var dataTable = new DataTable();
            dataTable.Columns.Add("№", typeof(int));
            dataTable.Columns.Add("Adı", typeof(string));
            dataTable.Columns.Add("2001", typeof(decimal));
            dataTable.Columns.Add("2002", typeof(decimal));
            dataTable.Columns.Add("Mütləqi", typeof(decimal));
            dataTable.Columns.Add("Nisbi", typeof(decimal));

            var row1 = dataTable.NewRow();
            row1["№"] = 1;
            row1["Adı"] = "Xammal";
            row1["2001"] = rows[0].ItemArray[2];
            row1["2002"] = rows[0].ItemArray[3];
            row1["Mütləqi"] = Math.Round(Convert.ToDecimal(rows[0].ItemArray[3]) - Convert.ToDecimal(rows[0].ItemArray[2]),2);
            row1["Nisbi"] = Math.Round(Convert.ToDecimal(rows[0].ItemArray[3]) / Convert.ToDecimal(rows[0].ItemArray[2]), 2);
            dataTable.Rows.Add(row1);

            var row2 = dataTable.NewRow();
            row2["№"] = 2;
            row2["Adı"] = "Yanacaq";
            row2["2001"] = rows[1].ItemArray[2];
            row2["2002"] = rows[1].ItemArray[3];
            row2["Mütləqi"] = Math.Round(Convert.ToDecimal(rows[1].ItemArray[3]) - Convert.ToDecimal(rows[1].ItemArray[2]),2);
            row2["Nisbi"] = Math.Round(Convert.ToDecimal(rows[1].ItemArray[3]) / Convert.ToDecimal(rows[1].ItemArray[2]), 2);
            dataTable.Rows.Add(row2);

            var row3 = dataTable.NewRow();
            row3["№"] = 3;
            row3["Adı"] = "Əmək haqqı";
            row3["2001"] = rows[2].ItemArray[2];
            row3["2002"] = rows[2].ItemArray[3];
            row3["Mütləqi"] = Math.Round(Convert.ToDecimal(rows[2].ItemArray[3]) - Convert.ToDecimal(rows[2].ItemArray[2]),2);
            row3["Nisbi"] = Math.Round(Convert.ToDecimal(rows[2].ItemArray[3]) / Convert.ToDecimal(rows[2].ItemArray[2]), 2);
            dataTable.Rows.Add(row3);


            var row4 = dataTable.NewRow();
            row4["№"] = 4;
            row4["Adı"] = "Amortizasiya";
            row4["2001"] = rows[3].ItemArray[2];
            row4["2002"] = rows[3].ItemArray[3];
            row4["Mütləqi"] = Math.Round(Convert.ToDecimal(rows[3].ItemArray[3]) - Convert.ToDecimal(rows[3].ItemArray[2]),2);
            row4["Nisbi"] = Math.Round(Convert.ToDecimal(rows[3].ItemArray[3]) / Convert.ToDecimal(rows[3].ItemArray[2]), 2);
            dataTable.Rows.Add(row4);

            var row5 = dataTable.NewRow();
            row5["№"] = 5;
            row5["Adı"] = "Sosial xərc";
            row5["2001"] = rows[4].ItemArray[2];
            row5["2002"] = rows[4].ItemArray[3];
            row5["Mütləqi"] = Math.Round(Convert.ToDecimal(rows[4].ItemArray[3]) - Convert.ToDecimal(rows[4].ItemArray[2]),2);
            row5["Nisbi"] = Math.Round(Convert.ToDecimal(rows[4].ItemArray[3]) / Convert.ToDecimal(rows[4].ItemArray[2]), 2);
            dataTable.Rows.Add(row5);

            var row6 = dataTable.NewRow();
            row6["№"] = 6;
            row6["Adı"] = "İdarəetmə";
            row6["2001"] = rows[5].ItemArray[2];
            row6["2002"] = rows[5].ItemArray[3];
            row6["Mütləqi"] = Math.Round(Convert.ToDecimal(rows[5].ItemArray[3]) - Convert.ToDecimal(rows[5].ItemArray[2]),2);
            row6["Nisbi"] = Math.Round(Convert.ToDecimal(rows[5].ItemArray[3]) / Convert.ToDecimal(rows[5].ItemArray[2]), 2);
            dataTable.Rows.Add(row6);

            var row7 = dataTable.NewRow();
            row7["№"] = 7;
            row7["Adı"] = "Sex xərci";
            row7["2001"] = rows[6].ItemArray[2];
            row7["2002"] = rows[6].ItemArray[3];
            row7["Mütləqi"] = Math.Round(Convert.ToDecimal(rows[6].ItemArray[3]) - Convert.ToDecimal(rows[6].ItemArray[2]),2);
            row7["Nisbi"] = Math.Round(Convert.ToDecimal(rows[6].ItemArray[3]) / Convert.ToDecimal(rows[6].ItemArray[2]), 2);
            dataTable.Rows.Add(row7);

            var row8 = dataTable.NewRow();
            row8["№"] = 8;
            row8["Adı"] = "Nəqliyyat xərci";
            row8["2001"] = rows[7].ItemArray[2];
            row8["2002"] = rows[7].ItemArray[3];
            row8["Mütləqi"] = Math.Round(Convert.ToDecimal(rows[7].ItemArray[3]) - Convert.ToDecimal(rows[7].ItemArray[2]),2);
            row8["Nisbi"] = Math.Round(Convert.ToDecimal(rows[7].ItemArray[3]) / Convert.ToDecimal(rows[7].ItemArray[2]), 2);
            dataTable.Rows.Add(row8);

            var row9 = dataTable.NewRow();
            row9["№"] = 9;
            row9["Adı"] = "Kommersiya";
            row9["2001"] = rows[8].ItemArray[2];
            row9["2002"] = rows[8].ItemArray[3];
            row9["Mütləqi"] = Math.Round(Convert.ToDecimal(rows[8].ItemArray[3]) - Convert.ToDecimal(rows[8].ItemArray[2]),2);
            row9["Nisbi"] = Math.Round(Convert.ToDecimal(rows[8].ItemArray[3]) / Convert.ToDecimal(rows[8].ItemArray[2]), 2);
            dataTable.Rows.Add(row9);

            var row10 = dataTable.NewRow();
            row10["№"] = 10;
            row10["Adı"] = "Gəlir";
            row10["2001"] = rows[9].ItemArray[2];
            row10["2002"] = rows[9].ItemArray[3];
            row10["Mütləqi"] = Math.Round(Convert.ToDecimal(rows[9].ItemArray[3]) - Convert.ToDecimal(rows[9].ItemArray[2]),2);
            row10["Nisbi"] = Math.Round(Convert.ToDecimal(rows[9].ItemArray[3]) / Convert.ToDecimal(rows[9].ItemArray[2]), 2);
            dataTable.Rows.Add(row10);

            var row11 = dataTable.NewRow();
            row11["№"] = 11;
            row11["Adı"] = "ƏDV";
            row11["2001"] = 0.18;
            row11["2002"] = 0.18;
            row11["Mütləqi"] = 0;
            row11["Nisbi"] = 0;
            dataTable.Rows.Add(row11);

            var row12 = dataTable.NewRow();
            row12["№"] = 12;
            row12["Adı"] = "Qiymət ƏDV";
            row12["2001"] = Math.Round((Convert.ToDouble(rows[0].ItemArray[2]) +
                Convert.ToDouble(rows[1].ItemArray[2]) +
                Convert.ToDouble(rows[2].ItemArray[2]) +
                Convert.ToDouble(rows[3].ItemArray[2]) +
                Convert.ToDouble(rows[4].ItemArray[2]) +
                Convert.ToDouble(rows[5].ItemArray[2]) +
                Convert.ToDouble(rows[6].ItemArray[2]) +
                Convert.ToDouble(rows[7].ItemArray[2]) +
                Convert.ToDouble(rows[8].ItemArray[2]) +
                Convert.ToDouble(rows[9].ItemArray[2])) + (Convert.ToDouble(rows[9].ItemArray[2]) * Convert.ToDouble(row11["2001"])), 2);
            row12["2002"] = Math.Round((Convert.ToDouble(rows[0].ItemArray[3]) +
                Convert.ToDouble(rows[1].ItemArray[3]) +
                Convert.ToDouble(rows[2].ItemArray[3]) +
                Convert.ToDouble(rows[3].ItemArray[3]) +
                Convert.ToDouble(rows[4].ItemArray[3]) +
                Convert.ToDouble(rows[5].ItemArray[3]) +
                Convert.ToDouble(rows[6].ItemArray[3]) +
                Convert.ToDouble(rows[7].ItemArray[3]) +
                Convert.ToDouble(rows[8].ItemArray[3]) +
                Convert.ToDouble(rows[9].ItemArray[3])) + (Convert.ToDouble(rows[9].ItemArray[3]) * Convert.ToDouble(row11["2002"])), 2);
            row12["Mütləqi"] = Math.Round(Convert.ToDecimal(row12["2002"]) - Convert.ToDecimal(row12["2001"]),2);
            row12["Nisbi"] = Math.Round(Convert.ToDecimal(row12["2002"]) / Convert.ToDecimal(row12["2001"]), 2);
            dataTable.Rows.Add(row12);


            return dataTable;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            LoadResult2();
        }


    }
}
