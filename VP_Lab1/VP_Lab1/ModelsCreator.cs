using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_lab1;
using System.IO;

namespace VP_Lab1
{
    public partial class ModelsCreator : Form
    {
        public ModelsCreator()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            textBox1.Text = "enter name";
            textBox1.ForeColor = Color.Gray;
            inStock.SelectedIndex = 0;
            /*comboBoxChangeModel.SelectedItem = "model 1";
            comboBoxDeleteModel.SelectedItem = "model 1";
            comboBoxChangeModel.Text = "model 1";
            comboBoxDeleteModel.Text = "model 1";*/
            CreateComboBoxElements();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "enter name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == null || textBox1.Text == "")
            {
                textBox1.Text = "enter name";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Phone phone = GetValues();
            CreateTxtFile(phone);
        }

        private Phone GetValues()
        {
            Phone phone = new Phone();

            //Name
            if (textBox1.Text != "enter name")
            {
                phone.Name = textBox1.Text;
            }

            //Dipsplay
            if (numericUpDown3.Value != 0)
            {
                phone.Display = (double)numericUpDown3.Value;
            }

            //Processor
            if (processorSelect.SelectedItem != null)
            {
                phone.Processor = processorSelect.SelectedItem.ToString();
            }

            //Memory
            if (numericUpDown3.Value != 0)
            {
                phone.Memory = (byte)numericUpDown2.Value;
            }

            //Price
            if (numericUpDown3.Value != 0)
            {
                phone.Price = (int)numericUpDown1.Value;
            }

            //InStock
            if (inStock.SelectedItem.ToString() == "Yes")
            {
                phone.InStock = true;
            }
            else if(inStock.SelectedItem.ToString() == "No")
            {
                phone.InStock = false;
            }

            //Company
            if (companySelect.SelectedItem != null)
            {
                phone.Company = companySelect.SelectedItem.ToString();
            }

            //LimitedEdition
            phone.LimitedEdition = limitedEditionCheck.Checked;

            return phone;
        }

        private void CreateTxtFile(Phone phone)
        {
            string directoryPath = @"E:\C_sharp_labs\VP_lab1\models\";

            DirectoryInfo models_directory = new DirectoryInfo(directoryPath);
            if (!models_directory.Exists)
                models_directory.Create();

            int newModelNumber = models_directory.GetFiles().Length + 1;
            if (changeModelButton.Text == "Save changes")
            {
                newModelNumber = int.Parse(comboBoxChangeModel.Text.Split(' ')[1]);
            }

            FileInfo new_phone_txtFile = new FileInfo(@"E:\C_sharp_labs\VP_lab1\models\phone" + newModelNumber + ".txt");
            if (!new_phone_txtFile.Exists)
            {
                string[] modelInfo = new string[9];
                modelInfo[0] = phone.Name;
                if(phone.Display != null)
                {
                    modelInfo[1] = phone.Display.ToString() + " inches";
                }
                else
                {
                    modelInfo[1] = "Unknown";
                }

                modelInfo[2] = phone.Processor;

                if (phone.Memory != null)
                {
                    modelInfo[3] = phone.Memory.ToString() + " GB";
                }
                else
                {
                    modelInfo[3] = "Unknown";
                }

                if (phone.Price != null)
                {
                    modelInfo[4] = phone.Price.ToString() + " $";
                }
                else
                {
                    modelInfo[4] = "Unknown";
                }

                if (phone.InStock != null)
                {
                    modelInfo[5] = phone.InStock.ToString();
                }
                else
                {
                    modelInfo[5] = "Unknown";
                }

                modelInfo[6] = phone.Company.ToString();

                if (phone.LimitedEdition != null)
                {
                    modelInfo[7] = phone.LimitedEdition.ToString();
                }
                else
                {
                    modelInfo[7] = "Unknown";
                }

                modelInfo[8] = phone.Date.ToString();

                File.AppendAllText(directoryPath + "phone" + newModelNumber + ".txt",
                    $"Name: {modelInfo[0]}\nDisplay: " + $"{modelInfo[1]}\nProcessor: {modelInfo[2]}" +
                    $"\nMemory: {modelInfo[3]}\nPrice: {modelInfo[4]}\nInStock: {modelInfo[5]}\nCompany: " +
                    $"{modelInfo[6]}\nLimitedEditons: {modelInfo[7]}\nDate: {modelInfo[8]}");

                if(changeModelButton.Text != "Save changes")
                {
                    MessageBox.Show("A New model has been created!");
                }
                else
                {
                    MessageBox.Show("Model has been updated!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModelsView modelsView = new ModelsView();
            modelsView.Show();
            this.Hide();
        }

        public void CreateComboBoxElements()
        {
            string directoryPath = @"E:\C_sharp_labs\VP_lab1\models\";
            DirectoryInfo models_directory = new DirectoryInfo(directoryPath);
            if (!models_directory.Exists)
                models_directory.Create();

            FileInfo[] files = models_directory.GetFiles();
            string fileNamePart = files[files.Length-1].Name.Split('.')[0];

            int modelNumber = int.Parse(fileNamePart.Split('e')[1]);

            for (int i = 1; i <= modelNumber; i++)
            {
                FileInfo file = new FileInfo(directoryPath + "phone" + i + ".txt");
                if (file.Exists)
                {
                    string nextModel = "model " + i;
                    this.comboBoxChangeModel.Items.AddRange(new object[] { nextModel });
                    this.comboBoxDeleteModel.Items.AddRange(new object[] { nextModel });
                }
            }
        }

        private void ChangeModelButton_Click(object sender, EventArgs e)
        {
            if(comboBoxChangeModel.Text != "" && comboBoxChangeModel.Text != null)
            {
                if (changeModelButton.Text != "Save changes")
                {
                    SetValues();
                    changeModelButton.Text = "Save changes";
                }
                else
                {
                    Phone phone = GetValues();

                    string directoryPath = @"E:\C_sharp_labs\VP_lab1\models\";
                    DirectoryInfo models_directory = new DirectoryInfo(directoryPath);
                    if (!models_directory.Exists)
                        models_directory.Create();
                    string modelNumber = comboBoxChangeModel.Text.Split(' ')[1];

                    FileInfo currentFile = new FileInfo(directoryPath + "phone" + modelNumber + ".txt");
                    currentFile.Delete();

                    CreateTxtFile(phone);
                    changeModelButton.Text = "Change model";
                }
            }
            else
            {
                MessageBox.Show("Model is not selected");
            }
        }

        private void DeleteModelButton_Click(object sender, EventArgs e)
        {
            if(comboBoxDeleteModel.Text != "" && comboBoxDeleteModel.Text != null)
            {
                string directoryPath = @"E:\C_sharp_labs\VP_lab1\models\";
                DirectoryInfo models_directory = new DirectoryInfo(directoryPath);
                if (!models_directory.Exists)
                    models_directory.Create();
                string modelNumber = comboBoxDeleteModel.Text.Split(' ')[1];

                FileInfo currentFile = new FileInfo(directoryPath + "phone" + modelNumber + ".txt");
                currentFile.Delete();
                MessageBox.Show("Model has been deleted");
            }
            else
            {
                MessageBox.Show("Model is not selected");
            }
        }

        private void SetValues()
        {
            if (comboBoxChangeModel.Text != "" && comboBoxChangeModel.Text != null)
            {
                string directoryPath = @"E:\C_sharp_labs\VP_lab1\models\";
                string selectedModel = comboBoxChangeModel.Text.Split(' ')[1];
                FileInfo file = new FileInfo(directoryPath + "phone" + selectedModel + ".txt");
                if (file.Exists)
                {
                    string fullFileInfo = File.ReadAllText(directoryPath + "phone" + selectedModel + ".txt");
                    string[] fileInfoArray = fullFileInfo.Split('\n');

                    textBox1.Text = fileInfoArray[0].Split(':')[1].Trim();
                    textBox1.ForeColor = Color.Black;

                    if (fileInfoArray[1].Split(':')[1].Trim() != "Unknown")
                    {
                        numericUpDown3.Value = int.Parse(fileInfoArray[1].Split(' ')[1]);
                    }
                    else
                    {
                        numericUpDown3.Value = 0;
                    }

                    processorSelect.SelectedItem = fileInfoArray[2].Split(':')[1].Trim();

                    if (fileInfoArray[3].Split(':')[1].Trim() != "Unknown")
                    {
                        numericUpDown2.Value = byte.Parse(fileInfoArray[3].Split(' ')[1]);
                    }
                    else
                    {
                        numericUpDown2.Value = 0;
                    }

                    if (fileInfoArray[4].Split(':')[1].Trim() != "Unknown")
                    {
                        string temp = fileInfoArray[4].Split(' ')[1];
                        numericUpDown1.Value = int.Parse(temp.Split('$')[0]);
                    }
                    else
                    {
                        numericUpDown1.Value = 0;
                    }

                    inStock.SelectedItem = fileInfoArray[5].Split(':')[1].Trim();
                    if (fileInfoArray[5].Split(':')[1].Trim() == "True")
                    {
                        inStock.SelectedIndex = 1;
                    }
                    else
                    {
                        inStock.SelectedIndex = -1;
                    }

                    inStock.Text = fileInfoArray[5].Split(':')[1].Trim();

                    companySelect.SelectedItem = fileInfoArray[6].Split(':')[1].Trim();
                    companySelect.Text = fileInfoArray[6].Split(':')[1].Trim();

                    //limitedEditionCheck.ThreeState = bool.Parse(fileInfoArray[7].Split(':')[1].Trim());
                }
            }
            else
            {
                MessageBox.Show("Model is not selected");
            }
        }
    }
}
