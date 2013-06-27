namespace BierplicatieFormsApplication
{
    partial class Overzichtspagina
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
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SilkeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statiegeldTotaalSilkePagina = new System.Windows.Forms.TextBox();
            this.statiegeldSilke = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.statiegeldTotaalNickPagina = new System.Windows.Forms.TextBox();
            this.statiegeldNick = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.statiegeldTotaalDanielPagina = new System.Windows.Forms.TextBox();
            this.statiegeldDaniel = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.statiegeldTotaalEmmaPagina = new System.Windows.Forms.TextBox();
            this.statiegeldEmma = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.statiegeldTotaalIngelizePagina = new System.Windows.Forms.TextBox();
            this.statiegeldIngelize = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SilkeChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 509);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SilkeChart);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.statiegeldTotaalSilkePagina);
            this.tabPage1.Controls.Add(this.statiegeldSilke);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1. Silke";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SilkeChart
            // 
            lineAnnotation1.Name = "LineAnnotation1";
            this.SilkeChart.Annotations.Add(lineAnnotation1);
            chartArea1.Name = "ChartArea1";
            this.SilkeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SilkeChart.Legends.Add(legend1);
            this.SilkeChart.Location = new System.Drawing.Point(8, 6);
            this.SilkeChart.Name = "SilkeChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SilkeChart.Series.Add(series1);
            this.SilkeChart.Size = new System.Drawing.Size(406, 443);
            this.SilkeChart.TabIndex = 4;
            this.SilkeChart.Text = "statistieken Silke";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 455);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "totaal";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 455);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Eigen";
            // 
            // statiegeldTotaalSilkePagina
            // 
            this.statiegeldTotaalSilkePagina.Cursor = System.Windows.Forms.Cursors.No;
            this.statiegeldTotaalSilkePagina.Location = new System.Drawing.Point(232, 456);
            this.statiegeldTotaalSilkePagina.Name = "statiegeldTotaalSilkePagina";
            this.statiegeldTotaalSilkePagina.ReadOnly = true;
            this.statiegeldTotaalSilkePagina.Size = new System.Drawing.Size(76, 20);
            this.statiegeldTotaalSilkePagina.TabIndex = 1;
            this.statiegeldTotaalSilkePagina.TabStop = false;
            // 
            // statiegeldSilke
            // 
            this.statiegeldSilke.Cursor = System.Windows.Forms.Cursors.No;
            this.statiegeldSilke.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statiegeldSilke.Location = new System.Drawing.Point(76, 455);
            this.statiegeldSilke.Name = "statiegeldSilke";
            this.statiegeldSilke.ReadOnly = true;
            this.statiegeldSilke.Size = new System.Drawing.Size(76, 20);
            this.statiegeldSilke.TabIndex = 0;
            this.statiegeldSilke.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.statiegeldTotaalNickPagina);
            this.tabPage2.Controls.Add(this.statiegeldNick);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2. Nick";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 454);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "totaal";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 454);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(66, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Eigen";
            // 
            // statiegeldTotaalNickPagina
            // 
            this.statiegeldTotaalNickPagina.Location = new System.Drawing.Point(236, 455);
            this.statiegeldTotaalNickPagina.Name = "statiegeldTotaalNickPagina";
            this.statiegeldTotaalNickPagina.ReadOnly = true;
            this.statiegeldTotaalNickPagina.Size = new System.Drawing.Size(76, 20);
            this.statiegeldTotaalNickPagina.TabIndex = 5;
            this.statiegeldTotaalNickPagina.TabStop = false;
            // 
            // statiegeldNick
            // 
            this.statiegeldNick.Location = new System.Drawing.Point(80, 454);
            this.statiegeldNick.Name = "statiegeldNick";
            this.statiegeldNick.ReadOnly = true;
            this.statiegeldNick.Size = new System.Drawing.Size(76, 20);
            this.statiegeldNick.TabIndex = 4;
            this.statiegeldNick.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.statiegeldTotaalDanielPagina);
            this.tabPage3.Controls.Add(this.statiegeldDaniel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(425, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3. Daniël";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(161, 455);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(66, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "totaal";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(5, 455);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(66, 20);
            this.textBox6.TabIndex = 6;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Eigen";
            // 
            // statiegeldTotaalDanielPagina
            // 
            this.statiegeldTotaalDanielPagina.Location = new System.Drawing.Point(233, 456);
            this.statiegeldTotaalDanielPagina.Name = "statiegeldTotaalDanielPagina";
            this.statiegeldTotaalDanielPagina.ReadOnly = true;
            this.statiegeldTotaalDanielPagina.Size = new System.Drawing.Size(76, 20);
            this.statiegeldTotaalDanielPagina.TabIndex = 5;
            this.statiegeldTotaalDanielPagina.TabStop = false;
            // 
            // statiegeldDaniel
            // 
            this.statiegeldDaniel.Location = new System.Drawing.Point(77, 455);
            this.statiegeldDaniel.Name = "statiegeldDaniel";
            this.statiegeldDaniel.ReadOnly = true;
            this.statiegeldDaniel.Size = new System.Drawing.Size(76, 20);
            this.statiegeldDaniel.TabIndex = 4;
            this.statiegeldDaniel.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox7);
            this.tabPage4.Controls.Add(this.textBox8);
            this.tabPage4.Controls.Add(this.statiegeldTotaalEmmaPagina);
            this.tabPage4.Controls.Add(this.statiegeldEmma);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(425, 483);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "4. Emma";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(162, 454);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(66, 20);
            this.textBox7.TabIndex = 7;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "totaal";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 454);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(66, 20);
            this.textBox8.TabIndex = 6;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Eigen";
            // 
            // statiegeldTotaalEmmaPagina
            // 
            this.statiegeldTotaalEmmaPagina.Location = new System.Drawing.Point(234, 455);
            this.statiegeldTotaalEmmaPagina.Name = "statiegeldTotaalEmmaPagina";
            this.statiegeldTotaalEmmaPagina.ReadOnly = true;
            this.statiegeldTotaalEmmaPagina.Size = new System.Drawing.Size(76, 20);
            this.statiegeldTotaalEmmaPagina.TabIndex = 5;
            this.statiegeldTotaalEmmaPagina.TabStop = false;
            // 
            // statiegeldEmma
            // 
            this.statiegeldEmma.Location = new System.Drawing.Point(78, 454);
            this.statiegeldEmma.Name = "statiegeldEmma";
            this.statiegeldEmma.ReadOnly = true;
            this.statiegeldEmma.Size = new System.Drawing.Size(76, 20);
            this.statiegeldEmma.TabIndex = 4;
            this.statiegeldEmma.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox9);
            this.tabPage5.Controls.Add(this.textBox10);
            this.tabPage5.Controls.Add(this.statiegeldTotaalIngelizePagina);
            this.tabPage5.Controls.Add(this.statiegeldIngelize);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(425, 483);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "5. Inge-lize";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(160, 454);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(66, 20);
            this.textBox9.TabIndex = 7;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "totaal";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(4, 454);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(66, 20);
            this.textBox10.TabIndex = 6;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Eigen";
            // 
            // statiegeldTotaalIngelizePagina
            // 
            this.statiegeldTotaalIngelizePagina.Location = new System.Drawing.Point(232, 455);
            this.statiegeldTotaalIngelizePagina.Name = "statiegeldTotaalIngelizePagina";
            this.statiegeldTotaalIngelizePagina.ReadOnly = true;
            this.statiegeldTotaalIngelizePagina.Size = new System.Drawing.Size(76, 20);
            this.statiegeldTotaalIngelizePagina.TabIndex = 5;
            this.statiegeldTotaalIngelizePagina.TabStop = false;
            // 
            // statiegeldIngelize
            // 
            this.statiegeldIngelize.Location = new System.Drawing.Point(76, 454);
            this.statiegeldIngelize.Name = "statiegeldIngelize";
            this.statiegeldIngelize.ReadOnly = true;
            this.statiegeldIngelize.Size = new System.Drawing.Size(76, 20);
            this.statiegeldIngelize.TabIndex = 4;
            this.statiegeldIngelize.TabStop = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(425, 483);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "6. Afsluiten";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Overzichtspagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 511);
            this.Controls.Add(this.tabControl1);
            this.Name = "Overzichtspagina";
            this.Text = "Ovahzichtspagina";
            this.Load += new System.EventHandler(this.Overzichtspagina_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SilkeChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox statiegeldTotaalSilkePagina;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox statiegeldTotaalNickPagina;
        private System.Windows.Forms.TextBox statiegeldNick;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox statiegeldTotaalDanielPagina;
        private System.Windows.Forms.TextBox statiegeldDaniel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox statiegeldTotaalEmmaPagina;
        private System.Windows.Forms.TextBox statiegeldEmma;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox statiegeldTotaalIngelizePagina;
        private System.Windows.Forms.TextBox statiegeldIngelize;
        private System.Windows.Forms.TextBox statiegeldSilke;
        public System.Windows.Forms.DataVisualization.Charting.Chart SilkeChart;
    }
}