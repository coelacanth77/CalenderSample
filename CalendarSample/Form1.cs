using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // データを用意
            List<CalendarData> dataList = new List<CalendarData>();

            CalendarData data = new CalendarData() { date = new DateTime(2017, 1, 5)};
            data.personList = new List<Person>();
            data.personList.Add(new Person() { name = "山田" });
            data.personList.Add(new Person() { name = "佐藤" });

            dataList.Add(data);

            CalendarData data2 = new CalendarData() { date = new DateTime(2017, 1, 6)};
            data2.personList = new List<Person>();
            data2.personList.Add(new Person() { name = "田中" });
            data2.personList.Add(new Person() { name = "西村" });
            data2.personList.Add(new Person() { name = "佐藤" });

            dataList.Add(data2);

            CalendarData data3 = new CalendarData() { date = new DateTime(2017, 1, 7) };
            data3.personList = new List<Person>();
            data3.personList.Add(new Person() { name = "山田" });
            data3.personList.Add(new Person() { name = "川上" });
            data3.personList.Add(new Person() { name = "田中" });

            dataList.Add(data3);
            // データを用意ここまで

            gcCalendarGrid1.DataSource = dataList;

            // dateプロパティをカレンダーの日付に紐づける
            gcCalendarGrid1.DateField = "date";

            // テンプレートにリストの項目を紐づける
            var template = gcCalendarGrid1.Template;

            template.Content[1, 0].DataField = "name1";
            template.Content[2, 0].DataField = "name2";
            template.Content[3, 0].DataField = "name3";

            gcCalendarGrid1.Template = template;

            gcCalendarGrid1.FirstDateInView = new DateTime(2017, 1, 1);

            // 編集の終了を通知
            gcCalendarGrid1.EndEdit();

            // MultiRowDataの形式に変換
            List<MultiRowData> multiRowDataList = new List<MultiRowData>();

            foreach (var tmpData in dataList)
            {
                foreach (var tmpPerson in tmpData.personList)
                {
                    if (multiRowDataList.Count(x => x.name == tmpPerson.name) > 0)
                    {
                        multiRowDataList.First(x => x.name == tmpPerson.name).dateTimeList.Add(tmpData.date);
                    }
                    else
                    {
                        List<DateTime> tmpDateTimeList = new List<DateTime>();
                        tmpDateTimeList.Add(tmpData.date);

                        multiRowDataList.Add(new MultiRowData() { person = tmpPerson, dateTimeList = tmpDateTimeList });
                    }
                }
            }
            // MultiRowDataの形式に変換ここまで

            gcMultiRow1.DataSource = multiRowDataList;

            var multiRowTemplate = gcMultiRow1.Template;

            multiRowTemplate.Row.Cells[0].DataField = "name";
            multiRowTemplate.Row.Cells[1].DataField = "date1";
            multiRowTemplate.Row.Cells[2].DataField = "date2";
            multiRowTemplate.Row.Cells[3].DataField = "date3";

            gcMultiRow1.Template = multiRowTemplate;

            gcMultiRow1.EndEdit();

        }
    }

    /// <summary>
    /// カレンダーの一日のデータを表すクラス
    /// カレンダー表示用にゲッターを用意
    /// </summary>
    public class CalendarData
    {
        /// <summary>
        /// 日付
        /// </summary>
        public DateTime date { set; get; }

        /// <summary>
        /// その日の打ち合わせ担当者リスト
        /// </summary>
        public List<Person> personList { get; set; }

        /// <summary>
        /// 担当者の名前を返す
        /// </summary>
        public string name1 { get { if (personList.Count > 0) { return personList[0].name; } else return ""; } }
        public string name2 { get { if (personList.Count > 1) { return personList[1].name; } else return ""; } }
        public string name3 { get { if (personList.Count > 2) { return personList[2].name; } else return ""; } }
    }

    /// <summary>
    /// グリッド表示用のデータ
    /// </summary>
    public class MultiRowData
    {
        /// <summary>
        /// 名前
        /// Personクラスのnameプロパティを返す
        /// </summary>
        public string name { get { return person.name; } }

        public Person person { get;  set; }

        public List<DateTime> dateTimeList { get; set; }

        /// <summary>
        /// 日付を整形して返す
        /// </summary>
        public string date1 { get { if (dateTimeList.Count > 0) { return dateTimeList[0].ToString("yyyy/MM/dd"); } else return ""; } }
        public string date2 { get { if (dateTimeList.Count > 1) { return dateTimeList[1].ToString("yyyy/MM/dd"); } else return ""; } }
        public string date3 { get { if (dateTimeList.Count > 2) { return dateTimeList[2].ToString("yyyy/MM/dd"); } else return ""; } }
    }

    /// <summary>
    /// 担当者を表すクラス
    /// </summary>
    public class Person
    {
        /// <summary>
        /// 名前
        /// </summary>
        public string name { get; set; }
    }
}
