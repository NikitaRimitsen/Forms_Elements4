﻿using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Forms_Elements
{
    public partial class Form1 : Form
    {
        TreeView tree;//объявляем вне формы, для того чтобы можно было использовать в других функциях //tree - дерево("меню")//создали
        Button btn;//создали кнопку
        Label lbl;
        PictureBox ptb;
        CheckBox ckb;
        CheckBox ckb2;
        CheckBox ckb3;
        CheckBox ckb4;
        CheckBox ckb5;
        CheckBox ckb6;
        CheckBox ckb7;
        RadioButton rdb;
        RadioButton rdb2;
        RadioButton r_btn1;
        RadioButton r_btn2;
        TabControl tabC;
        ListBox lb;
        DataGrid dg;

        public Form1()
        {
            //this - форма
            this.Height = 600;//свойство высота формы
            this.Width = 800;//свойство ширины формы, если это свойство то после, ставится =
            this.Text = "Vorm elementiga";//Text - название, заголовок формы
            this.BackColor = Color.Bisque;//фон для формы
            tree = new TreeView();
            tree.Dock = DockStyle.Left;//местоположение -  Left-слева
            tree.AfterSelect += Tree_AfterSelect;//Tree_AfterSelect - это (1)
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));//new - добавить//добавили кнопку в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("Silt-Label"));//добавили Label в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("PictureBox"));//добавили PictureBox в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("Märkeruut-Checkbox"));//добавили Checkbox в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("Radionupp-Radiobutton"));//добавили радиокнопку в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("Tekstkast-TextBox"));//добавили текстбокс в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("Kaart-TabControl"));//добавили Kaart в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("MessageBox"));//добавили MessageBox в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("ListBox"));//добавили ListBox в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("DataGridView"));//добавили ListBox в меню(дерево-меню)
            tn.Nodes.Add(new TreeNode("MainMenu"));//добавили ListBox в меню(дерево-меню)


            //Создаём кнопку(свойста его - местоположение, высота, ширина)
            btn = new Button();
            btn.BackColor = Color.Coral;//фон кнопки
            btn.Text = "Vajuta siia";//текст внутри кнопки
            btn.Location = new Point(150, 30);//Point(x,y) - местоположение кнопки
            btn.Height = 40;//высота кнопки
            btn.Width = 100;//ширина кнопки
            btn.Click += Btn_Click;//создаёт функцию если нажать на кнопку (tab)

            //pealkiri
            lbl = new Label();// создали Label
            lbl.Text = "Elamentide loomine c# abil";
            lbl.Size = new Size(600, 30);//Size(width,height)
            lbl.Location = new Point(150, 0); //Point(x,y) - местоположение Label
            lbl.MouseHover += Lbl_MouseHover;//мышка будет наведена на Label
            lbl.MouseLeave += Lbl_MouseLeave;//мышка будет наведена на Label


            //PictureBox
            ptb = new PictureBox();//создали PictureBox
            //ptb.Image = new Bitmap("horosho.jpg");
            ptb.Size = new Size(200, 100);
            ptb.Location = new Point(500, 100);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;

            //ptb.Image = Image.FromFile(@"..\..\image\horosho.jpg");

            ptb.ImageLocation = ("../../image/horosho.jpg");
            //Double_Click -> carusel (3-4 images) 1-2-3-4-1-2-3-4-....
            //ptb.Image = image.img1;

            ptb.DoubleClick += Ptb_DoubleClick;

            //CheckBox
            ckb = new CheckBox();
            ckb.Height = 30;
            ckb.Width = 130;
            ckb.Location = new Point(150,70);
            ckb.Text = "Фон";
            ckb.Click += Ckb_Click;

            //CheckBox 2
            ckb2 = new CheckBox();
            ckb2.Height = 30;
            ckb2.Width = 130;
            ckb2.Location = new Point(150, 100);
            ckb2.Text = "Секретная кнопка";
            ckb2.Click += Ckb2_Click;

            //CheckBox 3
            ckb3 = new CheckBox();
            ckb3.Height = 30;
            ckb3.Width = 130;
            ckb3.Location = new Point(150, 130);
            ckb3.Text = "Размер экрана маленький";
            ckb3.Click += Ckb3_Click;

            //CheckBox 4
            ckb4 = new CheckBox();
            ckb4.Height = 30;
            ckb4.Width = 130;
            ckb4.Location = new Point(150, 160);
            ckb4.Text = "Кнопка выключения";
            ckb4.Click += Ckb4_Click;

            //CheckBox 7
            ckb7 = new CheckBox();
            ckb7.Height = 30;
            ckb7.Width = 130;
            ckb7.Location = new Point(150, 190);
            ckb7.Text = "Шрифт";
            ckb7.Click += Ckb7_Click;

            //CheckBox 6
            ckb6 = new CheckBox();
            ckb6.Height = 30;
            ckb6.Width = 130;
            ckb6.Location = new Point(150, 220);
            ckb6.Text = "Ты уверен?";
            ckb6.Click += Ckb6_Click;

            

            //RadioButton
            rdb = new RadioButton();
            rdb.Height = 30;
            rdb.Width = 130;
            rdb.Location = new Point(150, 270);
            rdb.Text = "HTML";
            rdb.Click += Rdb_Click1;
            //RadioButton2
            rdb2 = new RadioButton();
            rdb2.Height = 30;
            rdb2.Width = 130;
            rdb2.Location = new Point(150, 300);
            rdb2.Text = "Python";
            rdb2.Click += Rdb2_Click;

            


            tree.Nodes.Add(tn);//связались
            this.Controls.Add(tree);//добавляет в форму




        }





        








        private void tabC_DoubleClick2(object sender, EventArgs e)
        {
            this.tabC.TabPages.Remove(tabC.SelectedTab);
        }


        /*private void TabC_Selected(object sender, EventArgs e)//Функция, которая закрывает все вкладки, если нажать на вкладку
        {
            //this.tabC.TabPages.Clear();
            this.tabC.TabPages.Remove(tabC.SelectedTab);
        }*/




        private void tabP4_DoubleClick(object sender, EventArgs e)
        {
            string title = "tabP" + (tabC.TabCount + 1).ToString();
            TabPage tb = new TabPage(title);
            tabC.TabPages.Add(tb);
        }


        private void Rdb_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("Хороший выбор", "Результат");
        }

        private void Rdb2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хороший выбор", "Результат");
        }

        private void Rdb_Click(object sender, EventArgs e)
        {
            if (r_btn1.Checked)
	        {
                this.BackColor = Color.Black;
                r_btn2.ForeColor = Color.White;
                r_btn1.ForeColor = Color.White;
                rdb.ForeColor = Color.White;
                rdb2.ForeColor = Color.White;
	        }
            else if (r_btn2.Checked)
	        {
                this.BackColor = Color.White;
                r_btn2.ForeColor = Color.Black;
                r_btn1.ForeColor = Color.Black;
                rdb.ForeColor = Color.Black;
                rdb2.ForeColor = Color.Black;
	        }
        }

        int scetciksrift = 0;
        private void Ckb7_Click(object sender, EventArgs e)
        {
            scetciksrift++;
            if (scetciksrift == 1)
            {
                this.Font = new Font("Arial", 18, FontStyle.Bold);
            }
            else if (scetciksrift == 2)
            {
                this.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                scetciksrift = 0;
            }

        }

        


        private void Ckb6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void Ckb4_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ckb6);
            
        }

        int scetcikrazmer = 0;
        private void Ckb3_Click(object sender, EventArgs e)
        {
            scetcikrazmer++;
            if (scetcikrazmer == 1)
            {
                this.Height = 800;//свойство высота формы
                this.Width = 1100;
                ckb3.Text = "Размер экрана большой";
            }
            else if (scetcikrazmer == 2)
            {
                this.Height = 600;//свойство высота формы
                this.Width = 800;
                ckb3.Text = "Размер экрана маленький";
                scetcikrazmer = 0;
            }
        }


        private void Ckb2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.tthk.ee/");

        }

        int scetcikfon = 0;
        private void Ckb_Click(object sender, EventArgs e)
        {
            scetcikfon++;
            if (scetcikfon == 1)
            {
                this.BackColor = Color.Salmon;
            }
            else if (scetcikfon == 2)
            {
                this.BackColor = Color.Bisque;
                scetcikfon = 0;
            }
            
        }

        int scetcikkartinok = 0;
        private void Ptb_DoubleClick(object sender, EventArgs e)
        {
            //string[] img = ("bob.gif", "google.gif", "Lennuk.jpg", "priroda.jpg");
            //ptb.ImageLocation = ("../../image/samolet.jpg");
            scetcikkartinok++; //тут я увеличиваю значения счетчика на 1
            if (scetcikkartinok == 1)
            {
                
                ptb.ImageLocation = ("../../image/hello.gif");

            }
            else if (scetcikkartinok == 2)
            {

                ptb.ImageLocation = ("../../image/samolet.jpg");
            }
            else if (scetcikkartinok == 3)
            {
                ptb.ImageLocation = ("../../image/kvadratcernej.jpeg");
            }
            else if (scetcikkartinok == 4)
            {

                scetcikkartinok = 0; //сбрасывает счетччик, что бы начать все заново
                ptb.ImageLocation = ("../../image/horosho.jpg");
            }

        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            //var rand = new Random();
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(82, 212, 199);//меняет фон label
        }

        private void Btn_Click(object sender, EventArgs e)//функция если будет нажата кнопка
        {

            btn.Text = "Tere tulemast!";
            this.BackColor = Color.LightYellow;
            ptb.ImageLocation = ("../../image/samolet.jpg");

        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)//(1) вот это
        {
            if (e.Node.Text == "Nupp")//если будет нажата nupp(в меню)
            {
                this.Controls.Add(btn);//добавляет кнопку в форму
            }
            else if (e.Node.Text == "Silt-Label")//если будет нажата Silt-Label(в меню)
            {
                this.Controls.Add(lbl);//добавляет Label в форму
            }
            else if (e.Node.Text == "PictureBox")
            {
                this.Controls.Add(ptb);
            }
            else if (e.Node.Text == "Märkeruut-Checkbox")
            {
                this.Controls.Add(ckb);
                this.Controls.Add(ckb2);
                this.Controls.Add(ckb3);
                this.Controls.Add(ckb4);
                this.Controls.Add(ckb7);
            }
            else if (e.Node.Text == "Radionupp-Radiobutton")
            {
                this.Controls.Add(rdb);
                this.Controls.Add(rdb2);
                r_btn1=new RadioButton();
                r_btn1.Text ="Must teema";
                r_btn1.Location = new Point(150,330);
                r_btn2=new RadioButton();
                r_btn2.Text ="Valge teema";
                r_btn2.Location = new Point(150,360);
                this.Controls.Add(r_btn1);
                this.Controls.Add(r_btn2);
                r_btn1.CheckedChanged += new EventHandler(Rdb_Click);
                r_btn2.CheckedChanged += new EventHandler(Rdb_Click);

            }
            else if (e.Node.Text == "MessageBox")
            {
                MessageBox.Show("MessageBox", "Самое обычное окно");
                var answer = MessageBox.Show("Хочешь посмотреть какая сегодня погода?", "Погода", MessageBoxButtons.YesNo);
                if(answer == DialogResult.Yes)
                {
                    Process.Start("https://pogoda.ee/");

                    string text = Interaction.InputBox("Напиши своё впечатление о погоде", "InputBox", "Mingi tekst");
                    if(MessageBox.Show("Хочешь добавить на экран?", "Текст сохранён", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lbl.Text = text;
                        Controls.Add(lbl);
                    }
                    else
                    {
                        MessageBox.Show("Не расстраивай меня", "Грустное окно");

                    }
                }
                else
                {
                    MessageBox.Show("Ты меня расстраиваешь", "Грустное окно");

                }
            }
            else if (e.Node.Text == "Kaart-TabControl")
	        {
                tabC = new TabControl();
                tabC.Location = new Point(500,220);
                tabC.Size = new Size(250,200);
                TabPage tabP1 = new TabPage("Esimene");//Заголовок вкладки. Создали вкладку
                WebBrowser wb = new WebBrowser();
                wb.Url=new Uri("https://www.tthk.ee/");
                tabP1.Controls.Add(wb);

                
                TabPage tabP2 = new TabPage("Teine");//Заголовок вкладки. Создали вкладку
                WebBrowser wb2 = new WebBrowser();
                wb2.Url=new Uri("https://github.com/NikitaRimitsen/");
                tabP2.Controls.Add(wb2);

                TabPage tabP3 = new TabPage("Kolmas");//Заголовок вкладки. Создали вкладку
                WebBrowser wb3 = new WebBrowser();
                wb3.Url=new Uri("https://www.youtube.com/");
                tabP3.Controls.Add(wb3);

                TabPage tabP4 = new TabPage("Neljas");//Заголовок вкладки. Создали вкладку
                tabP4.DoubleClick += tabP4_DoubleClick;
                tabC.DoubleClick += tabC_DoubleClick2;

                //tabC.Selected += TabC_Selected;//Создали функцию, которая закрывает все вкладки, если нажать на вкладку

                tabC.Controls.Add(tabP1);
                tabC.Controls.Add(tabP2);
                tabC.Controls.Add(tabP3);
                tabC.Controls.Add(tabP4);
                this.Controls.Add(tabC);

                
	        }
            else if (e.Node.Text == "ListBox")
	        {
                lb = new ListBox();
                lb.Items.Add("Roheline");
                lb.Items.Add("Punane");
                lb.Items.Add("Sinine");
                lb.Items.Add("Hall");
                lb.Items.Add("Kollane");
                lb.Location=new Point(150, 400);
                lb.SelectedIndexChanged+=new EventHandler(Is_SelectedIndexChanged);
                this.Controls.Add(lb);

	        }
            else if (e.Node.Text == "DataGridView")
            {
                DataSet dg = new DataSet("XML fail. Menüü");
                dg.ReadXml(@"..\..\image\note.xml");
                DataGridView ds=new DataGridView();
                ds.Width = 480;
                ds.Height = 120;;
                ds.Location= new Point(300,430);
                ds.AutoGenerateColumns = true;
                ds.DataSource = dg;
                ds.DataMember = "food";


                this.Controls.Add(ds);
            }
            else if(e.Node.Text == "MainMenu")
            {
                MainMenu menu = new MainMenu();
                MenuItem menuFile = new MenuItem("File");
                menuFile.MenuItems.Add("Exit",new EventHandler(menuFile_Exit_Select));
                menuFile.MenuItems.Add("Suur",new EventHandler(menuFile_Suur_Select));
                menuFile.MenuItems.Add("Postimees",new EventHandler(menuFile_Post_Select));
                menu.MenuItems.Add(menuFile);
                this.Menu = menu;
            }
        }

        private void menuFile_Post_Select(object sender, EventArgs e)
        {
            Process.Start("https://rus.postimees.ee/");
        }

        private void menuFile_Suur_Select(object sender, EventArgs e)
        {
            this.Height = 1600;//свойство высота формы
            this.Width = 1800;
        }

        private void menuFile_Exit_Select(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Is_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(lb.SelectedIndex)
	        {
		        case 0:
                    lb.BackColor = Color.Green;
                    break;
		        case 1:
                    lb.BackColor = Color.Red;
                    break;
		        case 2:
                    lb.BackColor = Color.Blue;
                    break;
		        case 3:
                    lb.BackColor = Color.Gray;
                    break;
                default:
                    lb.BackColor = Color.Yellow;
                    break;

	        }
            
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
