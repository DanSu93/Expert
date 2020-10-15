using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Expert
{
    public partial class FrmMain : Form
    {
        List<ExpertData> _listData;
        ExpertData _currentData;
        Calculator _calc = new Calculator();

        int _currentIndex;
        int _currentExpertNumber, _currentSumExpertNumber;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TableResize((int)numAlternatives.Value, (int)numAlternatives.Value, "Альтернатива");
            numAlternatives.Enabled = numCriteria.Enabled = numExperts.Enabled = btnStart.Enabled = false;
            _listData = new List<ExpertData>();
            _currentData = new ExpertData
            {
                CriteriaData = new List<double[,]>(),
                ExpertNumber = 1,
                FND = new double[(int)numCriteria.Value, (int)numAlternatives.Value],
                TempData = new double[(int)numAlternatives.Value, (int)numAlternatives.Value],
                Result = new double[(int)numAlternatives.Value],
            };
            btnNext.Enabled = true;
            dgvTable.Enabled = true;
            btnNext.Text = "Далее";
            lblExpertNumber.Text = "1";
            _currentExpertNumber = 2;
            _currentSumExpertNumber = 1;
            _currentIndex=0;
        }

        private void dgvTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == e.RowIndex)
                return;
            dgvTable.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = (1 - Convert.ToDouble(dgvTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentData == null)
                    throw new Exception("Ошибка при инициализации структуры временных данных.");
                if (!((_currentIndex >= (int)numCriteria.Value) && (_currentIndex % (int)numCriteria.Value) != 1))
                {
                    lblTableNumber.Text = (_currentIndex + 2).ToString();
                    if (_currentData.CriteriaData == null)
                        _currentData.CriteriaData = new List<double[,]>();
                    double[,] mas = new double[(int)numAlternatives.Value, (int)numAlternatives.Value];
                    for (int i = 0; i < numAlternatives.Value; i++)
                        for (int j = 0; j < numAlternatives.Value; j++)
                            mas[i, j] = Convert.ToDouble(dgvTable.Rows[i].Cells[j].Value);
                    _currentData.CriteriaData.Add(mas);
                    if (_currentIndex == (int)numCriteria.Value - 1)
                    {
                        TableResize((int)numCriteria.Value, (int)numCriteria.Value, "Критерий");
                        lblTableName.Text = "Матрица приоритетов:";
                        lblTableNumber.Visible = false;
                        if (_currentSumExpertNumber >= (int)numExperts.Value)
                            btnNext.Text = "Решение";
                    }
                    else
                    {
                        TableResize((int)numAlternatives.Value, (int)numAlternatives.Value, "Альтернатива");
                    }
                }
                else
                {
                    double[,] mas = new double[(int)numCriteria.Value, (int)numCriteria.Value];
                    for (int i = 0; i < numCriteria.Value; i++)
                        for (int j = 0; j < numCriteria.Value; j++)
                            mas[i, j] = Convert.ToDouble(dgvTable.Rows[i].Cells[j].Value);
                    _currentData.Priority = mas;
                    TableResize((int)numAlternatives.Value, (int)numAlternatives.Value, "Альтернатива");
                    lblTableName.Text = "Матрица по критерию:";
                    lblTableNumber.Visible = true;
                    _currentIndex = -1;
                    int se = (int)numExperts.Value;
                    _currentSumExpertNumber++;
                    lblExpertNumber.Text = _currentSumExpertNumber < se ? _currentSumExpertNumber.ToString() : se.ToString();
                    lblTableNumber.Text = "1";
                    _listData.Add(_currentData);
                    _currentData = new ExpertData
                    {
                        CriteriaData = new List<double[,]>(),
                        ExpertNumber = _currentExpertNumber,
                        FND = new double[(int)numCriteria.Value, (int)numAlternatives.Value],
                        TempData = new double[(int)numAlternatives.Value, (int)numAlternatives.Value],
                        Result = new double[(int)numAlternatives.Value],
                    };
                    _currentExpertNumber++;
                    if (btnNext.Text == "Решение")
                    {
                        _calc.Do(_listData);
                        FrmResult fr = new FrmResult();
                        fr.TableToForm(_listData);
                        fr.ShowDialog(this);
                        numAlternatives.Enabled = numCriteria.Enabled = numExperts.Enabled = btnStart.Enabled = true;
                        btnNext.Enabled = false;
                        dgvTable.Enabled = false;
                        return;
                    }
                }
                _currentIndex++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        void TableResize(int x, int y, string s)
        {
            dgvTable.Columns.Clear();
            dgvTable.Rows.Clear();
            for (int j = 0; j < y; j++)
            {
                DataGridViewColumn c = new DataGridViewColumn
                {
                    CellTemplate = new DataGridViewTextBoxCell(),
                    HeaderText = $"{s} {j + 1}",
                    Name = $"Alt{j}"
                };
                dgvTable.Columns.Add(c);
            }
            for (int i = 0; i < x; i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.HeaderCell.Value = $"{s} {i + 1}";
                dgvTable.Rows.Add(r);
                dgvTable.Rows[i].Cells[i].Value = "1";
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void dgvTable_ColumnAdded(object sender, DataGridViewColumnEventArgs e) => dgvTable.AutoSizeColumnsMode = (dgvTable.ColumnCount <= 5) ? DataGridViewAutoSizeColumnsMode.Fill : DataGridViewAutoSizeColumnsMode.None;
    }
}
