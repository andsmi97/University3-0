namespace WindowsFormsApp1
{
    partial class ProblemList
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uni3DataSet = new WindowsFormsApp1.Uni3DataSet();
            this.проблемаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.проблемаTableAdapter = new WindowsFormsApp1.Uni3DataSetTableAdapters.ПроблемаTableAdapter();
            this.проблемаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проблемаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проблемаBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 250);
            this.dataGridView1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // uni3DataSet
            // 
            this.uni3DataSet.DataSetName = "Uni3DataSet";
            this.uni3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // проблемаBindingSource
            // 
            this.проблемаBindingSource.DataMember = "Проблема";
            this.проблемаBindingSource.DataSource = this.uni3DataSet;
            // 
            // проблемаTableAdapter
            // 
            this.проблемаTableAdapter.ClearBeforeFill = true;
            // 
            // проблемаBindingSource1
            // 
            this.проблемаBindingSource1.DataMember = "Проблема";
            this.проблемаBindingSource1.DataSource = this.uni3DataSet;
            // 
            // ProblemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ProblemList";
            this.Size = new System.Drawing.Size(525, 412);
            this.Load += new System.EventHandler(this.ProblemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проблемаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проблемаBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Uni3DataSet uni3DataSet;
        private System.Windows.Forms.BindingSource проблемаBindingSource;
        private Uni3DataSetTableAdapters.ПроблемаTableAdapter проблемаTableAdapter;
        private System.Windows.Forms.BindingSource проблемаBindingSource1;
    }
}
