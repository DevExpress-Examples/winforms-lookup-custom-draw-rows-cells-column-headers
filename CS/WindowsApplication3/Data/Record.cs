using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace DXSample.Data {
    public class Record {
        public Record() {
        }
        public int ID { get; set; }
        public int? ParentID { get; set; }
        public string Text { get; set; }
        public string Info { get; set; }
        public double Value { get; set; }
        public DateTime Dt { get; set; }
        public bool State { get; set; }
        public Image Image { get; set; }
        public BindingList<Detail> Details { get; set; }
        public override string ToString() {
            return string.Format("ID = {0}, Text = {1}", ID, Text);
        }
        public Detail Detail { get; set; }

    }
    public class Detail {
        public Detail() {
            Details = new BindingList<Detail>();
        }
        public int ID { get; set; }
        public string Text { get; set; }
        public string Info { get; set; }
        public BindingList<Detail> Details { get; set; }
        public override string ToString() {
            return Text;
        }
    }

    public class DataHelper {
        public static BindingList<Record> GetData(int count, int detailCount){
            BindingList<Record> records = new BindingList<Record>();
            BindingList<Detail> details = new BindingList<Detail>();
            BindingList<Detail> testDetails = new BindingList<Detail>();
            for (int j = 0; j < detailCount; j++) {
                details.Add(new Detail() {
                    ID = j,
                    Text = string.Format("Text {0}", j),
                    Info = string.Format("Info {0}", j)
                });
                testDetails.Add(new Detail() {
                    ID = j,
                    Text = string.Format("Test Text {0}", j),
                    Info = string.Format(" Test Info {0}", j)
                });
            }
            for (int i = 0; i < count; i++)
                records.Add(new Record() {
                    ParentID = -1,
                    ID = i,
                    Text = string.Format("Text {0}", i),
                    Info = string.Format("Info {0}", i),
                    Dt = DateTime.Now.AddDays(i),
                    State = i % 2 == 0,
                    Image = SystemIcons.Information.ToBitmap(),
                    Details = new BindingList<Detail>(details),
                    Value = i * 0.00001,
                    Detail = new Detail() { ID = i, Text = string.Format("Text {0}", i) }
                });

            return records;
        }
        public static BindingList<Record> GetData(int count) {
            BindingList<Record> records = new BindingList<Record>();
            for (int i = 0; i < count; i++)
                records.Add(new Record() {
                    ID = i,
                    ParentID = i % 5,
                    Text = string.Format("Text {0}", i),
                    Info = string.Format("Info {0}", i),
                    Dt =  DateTime.Now.AddDays(i),
                    Value = 10.1 * i,
                    State = false,
                    Image = SystemIcons.Information.ToBitmap(),
                    Detail = new Detail() { ID = i }
                });
            return records;
        }
        public static BindingList<Detail> GetDetailData(int count) {
            BindingList<Detail> records = new BindingList<Detail>();
            for (int i = 0; i < count; i++)
                records.Add(new Detail() {
                    ID = i,
                    Text = string.Format("Text {0}", i),
                    Info = string.Format("Info {0}", i)
                });
            return records;
        }
    }
}
