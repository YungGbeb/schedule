
namespace Diplom
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.disciplines = new System.Windows.Forms.ComboBox();
            this.disciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demo2DataSet = new Diplom.demo2DataSet();
            this.discnkafBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raspisanieDataSet = new Diplom.RaspisanieDataSet();
            this.disciplinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachers = new System.Windows.Forms.ComboBox();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raspisanieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditoria = new System.Windows.Forms.ComboBox();
            this.auditoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinesTableAdapter = new Diplom.RaspisanieDataSetTableAdapters.disciplinesTableAdapter();
            this.teachersTableAdapter = new Diplom.RaspisanieDataSetTableAdapters.teachersTableAdapter();
            this.auditoriesTableAdapter = new Diplom.RaspisanieDataSetTableAdapters.auditoriesTableAdapter();
            this.export = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.lessonType = new System.Windows.Forms.ComboBox();
            this.import = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.addColumn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.kafFilter = new System.Windows.Forms.ComboBox();
            this.kafsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kafsTableAdapter = new Diplom.RaspisanieDataSetTableAdapters.kafsTableAdapter();
            this.discnkafTableAdapter = new Diplom.RaspisanieDataSetTableAdapters.DiscnkafTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_prep_filter = new System.Windows.Forms.TextBox();
            this.tb_disc_filter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.group_name_cb = new System.Windows.Forms.ComboBox();
            this.gruppaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gruppaTableAdapter = new Diplom.demo2DataSetTableAdapters.gruppaTableAdapter();
            this.disciplinaTableAdapter = new Diplom.demo2DataSetTableAdapters.disciplinaTableAdapter();
            this.sotrudnikTableAdapter = new Diplom.demo2DataSetTableAdapters.sotrudnikTableAdapter();
            this.sotrudnikfioviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnik_fio_viewTableAdapter = new Diplom.demo2DataSetTableAdapters.sotrudnik_fio_viewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discnkafBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikfioviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 824);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // disciplines
            // 
            this.disciplines.DataSource = this.disciplinaBindingSource;
            this.disciplines.DisplayMember = "disciplina_ru";
            this.disciplines.FormattingEnabled = true;
            this.disciplines.Location = new System.Drawing.Point(107, 19);
            this.disciplines.Name = "disciplines";
            this.disciplines.Size = new System.Drawing.Size(252, 21);
            this.disciplines.TabIndex = 0;
            this.disciplines.ValueMember = "disciplina_id";
            this.disciplines.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // disciplinaBindingSource
            // 
            this.disciplinaBindingSource.DataMember = "disciplina";
            this.disciplinaBindingSource.DataSource = this.demo2DataSet;
            // 
            // demo2DataSet
            // 
            this.demo2DataSet.DataSetName = "demo2DataSet";
            this.demo2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discnkafBindingSource
            // 
            this.discnkafBindingSource.DataMember = "Discnkaf";
            this.discnkafBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // raspisanieDataSet
            // 
            this.raspisanieDataSet.DataSetName = "RaspisanieDataSet";
            this.raspisanieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disciplinesBindingSource
            // 
            this.disciplinesBindingSource.DataMember = "disciplines";
            this.disciplinesBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // teachers
            // 
            this.teachers.DataSource = this.teachersBindingSource;
            this.teachers.DisplayMember = "FIO";
            this.teachers.FormattingEnabled = true;
            this.teachers.Location = new System.Drawing.Point(107, 46);
            this.teachers.Name = "teachers";
            this.teachers.Size = new System.Drawing.Size(252, 21);
            this.teachers.TabIndex = 2;
            this.teachers.ValueMember = "degree";
            this.teachers.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.demo2DataSet;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.raspisanieDataSetBindingSource;
            // 
            // raspisanieDataSetBindingSource
            // 
            this.raspisanieDataSetBindingSource.DataSource = this.raspisanieDataSet;
            this.raspisanieDataSetBindingSource.Position = 0;
            this.raspisanieDataSetBindingSource.CurrentChanged += new System.EventHandler(this.raspisanieDataSetBindingSource_CurrentChanged);
            // 
            // auditoria
            // 
            this.auditoria.DataSource = this.auditoriesBindingSource;
            this.auditoria.DisplayMember = "number";
            this.auditoria.FormattingEnabled = true;
            this.auditoria.Location = new System.Drawing.Point(107, 73);
            this.auditoria.Name = "auditoria";
            this.auditoria.Size = new System.Drawing.Size(75, 21);
            this.auditoria.TabIndex = 3;
            this.auditoria.ValueMember = "aud_id";
            this.auditoria.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // auditoriesBindingSource
            // 
            this.auditoriesBindingSource.DataMember = "auditories";
            this.auditoriesBindingSource.DataSource = this.raspisanieDataSetBindingSource;
            // 
            // disciplinesTableAdapter
            // 
            this.disciplinesTableAdapter.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // auditoriesTableAdapter
            // 
            this.auditoriesTableAdapter.ClearBeforeFill = true;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(8, 19);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 5;
            this.export.Text = "Экспорт";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1216, 711);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 24);
            this.exit.TabIndex = 6;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lessonType
            // 
            this.lessonType.FormattingEnabled = true;
            this.lessonType.Items.AddRange(new object[] {
            "лек.",
            "Пр.",
            "СРСП."});
            this.lessonType.Location = new System.Drawing.Point(107, 100);
            this.lessonType.Name = "lessonType";
            this.lessonType.Size = new System.Drawing.Size(121, 21);
            this.lessonType.TabIndex = 7;
            this.lessonType.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(8, 48);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 8;
            this.import.Text = "Импорт";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.button3_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(89, 19);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(139, 23);
            this.test.TabIndex = 10;
            this.test.Text = "Проверить накладки";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.button4_Click);
            // 
            // table
            // 
            this.table.FormattingEnabled = true;
            this.table.Location = new System.Drawing.Point(8, 77);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(121, 21);
            this.table.TabIndex = 12;
            this.table.Text = "Выбрать таблицу";
            this.table.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1020, 814);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(23, 10);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.Visible = false;
            // 
            // addColumn
            // 
            this.addColumn.Location = new System.Drawing.Point(6, 45);
            this.addColumn.Name = "addColumn";
            this.addColumn.Size = new System.Drawing.Size(118, 23);
            this.addColumn.TabIndex = 18;
            this.addColumn.Text = "Добавить столбец";
            this.addColumn.UseVisualStyleBackColor = true;
            this.addColumn.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 75);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 23);
            this.button9.TabIndex = 20;
            this.button9.Text = "Сбросить столбцы";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // kafFilter
            // 
            this.kafFilter.DataSource = this.kafsBindingSource;
            this.kafFilter.DisplayMember = "kaf";
            this.kafFilter.FormattingEnabled = true;
            this.kafFilter.Location = new System.Drawing.Point(107, 127);
            this.kafFilter.Name = "kafFilter";
            this.kafFilter.Size = new System.Drawing.Size(121, 21);
            this.kafFilter.TabIndex = 22;
            this.kafFilter.ValueMember = "kaf";
            this.kafFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // kafsBindingSource
            // 
            this.kafsBindingSource.DataMember = "kafs";
            this.kafsBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // kafsTableAdapter
            // 
            this.kafsTableAdapter.ClearBeforeFill = true;
            // 
            // discnkafTableAdapter
            // 
            this.discnkafTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Дисциплина:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Преподаватель:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Аудитория:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Тип занятия:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Кафедра:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_prep_filter);
            this.groupBox1.Controls.Add(this.tb_disc_filter);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.kafFilter);
            this.groupBox1.Controls.Add(this.lessonType);
            this.groupBox1.Controls.Add(this.auditoria);
            this.groupBox1.Controls.Add(this.teachers);
            this.groupBox1.Controls.Add(this.disciplines);
            this.groupBox1.Location = new System.Drawing.Point(1057, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 337);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 26);
            this.label10.TabIndex = 26;
            this.label10.Text = "Поиск по \r\nпреподавателю";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "Поиск по \r\nдисциплине";
            // 
            // tb_prep_filter
            // 
            this.tb_prep_filter.Location = new System.Drawing.Point(107, 181);
            this.tb_prep_filter.Name = "tb_prep_filter";
            this.tb_prep_filter.Size = new System.Drawing.Size(252, 20);
            this.tb_prep_filter.TabIndex = 25;
            this.tb_prep_filter.TextChanged += new System.EventHandler(this.tb_prep_filter_TextChanged);
            // 
            // tb_disc_filter
            // 
            this.tb_disc_filter.Location = new System.Drawing.Point(107, 155);
            this.tb_disc_filter.Name = "tb_disc_filter";
            this.tb_disc_filter.Size = new System.Drawing.Size(252, 20);
            this.tb_disc_filter.TabIndex = 25;
            this.tb_disc_filter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.export);
            this.groupBox2.Controls.Add(this.import);
            this.groupBox2.Controls.Add(this.table);
            this.groupBox2.Controls.Add(this.test);
            this.groupBox2.Location = new System.Drawing.Point(1057, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 105);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.group_name_cb);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.addColumn);
            this.groupBox3.Location = new System.Drawing.Point(1057, 466);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 106);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // group_name_cb
            // 
            this.group_name_cb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gruppaBindingSource, "gruppa_ru", true));
            this.group_name_cb.DataSource = this.gruppaBindingSource;
            this.group_name_cb.DisplayMember = "gruppa_ru";
            this.group_name_cb.FormattingEnabled = true;
            this.group_name_cb.Location = new System.Drawing.Point(8, 20);
            this.group_name_cb.Name = "group_name_cb";
            this.group_name_cb.Size = new System.Drawing.Size(121, 21);
            this.group_name_cb.TabIndex = 21;
            this.group_name_cb.ValueMember = "gruppa_id";
            // 
            // gruppaBindingSource
            // 
            this.gruppaBindingSource.DataMember = "gruppa";
            this.gruppaBindingSource.DataSource = this.demo2DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(886, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(886, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(886, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1057, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // gruppaTableAdapter
            // 
            this.gruppaTableAdapter.ClearBeforeFill = true;
            // 
            // disciplinaTableAdapter
            // 
            this.disciplinaTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikfioviewBindingSource
            // 
            this.sotrudnikfioviewBindingSource.DataMember = "sotrudnik_fio_view";
            this.sotrudnikfioviewBindingSource.DataSource = this.demo2DataSet;
            // 
            // sotrudnik_fio_viewTableAdapter
            // 
            this.sotrudnik_fio_viewTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 824);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мастер составления расписания v.0.9";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discnkafBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikfioviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox disciplines;
        private System.Windows.Forms.ComboBox teachers;
        private System.Windows.Forms.ComboBox auditoria;
        private System.Windows.Forms.BindingSource raspisanieDataSetBindingSource;
        private RaspisanieDataSet raspisanieDataSet;
        private System.Windows.Forms.BindingSource disciplinesBindingSource;
        private RaspisanieDataSetTableAdapters.disciplinesTableAdapter disciplinesTableAdapter;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private RaspisanieDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource auditoriesBindingSource;
        private RaspisanieDataSetTableAdapters.auditoriesTableAdapter auditoriesTableAdapter;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox lessonType;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.ComboBox table;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button addColumn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox kafFilter;
        private System.Windows.Forms.BindingSource kafsBindingSource;
        private RaspisanieDataSetTableAdapters.kafsTableAdapter kafsTableAdapter;
        private System.Windows.Forms.BindingSource discnkafBindingSource;
        private RaspisanieDataSetTableAdapters.DiscnkafTableAdapter discnkafTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox group_name_cb;
        private demo2DataSet demo2DataSet;
        private System.Windows.Forms.BindingSource gruppaBindingSource;
        private demo2DataSetTableAdapters.gruppaTableAdapter gruppaTableAdapter;
        private System.Windows.Forms.BindingSource disciplinaBindingSource;
        private demo2DataSetTableAdapters.disciplinaTableAdapter disciplinaTableAdapter;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private demo2DataSetTableAdapters.sotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_prep_filter;
        private System.Windows.Forms.TextBox tb_disc_filter;
        private System.Windows.Forms.BindingSource sotrudnikfioviewBindingSource;
        private demo2DataSetTableAdapters.sotrudnik_fio_viewTableAdapter sotrudnik_fio_viewTableAdapter;
    }
}

