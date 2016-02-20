using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Assignment_1
{
    public partial class Form1 : Form
    {
        WordList words = new WordList();
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            words.AddWord(wordToAdd.Text);
            wordToAdd.Clear();

            if (listBox1.DataSource == null)
            {
                listBox1.DataSource = words;
            }
            else
            {
                listBox1.Refresh();
            }    
        }

       
    }
}
       