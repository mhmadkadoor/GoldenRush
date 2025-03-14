using System;

namespace GoldenRush
{

    public partial class Form1 : Form
    {
        Boolean StopGame = false;
        public Form1()
        {
            InitializeComponent();
            StopBtn.Hide();

            // Allow only one checked item in checkedListBox1
            checkedListBox1.ItemCheck += new ItemCheckEventHandler(checkedListBox1_ItemCheck);
        }

        private void checkedListBox1_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {

            Random random1 = new Random();
            Random random2 = new Random();
            Random random3 = new Random();
            while (true)
            {
                checkedListBox1.Enabled = false;
                StopGame = false;
                StartBtn.Enabled = false;
                StopBtn.Show();
                int limofrace = 722;
                Byte winner = 0;

                int hourse1Loc = 23;
                int hourse2Loc = 23;
                int hourse3Loc = 23;

                while (!(winner > 0))
                {
                    Hourse1.Location = new Point(hourse1Loc, 59);
                    hourse1Loc += random1.Next(1, 16);
                    Thread.Sleep(70);
                    Application.DoEvents();
                    if (hourse1Loc >= limofrace)
                    {
                        winner = 1;
                        continue;
                    }

                    Hourse2.Location = new Point(hourse2Loc, 156);
                    hourse2Loc += random2.Next(1, 17);
                    Thread.Sleep(70);
                    Application.DoEvents();
                    if (hourse2Loc >= limofrace)
                    {
                        winner = 2;
                        continue;
                    }

                    Hourse3.Location = new Point(hourse3Loc, 260);
                    hourse3Loc += random3.Next(1, 17);
                    Thread.Sleep(70);
                    Application.DoEvents();
                    if (hourse3Loc >= limofrace)
                    {
                        winner = 3;
                        continue;
                    }
                    if (StopGame)
                    {
                        break;
                    }
                }

                if (StopGame)
                {
                    StartBtn.Enabled = true;
                    checkedListBox1.Enabled = true;
                    StopBtn.Hide();
                    break;
                }

                if ((winner == 1 && checkedListBox1.GetItemChecked(0)) ||
                    (winner == 2 && checkedListBox1.GetItemChecked(1)) ||
                    (winner == 3 && checkedListBox1.GetItemChecked(2)))
                {
                    MessageBox.Show("You Win");
                }
                else
                {
                    MessageBox.Show("You Lose");
                }

                StartBtn.Enabled = true;
                checkedListBox1.Enabled = true;
                StopBtn.Hide();
                break;
            }


        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            StopBtn.Hide();
            StopGame = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
