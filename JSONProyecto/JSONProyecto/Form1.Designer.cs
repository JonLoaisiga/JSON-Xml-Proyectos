namespace JSONProyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxAñadir = new System.Windows.Forms.PictureBox();
            this.pictureBoxEliminar = new System.Windows.Forms.PictureBox();
            this.pictureBoxEditar = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAñadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAñadir
            // 
            this.pictureBoxAñadir.BackColor = System.Drawing.Color.White;
            this.pictureBoxAñadir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAñadir.Image")));
            this.pictureBoxAñadir.Location = new System.Drawing.Point(748, 49);
            this.pictureBoxAñadir.Name = "pictureBoxAñadir";
            this.pictureBoxAñadir.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxAñadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAñadir.TabIndex = 0;
            this.pictureBoxAñadir.TabStop = false;
            this.pictureBoxAñadir.Click += new System.EventHandler(this.pictureBoxAñadir_Click);
            // 
            // pictureBoxEliminar
            // 
            this.pictureBoxEliminar.BackColor = System.Drawing.Color.White;
            this.pictureBoxEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEliminar.Image")));
            this.pictureBoxEliminar.Location = new System.Drawing.Point(748, 155);
            this.pictureBoxEliminar.Name = "pictureBoxEliminar";
            this.pictureBoxEliminar.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEliminar.TabIndex = 1;
            this.pictureBoxEliminar.TabStop = false;
            this.pictureBoxEliminar.Click += new System.EventHandler(this.pictureBoxEliminar_Click);
            // 
            // pictureBoxEditar
            // 
            this.pictureBoxEditar.BackColor = System.Drawing.Color.White;
            this.pictureBoxEditar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEditar.Image")));
            this.pictureBoxEditar.Location = new System.Drawing.Point(748, 261);
            this.pictureBoxEditar.Name = "pictureBoxEditar";
            this.pictureBoxEditar.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEditar.TabIndex = 2;
            this.pictureBoxEditar.TabStop = false;
            this.pictureBoxEditar.Click += new System.EventHandler(this.pictureBoxEditar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaID,
            this.ColumnaNombre,
            this.ColumnaApellido1,
            this.ColumnaApellido2,
            this.ColumnaEdad,
            this.ColumnaEmail});
            this.dataGridView1.Location = new System.Drawing.Point(37, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 282);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnaID
            // 
            this.ColumnaID.HeaderText = "ID";
            this.ColumnaID.Name = "ColumnaID";
            this.ColumnaID.ReadOnly = true;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            // 
            // ColumnaApellido1
            // 
            this.ColumnaApellido1.HeaderText = "Primer Apellido";
            this.ColumnaApellido1.Name = "ColumnaApellido1";
            this.ColumnaApellido1.ReadOnly = true;
            // 
            // ColumnaApellido2
            // 
            this.ColumnaApellido2.HeaderText = "Segundo Apellido";
            this.ColumnaApellido2.Name = "ColumnaApellido2";
            this.ColumnaApellido2.ReadOnly = true;
            // 
            // ColumnaEdad
            // 
            this.ColumnaEdad.HeaderText = "Edad";
            this.ColumnaEdad.Name = "ColumnaEdad";
            this.ColumnaEdad.ReadOnly = true;
            // 
            // ColumnaEmail
            // 
            this.ColumnaEmail.HeaderText = "E-mail";
            this.ColumnaEmail.Name = "ColumnaEmail";
            this.ColumnaEmail.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 358);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxEditar);
            this.Controls.Add(this.pictureBoxEliminar);
            this.Controls.Add(this.pictureBoxAñadir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAñadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAñadir;
        private System.Windows.Forms.PictureBox pictureBoxEliminar;
        private System.Windows.Forms.PictureBox pictureBoxEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEmail;
    }
}

