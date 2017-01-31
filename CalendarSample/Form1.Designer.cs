namespace CalendarSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            GrapeCity.Win.CalendarGrid.CalendarConditionalCellStyle calendarConditionalCellStyle1 = new GrapeCity.Win.CalendarGrid.CalendarConditionalCellStyle();
            GrapeCity.Win.CalendarGrid.CalendarCellStyle calendarCellStyle1 = new GrapeCity.Win.CalendarGrid.CalendarCellStyle();
            GrapeCity.Win.CalendarGrid.CalendarCellStyle calendarCellStyle2 = new GrapeCity.Win.CalendarGrid.CalendarCellStyle();
            GrapeCity.Win.CalendarGrid.CalendarCellStyle calendarCellStyle3 = new GrapeCity.Win.CalendarGrid.CalendarCellStyle();
            GrapeCity.Win.CalendarGrid.CalendarCellStyle calendarCellStyle4 = new GrapeCity.Win.CalendarGrid.CalendarCellStyle();
            GrapeCity.Win.CalendarGrid.CalendarTemplate calendarTemplate1 = new GrapeCity.Win.CalendarGrid.CalendarTemplate();
            GrapeCity.Win.CalendarGrid.CalendarHeaderCellType calendarHeaderCellType1 = new GrapeCity.Win.CalendarGrid.CalendarHeaderCellType();
            this.gcCalendarGrid1 = new GrapeCity.Win.CalendarGrid.GcCalendarGrid();
            this.calendarTitleCaption1 = new GrapeCity.Win.CalendarGrid.CalendarTitleCaption();
            this.calendarTitleButton1 = new GrapeCity.Win.CalendarGrid.CalendarTitleButton();
            this.calendarTitleButton2 = new GrapeCity.Win.CalendarGrid.CalendarTitleButton();
            this.calendarTitleButton3 = new GrapeCity.Win.CalendarGrid.CalendarTitleButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gcMultiRow1 = new GrapeCity.Win.MultiRow.GcMultiRow();
            this.template11 = new CalendarSample.Template1();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gcCalendarGrid1)).BeginInit();
            this.gcCalendarGrid1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMultiRow1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCalendarGrid1
            // 
            this.gcCalendarGrid1.Commands.AddRange(new GrapeCity.Win.CalendarGrid.CalendarGridCommand[] {
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveLeft, System.Windows.Forms.Keys.Left),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveRight, System.Windows.Forms.Keys.Right),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveUp, System.Windows.Forms.Keys.Up),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveDown, System.Windows.Forms.Keys.Down),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveToFirstCell, System.Windows.Forms.Keys.Home),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveToLastCell, System.Windows.Forms.Keys.End),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveToPreviousPage, System.Windows.Forms.Keys.PageUp),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveToNextPage, System.Windows.Forms.Keys.Next),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveToPreviousCell, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Tab)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveToNextCell, System.Windows.Forms.Keys.Tab),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveToPreviousDate, ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                            | System.Windows.Forms.Keys.Tab)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveToNextDate, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.SelectAll, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.SelectLeft, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Left)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.SelectRight, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Right)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.SelectUp, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Up)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.SelectDown, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Down)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.SelectToFirstCell, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Home)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.SelectToLastCell, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.End)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.SelectToPreviousPage, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.PageUp)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.SelectToNextPage, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Next)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.BeginEdit, System.Windows.Forms.Keys.F2),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.ToggleEdit, System.Windows.Forms.Keys.Return),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.Clear, System.Windows.Forms.Keys.Delete),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.Copy, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.Copy, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.Cut, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.Cut, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.Paste, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.Paste, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.CancelEdit, System.Windows.Forms.Keys.Escape),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.ShowDropDown, System.Windows.Forms.Keys.F4),
            new GrapeCity.Win.CalendarGrid.CalendarGridKeyboardCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.ShowDropDown, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down)))),
            new GrapeCity.Win.CalendarGrid.CalendarGridMouseCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.Zoom(0.1F), GrapeCity.Win.CalendarGrid.CalendarMouseGesture.CtrlWheel),
            new GrapeCity.Win.CalendarGrid.CalendarGridTouchCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveToNextPage, GrapeCity.Win.CalendarGrid.CalendarTouchGesture.SwipeLeft),
            new GrapeCity.Win.CalendarGrid.CalendarGridTouchCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveToPreviousPage, GrapeCity.Win.CalendarGrid.CalendarTouchGesture.SwipeRight),
            new GrapeCity.Win.CalendarGrid.CalendarGridTouchCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveToNextPage, GrapeCity.Win.CalendarGrid.CalendarTouchGesture.SwipeUp),
            new GrapeCity.Win.CalendarGrid.CalendarGridTouchCommand(GrapeCity.Win.CalendarGrid.CalendarGridActions.MoveToPreviousPage, GrapeCity.Win.CalendarGrid.CalendarTouchGesture.SwipeDown)});
            this.gcCalendarGrid1.Location = new System.Drawing.Point(24, 6);
            this.gcCalendarGrid1.Name = "gcCalendarGrid1";
            this.gcCalendarGrid1.Size = new System.Drawing.Size(913, 622);
            calendarCellStyle1.ForeColor = System.Drawing.Color.Red;
            calendarCellStyle2.ForeColor = System.Drawing.Color.Blue;
            calendarCellStyle3.ForeColor = System.Drawing.Color.Red;
            calendarCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            calendarCellStyle4.ForeColor = System.Drawing.Color.Gray;
            calendarConditionalCellStyle1.Items.Add(new GrapeCity.Win.CalendarGrid.CalendarConditionalCellStyleItem(calendarCellStyle1, GrapeCity.Win.CalendarGrid.ConditionalStyleOperator.IsSunday));
            calendarConditionalCellStyle1.Items.Add(new GrapeCity.Win.CalendarGrid.CalendarConditionalCellStyleItem(calendarCellStyle2, GrapeCity.Win.CalendarGrid.ConditionalStyleOperator.IsSaturday));
            calendarConditionalCellStyle1.Items.Add(new GrapeCity.Win.CalendarGrid.CalendarConditionalCellStyleItem(calendarCellStyle3, GrapeCity.Win.CalendarGrid.ConditionalStyleOperator.IsHoliday));
            calendarConditionalCellStyle1.Items.Add(new GrapeCity.Win.CalendarGrid.CalendarConditionalCellStyleItem(calendarCellStyle4, GrapeCity.Win.CalendarGrid.ConditionalStyleOperator.IsTrailingDay));
            calendarConditionalCellStyle1.Name = "defaultStyle";
            this.gcCalendarGrid1.Styles.Add(calendarConditionalCellStyle1);
            this.gcCalendarGrid1.TabIndex = 0;
            calendarTemplate1.RowCount = 5;
            calendarTemplate1.RowHeaderColumnCount = 0;
            calendarTemplate1.ColumnHeader.CellStyleName = "defaultStyle";
            calendarHeaderCellType1.SupportLocalization = true;
            calendarTemplate1.ColumnHeader.GetCell(0, 0).CellType = calendarHeaderCellType1;
            calendarTemplate1.ColumnHeader.GetCell(0, 0).DateFormat = "{DayOfWeek}";
            calendarTemplate1.ColumnHeader.GetCell(0, 0).CellStyle.Alignment = GrapeCity.Win.CalendarGrid.CalendarGridContentAlignment.MiddleCenter;
            calendarTemplate1.Content.CellStyleName = "defaultStyle";
            calendarTemplate1.Content.GetCell(0, 0).DateFormat = "d日";
            calendarTemplate1.Content.GetCell(0, 0).DateFormatType = GrapeCity.Win.CalendarGrid.CalendarDateFormatType.DotNet;
            calendarTemplate1.Content.GetCell(4, 0).DateFormat = "{Rokuyou}";
            calendarTemplate1.Content.GetCell(4, 0).CellStyle.Alignment = GrapeCity.Win.CalendarGrid.CalendarGridContentAlignment.MiddleRight;
            this.gcCalendarGrid1.Template = calendarTemplate1;
            this.gcCalendarGrid1.TitleHeader.Children.Add(this.calendarTitleCaption1);
            this.gcCalendarGrid1.TitleHeader.Children.Add(this.calendarTitleButton1);
            this.gcCalendarGrid1.TitleHeader.Children.Add(this.calendarTitleButton2);
            this.gcCalendarGrid1.TitleHeader.Children.Add(this.calendarTitleButton3);
            // 
            // calendarTitleCaption1
            // 
            this.calendarTitleCaption1.DateFormat = "yyyy年M月 (ggge年)";
            this.calendarTitleCaption1.DateFormatType = GrapeCity.Win.CalendarGrid.CalendarDateFormatType.InputMan;
            this.calendarTitleCaption1.Name = "calendarTitleCaption1";
            this.calendarTitleCaption1.Text = "{0}";
            // 
            // calendarTitleButton1
            // 
            this.calendarTitleButton1.ButtonBehavior = GrapeCity.Win.CalendarGrid.CalendarTitleButtonBehavior.GotoToday;
            this.calendarTitleButton1.HorizontalAlignment = GrapeCity.Win.CalendarGrid.CalendarHorizontalAlignment.Right;
            this.calendarTitleButton1.Name = "calendarTitleButton1";
            this.calendarTitleButton1.Text = "今日へ移動";
            this.calendarTitleButton1.ToolTipText = "{0}";
            // 
            // calendarTitleButton2
            // 
            this.calendarTitleButton2.ButtonBehavior = GrapeCity.Win.CalendarGrid.CalendarTitleButtonBehavior.Next;
            this.calendarTitleButton2.HorizontalAlignment = GrapeCity.Win.CalendarGrid.CalendarHorizontalAlignment.Right;
            this.calendarTitleButton2.Name = "calendarTitleButton2";
            this.calendarTitleButton2.Text = ">>";
            this.calendarTitleButton2.ToolTipText = "{0}";
            // 
            // calendarTitleButton3
            // 
            this.calendarTitleButton3.ButtonBehavior = GrapeCity.Win.CalendarGrid.CalendarTitleButtonBehavior.Previous;
            this.calendarTitleButton3.HorizontalAlignment = GrapeCity.Win.CalendarGrid.CalendarHorizontalAlignment.Right;
            this.calendarTitleButton3.Name = "calendarTitleButton3";
            this.calendarTitleButton3.Text = "<<";
            this.calendarTitleButton3.ToolTipText = "{0}";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 648);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gcCalendarGrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "カレンダー表示";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gcMultiRow1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "リスト表示";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gcMultiRow1
            // 
            this.gcMultiRow1.Location = new System.Drawing.Point(29, 29);
            this.gcMultiRow1.Name = "gcMultiRow1";
            this.gcMultiRow1.Size = new System.Drawing.Size(850, 497);
            this.gcMultiRow1.TabIndex = 0;
            this.gcMultiRow1.Template = this.template11;
            this.gcMultiRow1.Text = "gcMultiRow1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 686);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCalendarGrid1)).EndInit();
            this.gcCalendarGrid1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMultiRow1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GrapeCity.Win.CalendarGrid.GcCalendarGrid gcCalendarGrid1;
        private GrapeCity.Win.CalendarGrid.CalendarTitleCaption calendarTitleCaption1;
        private GrapeCity.Win.CalendarGrid.CalendarTitleButton calendarTitleButton1;
        private GrapeCity.Win.CalendarGrid.CalendarTitleButton calendarTitleButton2;
        private GrapeCity.Win.CalendarGrid.CalendarTitleButton calendarTitleButton3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private GrapeCity.Win.MultiRow.GcMultiRow gcMultiRow1;
        private Template1 template11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

