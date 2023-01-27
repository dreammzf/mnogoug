
namespace mnogoug
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.окружностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.треугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фигураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окружностьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.треугольникToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.окружностьToolStripMenuItem,
            this.треугольникToolStripMenuItem,
            this.квадратToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(145, 70);
            // 
            // окружностьToolStripMenuItem
            // 
            this.окружностьToolStripMenuItem.Name = "окружностьToolStripMenuItem";
            this.окружностьToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.окружностьToolStripMenuItem.Text = "Окружность";
            // 
            // треугольникToolStripMenuItem
            // 
            this.треугольникToolStripMenuItem.Name = "треугольникToolStripMenuItem";
            this.треугольникToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.треугольникToolStripMenuItem.Text = "Треугольник";
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.квадратToolStripMenuItem.Text = "Квадрат";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фигураToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фигураToolStripMenuItem
            // 
            this.фигураToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.фигураToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.окружностьToolStripMenuItem1,
            this.треугольникToolStripMenuItem1,
            this.квадратToolStripMenuItem1});
            this.фигураToolStripMenuItem.Name = "фигураToolStripMenuItem";
            this.фигураToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.фигураToolStripMenuItem.Text = "Фигура";
            // 
            // окружностьToolStripMenuItem1
            // 
            this.окружностьToolStripMenuItem1.Name = "окружностьToolStripMenuItem1";
            this.окружностьToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.окружностьToolStripMenuItem1.Text = "Окружность";
            this.окружностьToolStripMenuItem1.Click += new System.EventHandler(this.окружностьToolStripMenuItem1_Click);
            // 
            // треугольникToolStripMenuItem1
            // 
            this.треугольникToolStripMenuItem1.Name = "треугольникToolStripMenuItem1";
            this.треугольникToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.треугольникToolStripMenuItem1.Text = "Треугольник";
            this.треугольникToolStripMenuItem1.Click += new System.EventHandler(this.треугольникToolStripMenuItem1_Click);
            // 
            // квадратToolStripMenuItem1
            // 
            this.квадратToolStripMenuItem1.Name = "квадратToolStripMenuItem1";
            this.квадратToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.квадратToolStripMenuItem1.Text = "Квадрат";
            this.квадратToolStripMenuItem1.Click += new System.EventHandler(this.квадратToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem окружностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem треугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фигураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окружностьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem треугольникToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem1;
    }
}

