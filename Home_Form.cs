using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Home_Form : Form
    {
        private string ImagePath;

        public Home_Form(string _Admin, string _ImagePath, string _DataNow)
        {
            InitializeComponent();
            lblAdmin.Text = _Admin;
            ImagePath = _ImagePath;
            lblDateNow.Text = _DataNow;
        }
        void LoadCategoriesToAllTasks(bool All = true)
        {
            // simple when program loads

            foreach (ListViewGroup Lvg in LvAllTasks.Groups)
            {
                CbCategory.Items.Add(Lvg.Header);
            }

            CbCategory.SelectedIndex = 2;

        }
        private void Home_Form_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(ImagePath))
                pictureBox1.Image = Image.FromFile(ImagePath);
            LoadCategoriesToAllTasks();
            McTaskDate.MinDate = DateTime.Now;
            CbPriority.SelectedIndex = 2;
        }
        bool CheckIsTaskExistLv(string TaskTitle, ListView LV)
        {
            foreach (ListViewItem item in LV.Items)
            {
                if (TaskTitle == item.Text)
                    return true;
            }
            return false;
        }
        void UpdateTasksLabel(Label Lbl, ListView LV)
        {
            Lbl.Text = LV.Items.Count.ToString();
        }
        void UpdateProgressBarLabel(Label PgbLabel, int Value)
        {
            PgbLabel.Text = Value + "%";
        }
        void ShowNotifyIcon(string Text, string Title, NotifyIcon notifyIcon)
        {
            notifyIcon.BalloonTipText = Text;
            notifyIcon.BalloonTipTitle = Title;
            notifyIcon.Icon = SystemIcons.Shield;
            notifyIcon.ShowBalloonTip(10);
        }
        void UpdateProgressBar(ProgressBar ProgressBar, ListView LV, Label PgbLabel, string NotifyIconTitle = "You Have Completed All Daily Tasks")
        {
            // if no items then value = 0 

            if (LV.Items.Count == 0)
            {
                ProgressBar.Value = 0;
                UpdateProgressBarLabel(PgbLabel, ProgressBar.Value);
                return;
            }
            // (progress bar value / ListViewItems.Count ) all Multiply Lv.CheckedItems.Count
            // Example
            // ((100 / 5) = 20) * 3 = 60 % so we checked 3 of 5 and it's 60 %  

            int Formula = (100 / ((int)LV.Items.Count)) * LV.CheckedItems.Count;

            if (LV.CheckedItems.Count == LV.Items.Count)
            {
                // this means all checked then 100%

                Formula = 100;
                ShowNotifyIcon("All Daily Tasks Have Done !", "Great Work", notifyIcon1);
            }

            // Finally Progress Bar Value = Like I Said In Top if We have 10 Items And Checked Items = 3 it will be 30% and so on 

            ProgressBar.Value = Formula;

            // simple update label

            UpdateProgressBarLabel(PgbLabel, ProgressBar.Value);

        }
        void AddTaskToTodayTasksLv()
        {
            if (string.IsNullOrEmpty(TxtTodayTasksTitle.Text))
            {
                MessageBox.Show("Title Can't Be Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CheckIsTaskExistLv(TaskTitle: TxtTodayTasksTitle.Text, lvTodayTask))
            {
                MessageBox.Show("Task Exist", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem item = new ListViewItem(TxtTodayTasksTitle.Text);
            lvTodayTask.Items.Add(item);
            UpdateTasksLabel(lblTasksCount, lvTodayTask);
            UpdateProgressBar(PgbTodayTasks, lvTodayTask, lblTodaysTaskPgb, "You Have Completed All Daily Tasks");
        }
        private void BtnAddTodayTask_Click(object sender, EventArgs e)
        {
            AddTaskToTodayTasksLv();
        }
        private void lvTodayTask_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateProgressBar(PgbTodayTasks, lvTodayTask, lblTodaysTaskPgb, "You Have Completed All Daily Tasks");

        }
        void DeleteSelectedItem(ListView Lv)
        {
            if (Lv.Items.Count == 0)
            {
                MessageBox.Show("No Item Selcet", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (ListViewItem item in Lv.SelectedItems)
            {
                item.Remove();
            }
        }
        private void BtnDeleteTodayTask_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem(lvTodayTask);
            UpdateTasksLabel(lblTasksCount, lvTodayTask);
            UpdateProgressBar(PgbTodayTasks, lvTodayTask, lblTodaysTaskPgb);
        }
        ListViewGroup GetCurrentGroup()
        {
            foreach (ListViewGroup Group in LvAllTasks.Groups)
            {
                if (Group.Header.ToUpper() == CbCategory.Text.ToUpper())
                {
                    return Group;
                }
            }

            return null;

        }
        ListViewItem CloneItem(ListViewItem item)
        {

            // Clones Item And Return  Cloned Item Becuase If We Have Two List Views And need To Copy From Two
            // The Compiler Gives Us Error if we add new item without clone it 

            ListViewItem clonedItem = new ListViewItem();
            clonedItem.Text = item.Text;

            clonedItem.ImageIndex = item.ImageIndex;
            clonedItem.Group = item.Group;
            clonedItem.Tag = item.Tag;
            clonedItem.Checked = item.Checked;
            for (byte i = 1; i < item.SubItems.Count; i++)
            {
                clonedItem.SubItems.Add(item.SubItems[i]);
            }
            return clonedItem;
        }
        void MoveItemsToAnotherListView(ListView Lv1, ListView Lv2, bool Checked = true)
        {
            foreach (ListViewItem Item in Lv1.Items)
            {
                // To Move Checked Items 
                if (Checked && Item.Checked == true)
                {
                    Lv2.Items.Add(CloneItem(Item));
                }
            }
        }
        ListView CopyListViewOrderd(ListView ListViewToCopyFrom)
        {
            // difine new listview to copy into and return it 
            ListView ListViewToCopyInto = new ListView();



            // Copy Groups

            for (byte i = 0; i < ListViewToCopyFrom.Groups.Count; i++)
            {
                ListViewToCopyInto.Groups.Add(ListViewToCopyFrom.Groups[i].Name, ListViewToCopyFrom.Groups[i].Header);
            }

            // Copy Colmns

            for (byte i = 0; i < ListViewToCopyFrom.Columns.Count; i++)
            {
                ListViewToCopyInto.Columns.Add(ListViewToCopyFrom.Columns[i].Text, ListViewToCopyFrom.Columns[i].Width);
            }

            // Copy Items Ordered Red Flags First then orange then green in the new listview

            foreach (ListViewItem Item in ListViewToCopyFrom.Items)
            {
                if (Item.ImageIndex == 0)
                {
                    ListViewToCopyInto.Items.Add(CloneItem(Item));
                }
            }

            foreach (ListViewItem Item in ListViewToCopyFrom.Items)
            {
                if (Item.ImageIndex == 1)
                {
                    ListViewToCopyInto.Items.Add(CloneItem(Item));
                }
            }

            foreach (ListViewItem Item in ListViewToCopyFrom.Items)
            {
                if (Item.ImageIndex == 2)
                {
                    ListViewToCopyInto.Items.Add(CloneItem(Item));
                }
            }

            // return it orderd this function will call after every add task or delete task 

            return ListViewToCopyInto;
        }
        ListView CopyListViewSame(ListView ListViewToCopyInto, ListView ListViewToCopyFrom)
        {


            // Copy All

            for (byte i = 0; i < ListViewToCopyFrom.Groups.Count; i++)
            {
                ListViewToCopyInto.Groups.Add(ListViewToCopyFrom.Groups[i].Name, ListViewToCopyFrom.Groups[i].Header);
            }



            // Copy Colmns

            for (byte i = 0; i < ListViewToCopyFrom.Columns.Count; i++)
            {
                ListViewToCopyInto.Columns.Add(ListViewToCopyFrom.Columns[i].Text, ListViewToCopyFrom.Columns[i].Width);
            }

            // Copy Items 

            foreach (ListViewItem Item in ListViewToCopyFrom.Items)
            {

                ListViewToCopyInto.Items.Add(CloneItem(Item));

            }

            return ListViewToCopyInto;
        }

        void AddTaskDetailed(ListViewItem Item)
        {
            // Follow Image list (priorty Image List To understand)

            Item.Text = TxtTitleLvAllTasks.Text;

            if (CbPriority.SelectedIndex == 0)
            {
                // "Red";
                Item.ImageIndex = 0;
            }
            else if (CbPriority.SelectedIndex == 1)
            {
                // "Yellow";
                Item.ImageIndex = 1;
            }
            else
            {
                // "Green";
                Item.ImageIndex = 2;
            }

            Item.SubItems.Add(CbPriority.Text);

            // Add Date Simple

            Item.SubItems.Add(McTaskDate.SelectionStart.ToString("dd/MM//yyyy"));

            Item.Group = GetCurrentGroup();

        }
        void AddTaskLvAllTasks()
        {
            if (string.IsNullOrEmpty(TxtTitleLvAllTasks.Text))
            {
                MessageBox.Show("Title Can't Be Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CheckIsTaskExistLv(TaskTitle: TxtTitleLvAllTasks.Text, LvAllTasks))
            {
                MessageBox.Show("Task Exist", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem item = new ListViewItem();
            AddTaskDetailed(item);
            LvAllTasks.Items.Add(item);
        }
        private void BtnAddTaskLvAllTasks_Click(object sender, EventArgs e)
        {
            AddTaskLvAllTasks();
            UpdateProgressBar(PgbAllTasks, LvAllTasks, lblAllTasksProgress, "You Done All Tasks.");
            UpdateTasksLabel(lblAllTasks, LvAllTasks);
        }

        private void LvAllTasks_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateProgressBar(PgbAllTasks, LvAllTasks, lblAllTasksProgress, "You Done All Tasks.");
        }
        bool CheckCategoryExistInListViewGroup(string GroupHeader, ListView Lv)
        {
            foreach (ListViewGroup listViewGroup in Lv.Groups)
            {
                if (GroupHeader.ToUpper() == listViewGroup.Header.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }
        void AddCategoryToComboBox(ComboBox Cb, string Category)
        {
            Cb.Items.Add(Category);
        }
        void AddCategory()
        {
            if (string.IsNullOrEmpty(TxtCategoryTitle.Text))
            {
                MessageBox.Show("Category Title Cannot Be Empty", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CheckCategoryExistInListViewGroup(TxtCategoryTitle.Text, lvTodayTask))
            {
                MessageBox.Show("Category Exist", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LvAllTasks.Groups.Add(TxtCategoryTitle.Text.ToLower(), TxtCategoryTitle.Text.ToUpper());
            AddCategoryToComboBox(CbCategory, TxtCategoryTitle.Text);
        }
        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory();
        }
        void DeleteTasksLvAllTasks(ListView Lv)
        {
            if (Lv.CheckedItems.Count == 0)
            {
                MessageBox.Show("No Items Select", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (ListViewItem item in Lv.CheckedItems)
            {
                item.Remove();
            }
        }
        private void btnDeleteTasksLvAllTasks_Click(object sender, EventArgs e)
        {
            DeleteTasksLvAllTasks(LvAllTasks);
            UpdateTasksLabel(lblAllTasks, LvAllTasks);
            UpdateProgressBar(PgbAllTasks, LvAllTasks, lblAllTasksProgress);
        }


        void DeleteAllTasks(ListView Lv, Label UpdateLabel)
        {
            UpdateLabel.Text = "0";
            foreach (ListViewItem item in Lv.Items)
            {
                item.Remove();
            }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAllTasks(lvTodayTask, lblTasksCount);
            UpdateProgressBar(PgbTodayTasks, lvTodayTask, lblTodaysTaskPgb);
        }

        private void allTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tc1.SelectedIndex = 1;
        }

        private void doneTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tc1.SelectedIndex = 2;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tc1.SelectedIndex = 0;
        }

        private void taskDoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tc1.SelectedIndex = 2;
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tc1.SelectedIndex = 0;
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tc1.SelectedIndex = 1;
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteAllTasks(LvAllTasks, lblAllTasks);
            UpdateProgressBar(PgbAllTasks, LvAllTasks, lblAllTasksProgress);
        }
        void UpdateDoneTasksLabel()
        {
            lblTasksDoned.Text = LvDoneTasks.Items.Count.ToString();
        }

        private void Tc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tc1.SelectedIndex == 2)
            {
                MoveItemsToAnotherListView(LvAllTasks, LvDoneTasks);
                UpdateDoneTasksLabel();
            }
            else
            {
                DeleteAllTasks(LvDoneTasks, lblTasksDoned);
            }
        } 
        void SortLAllTasksListViewByPriroity()
        {
            // Sorting 
            // You Must Do It This Way Just Understand it and copy it 
            ListView ListViewToCopyFrom = new ListView();

            // listView Ordered With Every Group the priorities is sorted

            ListViewToCopyFrom = CopyListViewOrderd(LvAllTasks);

            // clear current listview all tasks

            LvAllTasks.Clear();

            // you must you must Send LvAllTasks As Parameter To Make Change on it 
            // if you'r don't send it as parameter and assigend it only it will make error and listview will be empty

            CopyListViewSame(LvAllTasks, ListViewToCopyFrom);
        }
        private void byPriorityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortLAllTasksListViewByPriroity();
        }
        void DeleteAllTasks(ListView Lv)
        {
            foreach (ListViewItem item in Lv.Items)
            {
                item.Remove();
            }
        }
        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAllTasks(LvAllTasks);
            UpdateProgressBar(PgbAllTasks, LvAllTasks, lblAllTasksProgress, "You Done All Tasks.");
            UpdateTasksLabel(lblAllTasks, LvAllTasks);
        }

        private void removeSelectedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem(LvAllTasks);
            UpdateProgressBar(PgbAllTasks, LvAllTasks, lblAllTasksProgress, "You Done All Tasks.");
            UpdateTasksLabel(lblAllTasks, LvAllTasks);
        }
        void CheckUncheckSelectedItem(ListView Lv)
        {
            if (Lv.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Tasks Select To Check", "Check/Unchek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // It's By ref Not Like C++ Hhahahahhahaha

            foreach (ListViewItem Item in Lv.SelectedItems)
            {

                // If Checked Then Unchek 
                if (Item.Checked)
                    Item.Checked = false;
                // if Not Checked Then Check
                else
                    Item.Checked = true;
            }
        }
        private void checkUncheckToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CheckUncheckSelectedItem(lvTodayTask);
            UpdateProgressBar(PgbTodayTasks, lvTodayTask, lblTodaysTaskPgb, "You Have Completed All Daily Tasks");
        }

        private void checkUncheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUncheckSelectedItem(LvAllTasks);
            UpdateProgressBar(PgbAllTasks, LvAllTasks, lblAllTasksProgress, "You Done All Tasks.");
        }
        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            SignIn AppForm = new SignIn();
            this.Hide();
            AppForm.ShowDialog();
            this.Close();
        }

        private void removeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem(lvTodayTask);
            UpdateProgressBar(PgbTodayTasks, lvTodayTask, lblTodaysTaskPgb, "You Done All Tasks.");
            UpdateTasksLabel(lblTasksCount, lvTodayTask);
        }
    }
}
