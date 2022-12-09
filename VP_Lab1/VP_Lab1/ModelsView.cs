using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VP_Lab1
{
    public partial class ModelsView : Form
    {
        public ModelsView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CreateComboBoxElements();
        }

        public void CreateComboBoxElements()
        {
            string directoryPath = @"E:\C_sharp_labs\VP_lab1\models\";
            DirectoryInfo models_directory = new DirectoryInfo(directoryPath);
            if (!models_directory.Exists)
                models_directory.Create();
            int modelNumber = models_directory.GetFiles().Length;

            for (int i = 1; i <= modelNumber; i++)
            {
                FileInfo file = new FileInfo(directoryPath + "phone" + i + ".txt");
                if (file.Exists)
                {
                    string nextModel = "model " + i;
                    this.comboBox1.Items.AddRange(new object[] { nextModel });
                }
            }
        }

        private void ShowModelInfo_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "" && comboBox1 != null)
            {
                string directoryPath = @"E:\C_sharp_labs\VP_lab1\models\";
                string selectedModel = comboBox1.Text.Split(' ')[1];
                string fullFileInfo = File.ReadAllText(directoryPath + "phone" + selectedModel + ".txt");
                string[] fileInfoArray = fullFileInfo.Split('\n');

                model_info_name.Text = fileInfoArray[0];

                model_info_display.Text = fileInfoArray[1];

                model_info_processor.Text = fileInfoArray[2];

                model_info_memory.Text = fileInfoArray[3];

                model_info_price.Text = fileInfoArray[4];

                model_info_inStock.Text = fileInfoArray[5];

                model_info_company.Text = fileInfoArray[6];

                model_info_limitedEdition.Text = fileInfoArray[7];

                model_info_date.Text = fileInfoArray[8];
            }
        }

        private void Open_ModelCreator_Click(object sender, EventArgs e)
        {
            ModelsCreator modelsCreator = new ModelsCreator();
            modelsCreator.Show();
            this.Hide();
        }
    }
}
