using Newtonsoft.Json;
using Sync2._0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicSchemaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var json = "{\r\n  \"Id\": \"9436286f-20e8-443d-b17c-3f17e590eb9f\",\r\n  \"Columns\": {\r\n    \"b\": {\r\n      \"Name\": \"b\",\r\n      \"DataType\": \"System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\n    },\r\n    \"d\": {\r\n      \"Name\": \"d\",\r\n      \"DataType\": \"System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\n    }\r\n  },\r\n  \"ProjectTable\": {\r\n    \"Name\": \"t1\"\r\n  },\r\n  \"ProjectTableName\": \"t1\"\r\n}";
            var schema = JsonConvert.DeserializeObject<SchemaDefinition>(json);

            var table = new DataTable();
            foreach (var item in schema.Columns.Values)
            {
                table.Columns.Add(item.Name, item.DataType);
            }

            dataGridView1.DataSource = table;
        }
    }
}
