using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expert
{
    public partial class FrmResult : Form
    {
        public FrmResult()
        {
            InitializeComponent();
        }

        public void TableToForm(List<ExpertData> data)
        {
            foreach (ExpertData ed in data)
            {
                flwPanel.Controls.Add(new Label()
                {
                    Text = $"Эксперт: {ed.ExpertNumber}",
                    Font = new Font(Font, FontStyle.Bold),
                    Name = $"Expert{ed.ExpertNumber}"
                });
                for (int k = 0; k < ed.CriteriaData.Count; k++)
                {
                    flwPanel.Controls.Add(new Label()
                    {
                        Text = $"Матрица по критерию: {k + 1}",
                        Name = $"Expert{ed.ExpertNumber}",
                        Width = 500
                    });
                    DataGridView dgv = MasToTable(ed.CriteriaData[k], "Критерий", "Критерий");
                    TableInit(dgv);
                    flwPanel.Controls.Add(dgv);
                }

                flwPanel.Controls.Add(new Label()
                {
                    Text = $"Матрица приоритетов:",
                    Name = $"Expert{ed.ExpertNumber}",
                    Width = 500
                });
                DataGridView dgv1 = MasToTable(ed.Priority, "Критерий", "Критерий");
                TableInit(dgv1);
                flwPanel.Controls.Add(dgv1);

                flwPanel.Controls.Add(new Label()
                {
                    Text = $"ФНД {ed.ExpertNumber}-ого эксперта:",
                    Name = $"Expert{ed.ExpertNumber}",
                    Width = 500
                });
                dgv1 = MasToTable(ed.FND, "ФНД по критерию", "Альтернатива");
                TableInit(dgv1);
                dgv1.RowHeadersWidth = 150;
                flwPanel.Controls.Add(dgv1);

                flwPanel.Controls.Add(new Label()
                {
                    Text = $"Итоговая матрица {ed.ExpertNumber}-ого эксперта:",
                    Name = $"Expert{ed.ExpertNumber}",
                    Width = 500
                });
                dgv1 = MasToTable(ed.TempData, "Альтернатива", "Альтернатива");
                TableInit(dgv1);
                flwPanel.Controls.Add(dgv1);

                flwPanel.Controls.Add(new Label()
                {
                    Text = $"Итоговое ФНД {ed.ExpertNumber}-ого эксперта:",
                    Font = new Font(Font, FontStyle.Bold),
                    Name = $"Expert{ed.ExpertNumber}",
                    Width = 500
                });
                dgv1 = MasToTable(ed.Result, "Эксперт ", "Альтернатива");
                TableInit(dgv1);
                dgv1.Height = 64;
                flwPanel.Controls.Add(dgv1);
            }
            if (data.Count > 1)
            {
                double[,] res = new double[data.Count, data[0].Result.Length];
                int index = 0;
                foreach (ExpertData ed in data)
                {
                    for (int i = 0; i < ed.Result.Length; i++)
                        res[index, i] = ed.Result[0];
                    index++;
                }
                flwPanel.Controls.Add(new Label()
                {
                    Text = $"Итоговое ФНД всех экспертов:",
                    Font = new Font(Font, FontStyle.Bold),
                    Width = 500
                });
                DataGridView dgv1 = MasToTable(res, "Эксперт", "Альтернатива");
                TableInit(dgv1);
                flwPanel.Controls.Add(dgv1);
            }
        }

        void TableInit(DataGridView dgv)
        {
            dgv.Size = new Size(600, 200);
            dgv.AutoSizeColumnsMode = (dgv.ColumnCount <= 5) ? DataGridViewAutoSizeColumnsMode.Fill : DataGridViewAutoSizeColumnsMode.None;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersWidth = 130;
            if (dgv.Rows.Count <= 12)
                dgv.Height = dgv.Rows.GetRowsHeight(DataGridViewElementStates.Visible) +
                          dgv.ColumnHeadersHeight;
        }

        DataGridView MasToTable(double[] mas, string si, string sj)
        {
            DataGridView dgvTable = new DataGridView();
            for (int j = 0; j < mas.Length; j++)
            {
                DataGridViewColumn c = new DataGridViewColumn
                {
                    CellTemplate = new DataGridViewTextBoxCell(),
                    HeaderText = $"{sj} {j + 1}",
                    Name = $"Alt{j}"
                };
                dgvTable.Columns.Add(c);
            }
            DataGridViewRow r = new DataGridViewRow();
            r.HeaderCell.Value = $"{si}";
            dgvTable.Rows.Add(r);
            for (int i = 0; i < mas.Length; i++)
                dgvTable.Rows[0].Cells[i].Value = mas[i].ToString();
            return dgvTable;
        }

        DataGridView MasToTable(double[,] mas, string si, string sj)
        {
            DataGridView dgvTable = new DataGridView();
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                DataGridViewColumn c = new DataGridViewColumn
                {
                    CellTemplate = new DataGridViewTextBoxCell(),
                    HeaderText = $"{sj} {j + 1}",
                    Name = $"Alt{j}"
                };
                dgvTable.Columns.Add(c);
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.HeaderCell.Value = $"{si} {i + 1}";
                dgvTable.Rows.Add(r);
            }
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    dgvTable.Rows[i].Cells[j].Value = mas[i, j].ToString();
            return dgvTable;
        }

        private void FrmResult_Load(object sender, EventArgs e)
        {

        }
    }
}
