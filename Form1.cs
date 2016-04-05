using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kNearest
{
    public partial class kNearest : Form
    {
        string[] userText;
        double[] userIntText;
        string[] userText1;
        int textCount;
        int textCount1;
        double[,] newData;
        double[] maxData;
        List<string> checkValues;
        public kNearest()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            opnFile.Filter = "Data Set (*.dat)|*.dat|Text File (*.txt)|*.txt|All files (*.*)|*.*";
            opnFile.Title = "Please select data file to encrypt.";
            DialogResult res = opnFile.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtPath.Text = opnFile.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(opnFile.FileName))
                {
                    DataTable dt = new DataTable();
                    DataColumn colData = null;
                    DataRow rowData = null;
                    string line;
                    textCount = 0;
                    bool attributeControl = true;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] attributes = line.Split(',');
                        if (attributeControl)
                        {
                            for (int i = 0; i < attributes.Length; i++)
                            {
                                colData = new DataColumn(attributes[i]);
                                colData.DataType = Type.GetType("System.String");
                                dt.Columns.Add(colData);
                            }
                            attributeControl = false;
                        }
                        else
                        {
                            rowData = dt.NewRow();
                            for (int i = 0; i < attributes.Length; i++)
                            {
                                rowData[i] = attributes[i];
                            }
                            dt.Rows.Add(rowData);
                        }
                    }
                    gridNormalized.DataSource = dt;
                    lblNormalized.Visible = true;
                    lblDistance.Visible = true;
                    lblkTruth.Visible = true;
                    maxData = GetData();
                    
                    for (int i = 0; i < gridNormalized.Rows.Count; i++)
                    {
                        for (int j = 0; j < gridNormalized.Rows[i].Cells.Count - 1; j++)
                        {
                            gridNormalized.Rows[i].Cells[j].Value = Convert.ToDouble(gridNormalized.Rows[i].Cells[j].Value) / maxData[j];
                        }
                    }
                    FindDistance();
                    GetKTable();
                    FindK();

                    userText = new string[gridNormalized.Rows[0].Cells.Count - 1];
                    userIntText = new double[gridNormalized.Rows[0].Cells.Count - 1];
                    userText1 = new string[2];
                    textCount1 = userText.Length;

                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FindK()
        {
            int[] count = new int[3];
            int temp = 0, index = 0;
            for (int i = 0; i < gridTruth.Rows.Count; i++)
            {
                for (int j = 0; j < gridTruth.Rows[i].Cells.Count; j++)
                {
                    if (gridTruth.Rows[i].Cells[j].Value.ToString() == "+")
                    {
                        count[i]++;
                    }
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > temp)
                {
                    temp = count[i];
                    index = ((i + 1) * 2) + 1;
                }
            }
            if (index == 0)
                txtK.Text = "3";
            else
                txtK.Text = index.ToString();
        }

        private void FindDistance()
        {
            DataTable dt = new DataTable();
            DataColumn colData = null;
            DataRow rowData = null;
            for (int i = 0; i < newData.GetLength(0); i++)
            {
                colData = new DataColumn((i + 1) + "");
                colData.DataType = Type.GetType("System.String");
                dt.Columns.Add(colData);
            }

            for (int j = 0; j < newData.GetLength(0); j++)
            {
                rowData = dt.NewRow();
                double result = 0;
                for (int k = 0; k < newData.GetLength(0); k++)
                {
                    result = 0;
                    for (int i = 0; i < newData.GetLength(1); i++)
                    {
                        result += Math.Pow((newData[k, i] - newData[j, i]), 2);
                    }
                    rowData[k] = Math.Sqrt(result);
                }
                dt.Rows.Add(rowData);
            }
            gridDistance.DataSource = dt;
            for (int i = 0; i < newData.GetLength(0); i++)
            {
                gridDistance.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void GetKTable()
        {
            FindValues();
            string[] cValues;
            int[] indexOfValues;
            int choosenKsize;
            DataTable dt = new DataTable();
            DataColumn colData = null;
            DataRow rowData = null;
            bool equalControl;
            int[] valueIndex;
            double lowestNumber;
            int temp = 0;
            for (int i = 0; i < newData.GetLength(0); i++)
            {
                colData = new DataColumn((i + 1).ToString());
                colData.DataType = Type.GetType("System.String");
                dt.Columns.Add(colData);
            }

            for (int i = 0; i < 3; i++) //Her bir k için
            {
                rowData = dt.NewRow();
                for (int k = 0; k < gridDistance.Rows.Count; k++) //Her satır için
                {
                    valueIndex = new int[((i + 1) * 2) + 1];
                    for (int j = 0; j < valueIndex.Length; j++) //
                    {
                        valueIndex[j] = -1;
                    }
                    temp = 0;
                    choosenKsize = 0;
                    if (valueIndex.Length >= gridDistance.Rows.Count)
                        choosenKsize = gridDistance.Rows.Count - 1;
                    else
                        choosenKsize = valueIndex.Length;
                    for (int m = 0; m < choosenKsize; m++)
                    {
                        lowestNumber = 99.0;
                        for (int n = 0; n < gridDistance.Rows.Count; n++)
                        {
                            equalControl = true;
                            if (k != n)
                            {
                                if (Convert.ToDouble(gridDistance.Rows[k].Cells[n].Value) < lowestNumber)
                                {
                                    for (int o = 0; o < valueIndex.Length; o++)
                                    {
                                        if (valueIndex[o] != -1 && n == valueIndex[o])
                                        {
                                            equalControl = false;
                                        }
                                    }
                                    if (equalControl)
                                    {
                                        lowestNumber = Convert.ToDouble(gridDistance.Rows[k].Cells[n].Value);
                                        valueIndex[temp] = n;
                                    }
                                }
                            }
                        }
                        temp++;
                    }
                    cValues = new string[checkValues.Count];
                    indexOfValues = new int[cValues.Length];
                    cValues = checkValues.ToArray();
                    for (int m = 0; m < valueIndex.Length; m++)
                    {
                        for (int n = 0; n < cValues.Length; n++)
                        {
                            if (valueIndex[m] != -1 && cValues[n] == gridNormalized.Rows[valueIndex[m]].Cells[gridNormalized.Rows[valueIndex[m]].Cells.Count - 1].Value.ToString())
                            {
                                indexOfValues[n]++;
                                break;
                            }
                        }
                    }
                    temp = 0;
                    lowestNumber = 0;
                    for (int m = 0; m < indexOfValues.Length; m++)
                    {
                        if (indexOfValues[m] > lowestNumber)
                        {
                            lowestNumber = indexOfValues[m];
                            temp = m;
                        }

                    }
                    if (cValues[temp] == gridNormalized.Rows[k].Cells[gridNormalized.Rows[k].Cells.Count - 1].Value.ToString())
                        rowData[k] = "+";
                    else
                        rowData[k] = "-";
                }
                dt.Rows.Add(rowData);
            }

           


            gridTruth.DataSource = dt;

            for (int i = 0; i < 3; i++)
            {
                gridTruth.Rows[i].HeaderCell.Value = (((i + 1) * 2) + 1).ToString();
            }

        }

        private double[] GetData()
        {
            newData = new double[gridNormalized.Rows.Count, gridNormalized.Rows[1].Cells.Count - 1];
            double[] maxData = new double[newData.GetLength(1)];
            for (int i = 0; i < newData.GetLength(0); i++)
            {
                for (int j = 0; j < newData.GetLength(1); j++)
                {
                    newData[i, j] = Convert.ToDouble(gridNormalized.Rows[i].Cells[j].Value);
                }
            }
            for (int i = 0; i < newData.GetLength(1); i++)
            {
                for (int j = 0; j < newData.GetLength(0); j++)
                {
                    if (maxData[i] < newData[j, i])
                    {
                        maxData[i] = newData[j, i];
                    }
                }
            }
            for (int i = 0; i < newData.GetLength(0); i++)
            {
                for (int j = 0; j < newData.GetLength(1); j++)
                {
                    newData[i, j] /= maxData[j];
                }
            }
            return maxData;
        }

        private void FindValues()
        {
            checkValues = new List<string>();
            bool check;
            for (int i = 0; i < gridNormalized.Rows.Count; i++)
            {
                check = true;
                foreach (var item in checkValues)
                {
                    if (item == gridNormalized.Rows[i].Cells[gridNormalized.Rows[i].Cells.Count - 1].Value.ToString())
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    checkValues.Add(gridNormalized.Rows[i].Cells[gridNormalized.Rows[i].Cells.Count - 1].Value.ToString());
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)// input girme işlemleri yapıldı..
        {
          
            if (e.KeyChar == (char)Keys.Enter)
            {
                if ((textCount1) != 0)
                {
                    MessageBox.Show("Please enter the last " + (textCount1 - 1) + " value");

                    userText1 = richTextBox1.Text.Split('\n');
                    userText[textCount] = userText1[0];
                    richTextBox1.Text = "";
                    textCount++;
                    textCount1--;
                }
                else {
                    richTextBox1.Text = "";

                    MessageBox.Show("You can not enter value!.. Please enter Search Button for Answer!..");

                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int[] index = new int[Convert.ToInt16(txtK.Text)];
            string[] cValues;
            int[] indexOfValues;
            double temp;
            bool equalControl;
            double result;
            double[] distance = new double[newData.GetLength(0)];
            for (int i = 0; i < userText.Length; i++)
            {
                userIntText[i] = Convert.ToDouble(userText[i]) / maxData[i]; 
            }
            richTextBox1.SelectedText = "Normalized User Data" + Environment.NewLine;
            for (int j = 0;j < userIntText.Length; j++)
            {
                richTextBox1.SelectedText = userIntText[j].ToString() + Environment.NewLine;
            }

            for (int i = 0; i < index.Length; i++)
            {
                index[i] = -1;
            }

            for (int i = 0; i < newData.GetLength(0); i++)
            {
                result = 0;
                for (int j = 0; j < newData.GetLength(1); j++)
                {
                    result += Math.Pow((userIntText[j] - newData[i, j]), 2);
                }
                distance[i] = Math.Sqrt(result);
            }
            for (int i = 0; i < index.Length; i++) // k kadar dönecek
            {
                temp = 99;
                for (int j = 0; j < distance.Length; j++)
                {
                    equalControl = true;
                    if (distance[j] < temp)
                    {
                        for (int k = 0; k < index.Length; k++)
                        {
                            if (j == index[k])
                            {
                                equalControl = false;
                            }
                        }
                        if (equalControl)
                        {
                            temp = distance[j];
                            index[i] = j;
                        }
                    }
                }
            }
            cValues = new string[checkValues.Count];
            indexOfValues = new int[cValues.Length];
            cValues = checkValues.ToArray();
            for (int i = 0; i < index.Length; i++)
            {
                for (int j = 0; j < cValues.Length; j++)
                {
                    if (gridNormalized.Rows[index[i]].Cells[gridNormalized.Rows[index[i]].Cells.Count - 1].Value.ToString() == cValues[j])
                    {
                        indexOfValues[j]++;
                        break;
                    }
                }
            }
            result = 0;
            temp = 0;
            for (int i = 0; i < indexOfValues.Length; i++)
            {
                if (indexOfValues[i] > temp)
                {
                    temp = indexOfValues[i];
                    result = i;
                }
            }

            txtAnswer.Text = gridNormalized.Rows[index[Convert.ToInt16(result)]].Cells[gridNormalized.Rows[index[Convert.ToInt16(result)]].Cells.Count - 1].Value.ToString();

        }
    }
}
