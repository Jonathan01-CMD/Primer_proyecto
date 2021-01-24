
namespace Proyecto_Registro1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.DataGridView();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.txt_Roll = new System.Windows.Forms.TextBox();
            this.lb_roll = new System.Windows.Forms.Label();
            this.IdNumeroUpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_fecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumeroUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(9, 141);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(93, 46);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Image = ((System.Drawing.Image)(resources.GetObject("btn_listar.Image")));
            this.btn_listar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_listar.Location = new System.Drawing.Point(108, 141);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(82, 46);
            this.btn_listar.TabIndex = 1;
            this.btn_listar.Text = "Listar";
            this.btn_listar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.button2_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ErrorProvider.Location = new System.Drawing.Point(0, 193);
            this.ErrorProvider.Name = "ErrorProvider";
            this.ErrorProvider.RowTemplate.Height = 25;
            this.ErrorProvider.Size = new System.Drawing.Size(404, 155);
            this.ErrorProvider.TabIndex = 2;
            this.ErrorProvider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(5, 67);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(69, 15);
            this.lb_nombre.TabIndex = 3;
            this.lb_nombre.Text = "Dijite el Roll";
            this.lb_nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Roll
            // 
            this.txt_Roll.Location = new System.Drawing.Point(80, 64);
            this.txt_Roll.Name = "txt_Roll";
            this.txt_Roll.Size = new System.Drawing.Size(120, 23);
            this.txt_Roll.TabIndex = 4;
            this.txt_Roll.TextChanged += new System.EventHandler(this.txt_Roll_TextChanged);
            // 
            // lb_roll
            // 
            this.lb_roll.AutoSize = true;
            this.lb_roll.Location = new System.Drawing.Point(9, 22);
            this.lb_roll.Name = "lb_roll";
            this.lb_roll.Size = new System.Drawing.Size(90, 15);
            this.lb_roll.TabIndex = 5;
            this.lb_roll.Text = "Dijite ID del Roll";
            this.lb_roll.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // IdNumeroUpDown
            // 
            this.IdNumeroUpDown.Location = new System.Drawing.Point(105, 20);
            this.IdNumeroUpDown.Name = "IdNumeroUpDown";
            this.IdNumeroUpDown.Size = new System.Drawing.Size(48, 23);
            this.IdNumeroUpDown.TabIndex = 6;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.Image")));
            this.btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpiar.Location = new System.Drawing.Point(205, 141);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(91, 46);
            this.btn_Limpiar.TabIndex = 7;
            this.btn_Limpiar.Text = "Nuevo";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(159, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(41, 46);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Location = new System.Drawing.Point(36, 116);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(38, 15);
            this.lb_fecha.TabIndex = 9;
            this.lb_fecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "  ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 23);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(302, 141);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(91, 46);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 350);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_fecha);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.IdNumeroUpDown);
            this.Controls.Add(this.lb_roll);
            this.Controls.Add(this.txt_Roll);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.ErrorProvider);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_guardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumeroUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.DataGridView ErrorProvider;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.TextBox txt_Roll;
        private System.Windows.Forms.Label lb_roll;
        private System.Windows.Forms.NumericUpDown IdNumeroUpDown;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Button btn_eliminar;
    }
}

