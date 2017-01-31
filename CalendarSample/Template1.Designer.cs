namespace CalendarSample
{          
    [System.ComponentModel.ToolboxItem(true)]
    partial class Template1
    {
        /// <summary> 
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region MultiRow Template Designer generated code

		/// <summary> 
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
        private void InitializeComponent()
        {
            GrapeCity.Win.MultiRow.CellStyle cellStyle6 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.CellStyle cellStyle7 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.CellStyle cellStyle8 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.CellStyle cellStyle9 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.CellStyle cellStyle10 = new GrapeCity.Win.MultiRow.CellStyle();
            this.rowHeaderCell1 = new GrapeCity.Win.MultiRow.RowHeaderCell();
            this.labelCell1 = new GrapeCity.Win.MultiRow.LabelCell();
            this.labelCell2 = new GrapeCity.Win.MultiRow.LabelCell();
            this.labelCell3 = new GrapeCity.Win.MultiRow.LabelCell();
            this.labelCell4 = new GrapeCity.Win.MultiRow.LabelCell();
            this.labelCell5 = new GrapeCity.Win.MultiRow.LabelCell();
            // 
            // Row
            // 
            this.Row.Cells.Add(this.labelCell1);
            this.Row.Cells.Add(this.labelCell2);
            this.Row.Cells.Add(this.labelCell3);
            this.Row.Cells.Add(this.labelCell4);
            this.Row.Cells.Add(this.labelCell5);
            this.Row.Cells.Add(this.rowHeaderCell1);
            this.Row.Height = 84;
            this.Row.Width = 200;
            // 
            // rowHeaderCell1
            // 
            this.rowHeaderCell1.Location = new System.Drawing.Point(0, 0);
            this.rowHeaderCell1.Name = "rowHeaderCell1";
            this.rowHeaderCell1.Size = new System.Drawing.Size(40, 84);
            this.rowHeaderCell1.TabIndex = 8;
            // 
            // labelCell1
            // 
            this.labelCell1.Location = new System.Drawing.Point(40, 0);
            this.labelCell1.Name = "labelCell1";
            this.labelCell1.ReadOnly = false;
            this.labelCell1.Size = new System.Drawing.Size(80, 84);
            this.labelCell1.Style = cellStyle6;
            this.labelCell1.TabIndex = 0;
            // 
            // labelCell2
            // 
            this.labelCell2.Location = new System.Drawing.Point(120, 0);
            this.labelCell2.Name = "labelCell2";
            this.labelCell2.ReadOnly = false;
            this.labelCell2.Style = cellStyle7;
            this.labelCell2.TabIndex = 1;
            // 
            // labelCell3
            // 
            this.labelCell3.Location = new System.Drawing.Point(120, 21);
            this.labelCell3.Name = "labelCell3";
            this.labelCell3.ReadOnly = false;
            this.labelCell3.Style = cellStyle8;
            this.labelCell3.TabIndex = 3;
            // 
            // labelCell4
            // 
            this.labelCell4.Location = new System.Drawing.Point(120, 42);
            this.labelCell4.Name = "labelCell4";
            this.labelCell4.ReadOnly = false;
            this.labelCell4.Style = cellStyle9;
            this.labelCell4.TabIndex = 5;
            // 
            // labelCell5
            // 
            this.labelCell5.Location = new System.Drawing.Point(120, 63);
            this.labelCell5.Name = "labelCell5";
            this.labelCell5.ReadOnly = false;
            this.labelCell5.Style = cellStyle10;
            this.labelCell5.TabIndex = 7;
            // 
            // Template1
            // 
            this.Height = 84;
            this.Width = 200;

        }
        

        #endregion
        private GrapeCity.Win.MultiRow.RowHeaderCell rowHeaderCell1;
        private GrapeCity.Win.MultiRow.LabelCell labelCell1;
        private GrapeCity.Win.MultiRow.LabelCell labelCell2;
        private GrapeCity.Win.MultiRow.LabelCell labelCell3;
        private GrapeCity.Win.MultiRow.LabelCell labelCell4;
        private GrapeCity.Win.MultiRow.LabelCell labelCell5;
    }
}
