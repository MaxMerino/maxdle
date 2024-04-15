using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxdle
{
    public partial class Form2 : Form
    {
        List<Button> intent1 = new List<Button>();
        List<Button> intent2 = new List<Button>();
        List<Button> intent3 = new List<Button>();
        List<Button> intent4 = new List<Button>();
        List<Button> intent5 = new List<Button>();
        List<Button> intent6 = new List<Button>();
        List<List<Button>> llistaIntents = new List<List<Button>>();
        public Form2()
        {
            InitializeComponent();
            button1.Click += new EventHandler(lletresClick);
            button2.Click += new EventHandler(lletresClick);
            button3.Click += new EventHandler(lletresClick);
            button4.Click += new EventHandler(lletresClick);
            button5.Click += new EventHandler(lletresClick);
            button6.Click += new EventHandler(lletresClick);
            button7.Click += new EventHandler(lletresClick);
            button8.Click += new EventHandler(lletresClick);
            button9.Click += new EventHandler(lletresClick);
            button10.Click += new EventHandler(lletresClick);
            button11.Click += new EventHandler(lletresClick);
            button12.Click += new EventHandler(lletresClick);
            button13.Click += new EventHandler(lletresClick);
            button14.Click += new EventHandler(lletresClick);
            button15.Click += new EventHandler(lletresClick);
            button16.Click += new EventHandler(lletresClick);
            button17.Click += new EventHandler(lletresClick);
            button18.Click += new EventHandler(lletresClick);
            button19.Click += new EventHandler(lletresClick);
            button20.Click += new EventHandler(lletresClick);
            button21.Click += new EventHandler(lletresClick);
            button22.Click += new EventHandler(lletresClick);
            button23.Click += new EventHandler(lletresClick);
            button24.Click += new EventHandler(lletresClick);
            button25.Click += new EventHandler(lletresClick);
            button26.Click += new EventHandler(lletresClick);
            button27.Click += new EventHandler(lletresClick);

            intent1.Add(button29);
            intent1.Add(button30);
            intent1.Add(button31);
            intent1.Add(button32);
            intent1.Add(button33);

            intent2.Add(button38);
            intent2.Add(button37);
            intent2.Add(button36);
            intent2.Add(button35);
            intent2.Add(button34);

            intent3.Add(button43);
            intent3.Add(button42);
            intent3.Add(button41);
            intent3.Add(button40);
            intent3.Add(button39);

            intent4.Add(button48);
            intent4.Add(button47);
            intent4.Add(button46);
            intent4.Add(button45);
            intent4.Add(button44);

            intent5.Add(button53);
            intent5.Add(button52);
            intent5.Add(button51);
            intent5.Add(button50);
            intent5.Add(button49);

            intent6.Add(button58);
            intent6.Add(button57);
            intent6.Add(button56);
            intent6.Add(button55);
            intent6.Add(button54);

            llistaIntents.Add(intent1);
            llistaIntents.Add(intent2);
            llistaIntents.Add(intent3);
            llistaIntents.Add(intent4);
            llistaIntents.Add(intent5);
            llistaIntents.Add(intent6);

            DadesPartida.intent = 0;
            DadesPartida.columna = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void lletresClick(object sender, EventArgs e)
        {
            Button lletra = (Button)sender;
            if (DadesPartida.columna < llistaIntents[DadesPartida.intent].Count)
            {
                llistaIntents[DadesPartida.intent][DadesPartida.columna].Text = lletra.Text;

                DadesPartida.columna += 1;
            }

        }

        private void button59_Click(object sender, EventArgs e)
        {
            if(DadesPartida.columna > 0)
            {
                DadesPartida.columna--;
                llistaIntents[DadesPartida.intent][DadesPartida.columna].Text = "_";
                
            }
            else if(DadesPartida.columna == 0)
            {
                llistaIntents[DadesPartida.intent][DadesPartida.columna].Text = "_";
            }
           
        }

        private void button28_Click(object sender, EventArgs e)
        {
            List<char> lletres = new List<char>();
            
           
            if(DadesPartida.intent < llistaIntents.Count-1)
            {
                

                for (int i = 0; i < llistaIntents[DadesPartida.intent].Count(); i++)
                {
                    lletres.Add(llistaIntents[DadesPartida.intent][i].Text.ToCharArray()[0]);
                }
                DadesPartida.lletresIntent = lletres;


                DadesPartida.intent++;
                DadesPartida.columna = 0;
                for (int i = 0; i < llistaIntents[DadesPartida.intent].Count(); i++)
                {
                    llistaIntents[DadesPartida.intent][i].Text = "_";
                }
            }

           
        }
    }
}
