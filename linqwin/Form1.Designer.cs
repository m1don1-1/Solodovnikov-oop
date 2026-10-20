namespace linq
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
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnCalcAggregates = new System.Windows.Forms.Button();
            this.btnExceptOnlineOnly = new System.Windows.Forms.Button();
            this.btnIntersectBoth = new System.Windows.Forms.Button();
            this.btnUnionAllUnique = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblMinMax = new System.Windows.Forms.Label();
            this.lblAggregate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(100, 102);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(240, 150);
            this.dgvResults.TabIndex = 0;
            // 
            // btnCalcAggregates
            // 
            this.btnCalcAggregates.Location = new System.Drawing.Point(346, 138);
            this.btnCalcAggregates.Name = "btnCalcAggregates";
            this.btnCalcAggregates.Size = new System.Drawing.Size(124, 23);
            this.btnCalcAggregates.TabIndex = 1;
            this.btnCalcAggregates.Text = "Расчет агрегатов";
            this.btnCalcAggregates.UseVisualStyleBackColor = true;
            this.btnCalcAggregates.Click += new System.EventHandler(this.btnCalcAggregates_Click);
            // 
            // btnExceptOnlineOnly
            // 
            this.btnExceptOnlineOnly.Location = new System.Drawing.Point(346, 167);
            this.btnExceptOnlineOnly.Name = "btnExceptOnlineOnly";
            this.btnExceptOnlineOnly.Size = new System.Drawing.Size(124, 23);
            this.btnExceptOnlineOnly.TabIndex = 2;
            this.btnExceptOnlineOnly.Text = "Только онлайн";
            this.btnExceptOnlineOnly.UseVisualStyleBackColor = true;
            // 
            // btnIntersectBoth
            // 
            this.btnIntersectBoth.Location = new System.Drawing.Point(346, 196);
            this.btnIntersectBoth.Name = "btnIntersectBoth";
            this.btnIntersectBoth.Size = new System.Drawing.Size(124, 23);
            this.btnIntersectBoth.TabIndex = 3;
            this.btnIntersectBoth.Text = "В обоих каналах";
            this.btnIntersectBoth.UseVisualStyleBackColor = true;
            // 
            // btnUnionAllUnique
            // 
            this.btnUnionAllUnique.Location = new System.Drawing.Point(346, 229);
            this.btnUnionAllUnique.Name = "btnUnionAllUnique";
            this.btnUnionAllUnique.Size = new System.Drawing.Size(124, 23);
            this.btnUnionAllUnique.TabIndex = 4;
            this.btnUnionAllUnique.Text = "Все уникальные";
            this.btnUnionAllUnique.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(97, 264);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "label1";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(97, 289);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(35, 13);
            this.lblSum.TabIndex = 6;
            this.lblSum.Text = "label2";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(97, 312);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(35, 13);
            this.lblAvg.TabIndex = 7;
            this.lblAvg.Text = "label3";
            // 
            // lblMinMax
            // 
            this.lblMinMax.AutoSize = true;
            this.lblMinMax.Location = new System.Drawing.Point(97, 336);
            this.lblMinMax.Name = "lblMinMax";
            this.lblMinMax.Size = new System.Drawing.Size(35, 13);
            this.lblMinMax.TabIndex = 8;
            this.lblMinMax.Text = "label4";
            // 
            // lblAggregate
            // 
            this.lblAggregate.AutoSize = true;
            this.lblAggregate.Location = new System.Drawing.Point(97, 361);
            this.lblAggregate.Name = "lblAggregate";
            this.lblAggregate.Size = new System.Drawing.Size(35, 13);
            this.lblAggregate.TabIndex = 9;
            this.lblAggregate.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAggregate);
            this.Controls.Add(this.lblMinMax);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnUnionAllUnique);
            this.Controls.Add(this.btnIntersectBoth);
            this.Controls.Add(this.btnExceptOnlineOnly);
            this.Controls.Add(this.btnCalcAggregates);
            this.Controls.Add(this.dgvResults);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnCalcAggregates;
        private System.Windows.Forms.Button btnExceptOnlineOnly;
        private System.Windows.Forms.Button btnIntersectBoth;
        private System.Windows.Forms.Button btnUnionAllUnique;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblMinMax;
        private System.Windows.Forms.Label lblAggregate;
    }
}

