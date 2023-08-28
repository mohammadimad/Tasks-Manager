
namespace WindowsFormsApp17
{
    partial class Home_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Form));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Family", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Work", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Fun", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Study", System.Windows.Forms.HorizontalAlignment.Left);
            this.Cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUncheckToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PriorityImgList = new System.Windows.Forms.ImageList(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LvDoneTasks = new System.Windows.Forms.ListView();
            this.lblTasksDoned = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAllTasksProgress = new System.Windows.Forms.Label();
            this.lblAllTasks = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PgbAllTasks = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.LvAllTasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cms2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkUncheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTasksLvAllTasks = new System.Windows.Forms.Button();
            this.GbCreateNewTaskLvAllTasks = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbPriority = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAddTaskLvAllTasks = new System.Windows.Forms.Button();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.TxtTitleLvAllTasks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GbCreatNewCategory = new System.Windows.Forms.GroupBox();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.TxtCategoryTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.McTaskDate = new System.Windows.Forms.MonthCalendar();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.tasksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskDoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnSignOut = new System.Windows.Forms.Button();
            this.PgbTodayTasks = new System.Windows.Forms.ProgressBar();
            this.lblTodaysTaskPgb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTasksCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvTodayTask = new System.Windows.Forms.ListView();
            this.GbTodayTask = new System.Windows.Forms.GroupBox();
            this.BtnAddTodayTask = new System.Windows.Forms.Button();
            this.TxtTodayTasksTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.GbDeleteTask = new System.Windows.Forms.GroupBox();
            this.BtnDeleteTodayTask = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doneTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tc1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Cms1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Cms2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GbCreateNewTaskLvAllTasks.SuspendLayout();
            this.GbCreatNewCategory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GbTodayTask.SuspendLayout();
            this.GbDeleteTask.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.Tc1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cms1
            // 
            this.Cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkUncheckToolStripMenuItem1,
            this.removeSelectedToolStripMenuItem});
            this.Cms1.Name = "Cms1";
            this.Cms1.Size = new System.Drawing.Size(165, 48);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove Selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem_Click);
            // 
            // checkUncheckToolStripMenuItem1
            // 
            this.checkUncheckToolStripMenuItem1.Name = "checkUncheckToolStripMenuItem1";
            this.checkUncheckToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.checkUncheckToolStripMenuItem1.Text = "Check/Uncheck";
            this.checkUncheckToolStripMenuItem1.Click += new System.EventHandler(this.checkUncheckToolStripMenuItem1_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // PriorityImgList
            // 
            this.PriorityImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PriorityImgList.ImageStream")));
            this.PriorityImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.PriorityImgList.Images.SetKeyName(0, "red.png");
            this.PriorityImgList.Images.SetKeyName(1, "orange.png");
            this.PriorityImgList.Images.SetKeyName(2, "green.png");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LvDoneTasks);
            this.tabPage3.Controls.Add(this.lblTasksDoned);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.menuStrip1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(994, 744);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Task Done";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LvDoneTasks
            // 
            this.LvDoneTasks.CheckBoxes = true;
            this.LvDoneTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvDoneTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LvDoneTasks.HideSelection = false;
            this.LvDoneTasks.Location = new System.Drawing.Point(1, 81);
            this.LvDoneTasks.Name = "LvDoneTasks";
            this.LvDoneTasks.Size = new System.Drawing.Size(975, 493);
            this.LvDoneTasks.TabIndex = 25;
            this.LvDoneTasks.UseCompatibleStateImageBehavior = false;
            this.LvDoneTasks.View = System.Windows.Forms.View.List;
            // 
            // lblTasksDoned
            // 
            this.lblTasksDoned.AutoSize = true;
            this.lblTasksDoned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasksDoned.ForeColor = System.Drawing.Color.Teal;
            this.lblTasksDoned.Location = new System.Drawing.Point(178, 53);
            this.lblTasksDoned.Name = "lblTasksDoned";
            this.lblTasksDoned.Size = new System.Drawing.Size(24, 25);
            this.lblTasksDoned.TabIndex = 24;
            this.lblTasksDoned.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(1, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tasks Finshed : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToolStripMenuItem2
            // 
            this.goToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.taskToolStripMenuItem});
            this.goToolStripMenuItem2.Name = "goToolStripMenuItem2";
            this.goToolStripMenuItem2.Size = new System.Drawing.Size(34, 20);
            this.goToolStripMenuItem2.Text = "Go";
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Z)));
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.taskToolStripMenuItem.Text = "Task";
            this.taskToolStripMenuItem.Click += new System.EventHandler(this.taskToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblAllTasksProgress);
            this.tabPage2.Controls.Add(this.lblAllTasks);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.PgbAllTasks);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.LvAllTasks);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.GbCreateNewTaskLvAllTasks);
            this.tabPage2.Controls.Add(this.GbCreatNewCategory);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.menuStrip3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 744);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAllTasksProgress
            // 
            this.lblAllTasksProgress.AutoSize = true;
            this.lblAllTasksProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTasksProgress.ForeColor = System.Drawing.Color.Teal;
            this.lblAllTasksProgress.Location = new System.Drawing.Point(393, 107);
            this.lblAllTasksProgress.Name = "lblAllTasksProgress";
            this.lblAllTasksProgress.Size = new System.Drawing.Size(35, 24);
            this.lblAllTasksProgress.TabIndex = 21;
            this.lblAllTasksProgress.Text = "0%";
            // 
            // lblAllTasks
            // 
            this.lblAllTasks.AutoSize = true;
            this.lblAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTasks.ForeColor = System.Drawing.Color.Teal;
            this.lblAllTasks.Location = new System.Drawing.Point(130, 178);
            this.lblAllTasks.Name = "lblAllTasks";
            this.lblAllTasks.Size = new System.Drawing.Size(24, 25);
            this.lblAllTasks.TabIndex = 20;
            this.lblAllTasks.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(6, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "All Tasks : ";
            // 
            // PgbAllTasks
            // 
            this.PgbAllTasks.Location = new System.Drawing.Point(448, 98);
            this.PgbAllTasks.Name = "PgbAllTasks";
            this.PgbAllTasks.Size = new System.Drawing.Size(199, 52);
            this.PgbAllTasks.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(452, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tasks Progress";
            // 
            // LvAllTasks
            // 
            this.LvAllTasks.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvAllTasks.CheckBoxes = true;
            this.LvAllTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LvAllTasks.ContextMenuStrip = this.Cms2;
            this.LvAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LvAllTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LvAllTasks.FullRowSelect = true;
            listViewGroup1.Header = "Family";
            listViewGroup1.Name = "LvgFamily";
            listViewGroup2.Header = "Work";
            listViewGroup2.Name = "LvgWork";
            listViewGroup3.Header = "Fun";
            listViewGroup3.Name = "LvgFun ";
            listViewGroup4.Header = "Study";
            listViewGroup4.Name = "LvgStudy";
            this.LvAllTasks.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.LvAllTasks.HideSelection = false;
            this.LvAllTasks.Location = new System.Drawing.Point(6, 206);
            this.LvAllTasks.MultiSelect = false;
            this.LvAllTasks.Name = "LvAllTasks";
            this.LvAllTasks.Size = new System.Drawing.Size(649, 443);
            this.LvAllTasks.SmallImageList = this.PriorityImgList;
            this.LvAllTasks.TabIndex = 9;
            this.LvAllTasks.UseCompatibleStateImageBehavior = false;
            this.LvAllTasks.View = System.Windows.Forms.View.Details;
            this.LvAllTasks.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LvAllTasks_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 320;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Priority";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 230;
            // 
            // Cms2
            // 
            this.Cms2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkUncheckToolStripMenuItem,
            this.removeToolStripMenuItem1,
            this.sortToolStripMenuItem});
            this.Cms2.Name = "Cms2";
            this.Cms2.Size = new System.Drawing.Size(159, 70);
            // 
            // checkUncheckToolStripMenuItem
            // 
            this.checkUncheckToolStripMenuItem.Name = "checkUncheckToolStripMenuItem";
            this.checkUncheckToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.checkUncheckToolStripMenuItem.Text = "Check/Uncheck";
            this.checkUncheckToolStripMenuItem.Click += new System.EventHandler(this.checkUncheckToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeAllToolStripMenuItem,
            this.removeSelectedToolStripMenuItem1});
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeAllToolStripMenuItem.Text = "Remove All";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.removeAllToolStripMenuItem_Click);
            // 
            // removeSelectedToolStripMenuItem1
            // 
            this.removeSelectedToolStripMenuItem1.Name = "removeSelectedToolStripMenuItem1";
            this.removeSelectedToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.removeSelectedToolStripMenuItem1.Text = "Remove Selected";
            this.removeSelectedToolStripMenuItem1.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem1_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byPriorityToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sortToolStripMenuItem.Text = "Sort ";
            // 
            // byPriorityToolStripMenuItem
            // 
            this.byPriorityToolStripMenuItem.Name = "byPriorityToolStripMenuItem";
            this.byPriorityToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.byPriorityToolStripMenuItem.Text = "By Priority";
            this.byPriorityToolStripMenuItem.Click += new System.EventHandler(this.byPriorityToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteTasksLvAllTasks);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Teal;
            this.groupBox4.Location = new System.Drawing.Point(726, 598);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 91);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Selected Task";
            // 
            // btnDeleteTasksLvAllTasks
            // 
            this.btnDeleteTasksLvAllTasks.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteTasksLvAllTasks.Location = new System.Drawing.Point(6, 29);
            this.btnDeleteTasksLvAllTasks.Name = "btnDeleteTasksLvAllTasks";
            this.btnDeleteTasksLvAllTasks.Size = new System.Drawing.Size(239, 62);
            this.btnDeleteTasksLvAllTasks.TabIndex = 2;
            this.btnDeleteTasksLvAllTasks.Text = "Delete";
            this.btnDeleteTasksLvAllTasks.UseVisualStyleBackColor = true;
            this.btnDeleteTasksLvAllTasks.Click += new System.EventHandler(this.btnDeleteTasksLvAllTasks_Click);
            // 
            // GbCreateNewTaskLvAllTasks
            // 
            this.GbCreateNewTaskLvAllTasks.Controls.Add(this.label8);
            this.GbCreateNewTaskLvAllTasks.Controls.Add(this.CbPriority);
            this.GbCreateNewTaskLvAllTasks.Controls.Add(this.label7);
            this.GbCreateNewTaskLvAllTasks.Controls.Add(this.BtnAddTaskLvAllTasks);
            this.GbCreateNewTaskLvAllTasks.Controls.Add(this.CbCategory);
            this.GbCreateNewTaskLvAllTasks.Controls.Add(this.TxtTitleLvAllTasks);
            this.GbCreateNewTaskLvAllTasks.Controls.Add(this.label6);
            this.GbCreateNewTaskLvAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCreateNewTaskLvAllTasks.ForeColor = System.Drawing.Color.Teal;
            this.GbCreateNewTaskLvAllTasks.Location = new System.Drawing.Point(734, 224);
            this.GbCreateNewTaskLvAllTasks.Name = "GbCreateNewTaskLvAllTasks";
            this.GbCreateNewTaskLvAllTasks.Size = new System.Drawing.Size(250, 368);
            this.GbCreateNewTaskLvAllTasks.TabIndex = 7;
            this.GbCreateNewTaskLvAllTasks.TabStop = false;
            this.GbCreateNewTaskLvAllTasks.Text = "Create New Task";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(2, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Priority";
            // 
            // CbPriority
            // 
            this.CbPriority.FormattingEnabled = true;
            this.CbPriority.Items.AddRange(new object[] {
            "Urgent",
            "Important",
            "Normal"});
            this.CbPriority.Location = new System.Drawing.Point(6, 244);
            this.CbPriority.Name = "CbPriority";
            this.CbPriority.Size = new System.Drawing.Size(214, 32);
            this.CbPriority.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Category";
            // 
            // BtnAddTaskLvAllTasks
            // 
            this.BtnAddTaskLvAllTasks.Location = new System.Drawing.Point(3, 302);
            this.BtnAddTaskLvAllTasks.Name = "BtnAddTaskLvAllTasks";
            this.BtnAddTaskLvAllTasks.Size = new System.Drawing.Size(236, 62);
            this.BtnAddTaskLvAllTasks.TabIndex = 1;
            this.BtnAddTaskLvAllTasks.Text = "Add Task";
            this.BtnAddTaskLvAllTasks.UseVisualStyleBackColor = true;
            this.BtnAddTaskLvAllTasks.Click += new System.EventHandler(this.BtnAddTaskLvAllTasks_Click);
            // 
            // CbCategory
            // 
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Items.AddRange(new object[] {
            ""});
            this.CbCategory.Location = new System.Drawing.Point(10, 155);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(214, 32);
            this.CbCategory.TabIndex = 2;
            // 
            // TxtTitleLvAllTasks
            // 
            this.TxtTitleLvAllTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTitleLvAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitleLvAllTasks.Location = new System.Drawing.Point(10, 76);
            this.TxtTitleLvAllTasks.Name = "TxtTitleLvAllTasks";
            this.TxtTitleLvAllTasks.Size = new System.Drawing.Size(229, 22);
            this.TxtTitleLvAllTasks.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Title";
            // 
            // GbCreatNewCategory
            // 
            this.GbCreatNewCategory.Controls.Add(this.BtnAddCategory);
            this.GbCreatNewCategory.Controls.Add(this.TxtCategoryTitle);
            this.GbCreatNewCategory.Controls.Add(this.label4);
            this.GbCreatNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCreatNewCategory.ForeColor = System.Drawing.Color.Teal;
            this.GbCreatNewCategory.Location = new System.Drawing.Point(6, 47);
            this.GbCreatNewCategory.Name = "GbCreatNewCategory";
            this.GbCreatNewCategory.Size = new System.Drawing.Size(379, 119);
            this.GbCreatNewCategory.TabIndex = 6;
            this.GbCreatNewCategory.TabStop = false;
            this.GbCreatNewCategory.Text = "Create New Category";
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.Location = new System.Drawing.Point(202, 51);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(169, 62);
            this.BtnAddCategory.TabIndex = 1;
            this.BtnAddCategory.Text = "Add Category";
            this.BtnAddCategory.UseVisualStyleBackColor = true;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // TxtCategoryTitle
            // 
            this.TxtCategoryTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCategoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoryTitle.Location = new System.Drawing.Point(10, 76);
            this.TxtCategoryTitle.Name = "TxtCategoryTitle";
            this.TxtCategoryTitle.Size = new System.Drawing.Size(186, 22);
            this.TxtCategoryTitle.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Title";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.McTaskDate);
            this.groupBox1.Location = new System.Drawing.Point(653, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Date";
            // 
            // McTaskDate
            // 
            this.McTaskDate.Location = new System.Drawing.Point(14, 13);
            this.McTaskDate.Name = "McTaskDate";
            this.McTaskDate.TabIndex = 0;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksToolStripMenuItem1,
            this.goToolStripMenuItem1});
            this.menuStrip3.Location = new System.Drawing.Point(3, 3);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(988, 24);
            this.menuStrip3.TabIndex = 22;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // tasksToolStripMenuItem1
            // 
            this.tasksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1});
            this.tasksToolStripMenuItem1.Name = "tasksToolStripMenuItem1";
            this.tasksToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.tasksToolStripMenuItem1.Text = "Tasks";
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // goToolStripMenuItem1
            // 
            this.goToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.taskDoneToolStripMenuItem});
            this.goToolStripMenuItem1.Name = "goToolStripMenuItem1";
            this.goToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Z)));
            this.goToolStripMenuItem1.Size = new System.Drawing.Size(34, 20);
            this.goToolStripMenuItem1.Text = "Go";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Z)));
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // taskDoneToolStripMenuItem
            // 
            this.taskDoneToolStripMenuItem.Name = "taskDoneToolStripMenuItem";
            this.taskDoneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.taskDoneToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.taskDoneToolStripMenuItem.Text = "TaskDone";
            this.taskDoneToolStripMenuItem.Click += new System.EventHandler(this.taskDoneToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnSignOut);
            this.tabPage1.Controls.Add(this.PgbTodayTasks);
            this.tabPage1.Controls.Add(this.lblTodaysTaskPgb);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblTasksCount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lvTodayTask);
            this.tabPage1.Controls.Add(this.GbTodayTask);
            this.tabPage1.Controls.Add(this.GbDeleteTask);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.menuStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 744);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnSignOut
            // 
            this.BtnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.BtnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignOut.ForeColor = System.Drawing.Color.Black;
            this.BtnSignOut.Location = new System.Drawing.Point(725, 587);
            this.BtnSignOut.Name = "BtnSignOut";
            this.BtnSignOut.Size = new System.Drawing.Size(237, 56);
            this.BtnSignOut.TabIndex = 13;
            this.BtnSignOut.Text = "Sign Out";
            this.BtnSignOut.UseVisualStyleBackColor = false;
            this.BtnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // PgbTodayTasks
            // 
            this.PgbTodayTasks.Location = new System.Drawing.Point(244, 597);
            this.PgbTodayTasks.Name = "PgbTodayTasks";
            this.PgbTodayTasks.Size = new System.Drawing.Size(221, 49);
            this.PgbTodayTasks.TabIndex = 11;
            // 
            // lblTodaysTaskPgb
            // 
            this.lblTodaysTaskPgb.AutoSize = true;
            this.lblTodaysTaskPgb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysTaskPgb.ForeColor = System.Drawing.Color.Teal;
            this.lblTodaysTaskPgb.Location = new System.Drawing.Point(186, 607);
            this.lblTodaysTaskPgb.Name = "lblTodaysTaskPgb";
            this.lblTodaysTaskPgb.Size = new System.Drawing.Size(32, 20);
            this.lblTodaysTaskPgb.TabIndex = 10;
            this.lblTodaysTaskPgb.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(35, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Today\'s Tasks : ";
            // 
            // lblTasksCount
            // 
            this.lblTasksCount.AutoSize = true;
            this.lblTasksCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasksCount.ForeColor = System.Drawing.Color.Teal;
            this.lblTasksCount.Location = new System.Drawing.Point(164, 152);
            this.lblTasksCount.Name = "lblTasksCount";
            this.lblTasksCount.Size = new System.Drawing.Size(16, 18);
            this.lblTasksCount.TabIndex = 8;
            this.lblTasksCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(20, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Today\'s Tasks : ";
            // 
            // lvTodayTask
            // 
            this.lvTodayTask.CheckBoxes = true;
            this.lvTodayTask.ContextMenuStrip = this.Cms1;
            this.lvTodayTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lvTodayTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lvTodayTask.FullRowSelect = true;
            this.lvTodayTask.HideSelection = false;
            this.lvTodayTask.Location = new System.Drawing.Point(21, 175);
            this.lvTodayTask.Name = "lvTodayTask";
            this.lvTodayTask.Size = new System.Drawing.Size(690, 397);
            this.lvTodayTask.TabIndex = 6;
            this.lvTodayTask.UseCompatibleStateImageBehavior = false;
            this.lvTodayTask.View = System.Windows.Forms.View.List;
            this.lvTodayTask.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvTodayTask_ItemChecked);
            // 
            // GbTodayTask
            // 
            this.GbTodayTask.Controls.Add(this.BtnAddTodayTask);
            this.GbTodayTask.Controls.Add(this.TxtTodayTasksTitle);
            this.GbTodayTask.Controls.Add(this.lblTitle);
            this.GbTodayTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbTodayTask.ForeColor = System.Drawing.Color.Teal;
            this.GbTodayTask.Location = new System.Drawing.Point(717, 175);
            this.GbTodayTask.Name = "GbTodayTask";
            this.GbTodayTask.Size = new System.Drawing.Size(245, 224);
            this.GbTodayTask.TabIndex = 5;
            this.GbTodayTask.TabStop = false;
            this.GbTodayTask.Text = "Create New Task";
            // 
            // BtnAddTodayTask
            // 
            this.BtnAddTodayTask.Location = new System.Drawing.Point(6, 130);
            this.BtnAddTodayTask.Name = "BtnAddTodayTask";
            this.BtnAddTodayTask.Size = new System.Drawing.Size(229, 62);
            this.BtnAddTodayTask.TabIndex = 1;
            this.BtnAddTodayTask.Text = "Add Task";
            this.BtnAddTodayTask.UseVisualStyleBackColor = true;
            this.BtnAddTodayTask.Click += new System.EventHandler(this.BtnAddTodayTask_Click);
            // 
            // TxtTodayTasksTitle
            // 
            this.TxtTodayTasksTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTodayTasksTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTodayTasksTitle.Location = new System.Drawing.Point(10, 76);
            this.TxtTodayTasksTitle.Name = "TxtTodayTasksTitle";
            this.TxtTodayTasksTitle.Size = new System.Drawing.Size(229, 22);
            this.TxtTodayTasksTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(6, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // GbDeleteTask
            // 
            this.GbDeleteTask.Controls.Add(this.BtnDeleteTodayTask);
            this.GbDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDeleteTask.ForeColor = System.Drawing.Color.Teal;
            this.GbDeleteTask.Location = new System.Drawing.Point(717, 425);
            this.GbDeleteTask.Name = "GbDeleteTask";
            this.GbDeleteTask.Size = new System.Drawing.Size(245, 115);
            this.GbDeleteTask.TabIndex = 4;
            this.GbDeleteTask.TabStop = false;
            this.GbDeleteTask.Text = "Delete Selected Task";
            // 
            // BtnDeleteTodayTask
            // 
            this.BtnDeleteTodayTask.ForeColor = System.Drawing.Color.Red;
            this.BtnDeleteTodayTask.Location = new System.Drawing.Point(6, 39);
            this.BtnDeleteTodayTask.Name = "BtnDeleteTodayTask";
            this.BtnDeleteTodayTask.Size = new System.Drawing.Size(229, 62);
            this.BtnDeleteTodayTask.TabIndex = 2;
            this.BtnDeleteTodayTask.Text = "Delete";
            this.BtnDeleteTodayTask.UseVisualStyleBackColor = true;
            this.BtnDeleteTodayTask.Click += new System.EventHandler(this.BtnDeleteTodayTask_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblDateNow);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Location = new System.Drawing.Point(4, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 83);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(115, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome back again";
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNow.ForeColor = System.Drawing.Color.Teal;
            this.lblDateNow.Location = new System.Drawing.Point(840, 36);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(47, 20);
            this.lblDateNow.TabIndex = 3;
            this.lblDateNow.Text = "label";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(116, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hi";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(105)))));
            this.lblAdmin.Location = new System.Drawing.Point(141, 16);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(60, 24);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "label1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksToolStripMenuItem,
            this.goToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(988, 24);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.tasksToolStripMenuItem.Text = "Tasks";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allTasksToolStripMenuItem,
            this.doneTasksToolStripMenuItem});
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Z)));
            this.goToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.goToolStripMenuItem.Text = "Go";
            // 
            // allTasksToolStripMenuItem
            // 
            this.allTasksToolStripMenuItem.Name = "allTasksToolStripMenuItem";
            this.allTasksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Z)));
            this.allTasksToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.allTasksToolStripMenuItem.Text = "All Tasks";
            this.allTasksToolStripMenuItem.Click += new System.EventHandler(this.allTasksToolStripMenuItem_Click);
            // 
            // doneTasksToolStripMenuItem
            // 
            this.doneTasksToolStripMenuItem.Name = "doneTasksToolStripMenuItem";
            this.doneTasksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.doneTasksToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.doneTasksToolStripMenuItem.Text = "TaskDone";
            this.doneTasksToolStripMenuItem.Click += new System.EventHandler(this.doneTasksToolStripMenuItem_Click);
            // 
            // Tc1
            // 
            this.Tc1.Controls.Add(this.tabPage1);
            this.Tc1.Controls.Add(this.tabPage2);
            this.Tc1.Controls.Add(this.tabPage3);
            this.Tc1.Location = new System.Drawing.Point(12, 3);
            this.Tc1.Name = "Tc1";
            this.Tc1.SelectedIndex = 0;
            this.Tc1.Size = new System.Drawing.Size(1002, 770);
            this.Tc1.TabIndex = 0;
            this.Tc1.SelectedIndexChanged += new System.EventHandler(this.Tc1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 717);
            this.Controls.Add(this.Tc1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home_Form";
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Home_Form_Load);
            this.Cms1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Cms2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.GbCreateNewTaskLvAllTasks.ResumeLayout(false);
            this.GbCreateNewTaskLvAllTasks.PerformLayout();
            this.GbCreatNewCategory.ResumeLayout(false);
            this.GbCreatNewCategory.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GbTodayTask.ResumeLayout(false);
            this.GbTodayTask.PerformLayout();
            this.GbDeleteTask.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.Tc1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip Cms1;
        private System.Windows.Forms.ImageList PriorityImgList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView LvDoneTasks;
        private System.Windows.Forms.Label lblTasksDoned;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblAllTasksProgress;
        private System.Windows.Forms.Label lblAllTasks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar PgbAllTasks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView LvAllTasks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteTasksLvAllTasks;
        private System.Windows.Forms.GroupBox GbCreateNewTaskLvAllTasks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbPriority;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAddTaskLvAllTasks;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.TextBox TxtTitleLvAllTasks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GbCreatNewCategory;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.TextBox TxtCategoryTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar McTaskDate;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskDoneToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ProgressBar PgbTodayTasks;
        private System.Windows.Forms.Label lblTodaysTaskPgb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTasksCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvTodayTask;
        private System.Windows.Forms.GroupBox GbTodayTask;
        private System.Windows.Forms.Button BtnAddTodayTask;
        private System.Windows.Forms.TextBox TxtTodayTasksTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox GbDeleteTask;
        private System.Windows.Forms.Button BtnDeleteTodayTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDateNow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doneTasksToolStripMenuItem;
        private System.Windows.Forms.TabControl Tc1;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip Cms2;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkUncheckToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkUncheckToolStripMenuItem;
        private System.Windows.Forms.Button BtnSignOut;
    }
}