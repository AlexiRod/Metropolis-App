﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;

//using System.ComponentModel;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



namespace Metropolis
{
    public partial class LinesForm : System.Windows.Forms.Form
    {
        // параметры данных для формы

        DataSet ds;
        public LinesForm()
        {
            int li_rc;
            InitializeComponent();
            li_rc = FillData();
            if (li_rc < 0)
            {
                MessageBox.Show("Не удалось считать линии. Код ошибки " +  li_rc.ToString() );
                return;
            }

            InitializeContextMenu();
        }

        private int FillData()
        {
            int li_rc = -1;
            //    SQLiteConnection connection;
            //    SQLiteDataAdapter adapter;
            //   connection = Program.f_getConnection();
            var connection = prvCommon.f_GetDBConnection(prvCommon.curDB);

            if (connection == null) return li_rc;

            using (connection)
            {
                string sql = "SELECT l.id , l.name, l.type_id, (select coalesce(c.name,'-') from colors c where c.id=l.color_id) as clr FROM Lines l";
                // Создаем объект DataAdapter 
                var adapter = prvCommon.f_GetDBAdapter(prvCommon.curDB, sql, connection);

                // Создаем объект Dataset
                if (ds == null) ds = new DataSet();
                else ds.Clear();

                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные и настраиваем имена колонок
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["type_id"].Visible = false;
                dataGridView1.Columns["id"].HeaderText = "Код линии";
                dataGridView1.Columns["clr"].HeaderText = "Цвет";
                dataGridView1.Columns["name"].HeaderText = "Название";
            }
            li_rc = 1;
            return li_rc;
        }


 

        private void LinesForm_Load(object sender, EventArgs e)
        {
            //    SQLiteConnection l_con = Program.f_getConnection(); 
            var l_con  = prvCommon.f_GetDBConnection(prvCommon.curDB);
            if (l_con != null)
            { 
                using (l_con)
                {
                    // Создаем объект DataAdapter
                    var l_adapter = prvCommon.f_GetDBAdapter(prvCommon.curDB, "select id, coalesce(name,'-') as clr_name from colors", l_con as DbConnection);
                    DataSet l_ds = new DataSet();       // Создаем объект Dataset
                    l_adapter.Fill(l_ds);               // Заполняем Dataset
                    // Отображаем данные. Зададим источник данных, отображаемое и значимое поле(ValueMember) 
                    SelectLineCombo.DataSource = l_ds.Tables[0]; 
                    SelectLineCombo.DisplayMember = "clr_name";
                    SelectLineCombo.ValueMember = "id";
                }
            }
        }
        private void InitializeContextMenu()
        {   // Это пример создания контекстного меню. Вдруг надо будет    
            // Create the menu item.
            ToolStripMenuItem getAction = new ToolStripMenuItem("Надо что-нить запрогить", null,
                new System.EventHandler(ShortcutMenuClick));
            // Add the menu item to the shortcut menu.
            ContextMenuStrip ActionMenu = new ContextMenuStrip();
            ActionMenu.Items.Add(getAction);

            // Set the shortcut menu for the first column.
            dataGridView1.Columns[1].ContextMenuStrip = ActionMenu;  // цепляем меню к ячейке названия линии
            dataGridView1.MouseDown += new MouseEventHandler(dataGridView1_MouseDown);
        }
        private void ShortcutMenuClick(object sender, System.EventArgs e) {}

        private DataGridViewCell clickedCell;
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            // If the user right-clicks a cell, store it for use by the shortcut menu.
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit = dataGridView1.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    clickedCell = dataGridView1.Rows[hit.RowIndex].Cells[hit.ColumnIndex];
                }
            }
        }
        private void ChangeLine_event(object sender, EventArgs e)
        {
        }
            private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
      //      MessageBox.Show("Вызвано событие DataGridView.CellValueChanged.");
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            { 
                t_id.Text   =  dataGridView1.CurrentRow.Cells[0].Value.ToString(); 
                t_name.Text = (string) dataGridView1.CurrentRow.Cells[1].Value;
             // SelectLineCombo.DataSource.
             // SelectLineCombo.ValueMember = (int)dataGridView1.CurrentRow.Cells[2].Value;
             // SelectLineCombo.DisplayMember = (string)dataGridView1.CurrentRow.Cells[2]. ;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (c_Action != 'N')
            {
                MessageBox.Show("Сохраните или отмените предыдущие изменения");
            }
            else
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    c_Action = 'D';
                    int l_id = 0;
                    bool b_Ok = false;
                    string s_erMsg = String.Empty;
                    // Проверим, что нет станций с данной линией. Иначе БД разъедется
                    l_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    if (l_id < 1) s_erMsg = "Введите id линии";
                    if (l_id > 0)   // id линии есть. проверяем станции
                    {
                        // SQLiteConnection l_con = Program.f_getConnection();
                        var l_con = prvCommon.f_GetDBConnection(prvCommon.curDB);
                        if (l_con != null)
                        {
                            using (l_con)
                            {
                                var cmd = prvCommon.f_GetSQLCommandVar(prvCommon.curDB, l_con);
                                //   SQLiteCommand cmd = new SQLiteCommand(l_con);
                                cmd.CommandText = "select count() from stations where line_id = @l_id";
                                prvCommon.f_AddParm(prvCommon.curDB, cmd, "@l_id", (object)l_id, "int"); //(int)DbType.Int32);
                                                                                                         //    cmd.Parameters.AddWithValue("@l_id", l_id);
                                object cnt = cmd.ExecuteScalar();
                                if (cnt != null && Convert.ToInt32(cnt.ToString()) > 0)
                                    s_erMsg = "Удаление невозможно. Есть станции этой линии. Количество = " + cnt.ToString() + ". Сначала удалите их";
                                else b_Ok = true;
                            }
                        }
                    }
                    if (b_Ok) dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    else
                        if (s_erMsg.Length > 0) MessageBox.Show(s_erMsg);
                }
                else MessageBox.Show("Необходимо выбрать ряд для удаления");
            }
        }

        private char c_Action = 'N';
        private void Insert_Click(object sender, EventArgs e)
        {
            if (c_Action != 'N')
            {
                MessageBox.Show("Сохраните или отмените предыдущие изменения");
            }
            else
            {
                c_Action = 'I';             // устанавливаем режим добавления
                t_id.ReadOnly   = false;    // открываем редактирование
                t_name.ReadOnly = false;
                SelectLineCombo.Enabled = true;
                // НАЙДЕМ ДОПУСТИМЫЙ НОМЕР ЛИНИИ
                //SQLiteConnection l_con = Program.f_getConnection();
                    var l_con = prvCommon.f_GetDBConnection(prvCommon.curDB );
                    using (l_con)
                    {
                    //    SQLiteCommand cmd = new SQLiteCommand(l_con);
                        var cmd = prvCommon.f_GetSQLCommandVar(prvCommon.curDB, l_con);
                        cmd.CommandText = "select count() from Graph where st_from_id = ";
                        object cnt = cmd.ExecuteScalar();
                        if (cnt != null)    t_id.Text = cnt.ToString();
                    }
                t_name.Text = ""; // SelectLineCombo.SelectedValue.ToString() ;
                SelectLineCombo.Text = "";
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int     l_id, l_type_id = 1, l_color_id;
            string  l_name, s_erMsg = String.Empty;
            bool    b_Ok = true;

            l_id = Convert.ToInt32(t_id.Text);
            if (l_id < 1) s_erMsg = "Введите id линии";
            l_name = t_name.Text;
            if (l_name.Length == 0) s_erMsg = "Введите название линии";
            l_color_id = Convert.ToInt32(SelectLineCombo.SelectedValue);
            if (l_color_id == 0) s_erMsg = "Задайте цвет линии";
            if (s_erMsg.Length > 0)
            {
                MessageBox.Show(s_erMsg);
                b_Ok = false;
            }

            if (b_Ok)   // если у нас режим вставки, то проверим значения
            {
                // SQLiteConnection l_con = Program.f_getConnection();
                var l_con = prvCommon.f_GetDBConnection(prvCommon.curDB);
                if (l_con != null)
                {
                    using (l_con)
                    {
                        try
                        {
                            // SQLiteCommand cmd = new SQLiteCommand(l_con);
                            var cmd = prvCommon.f_GetSQLCommandVar(prvCommon.curDB, l_con);
                            if (c_Action == 'I')
                            {
                                cmd.CommandText = "insert into lines(id,type_id,name,color_id, cities_id, status) " +
                                    "Values(@id,@type_id,@name,@color_id, (select max(cities_id) from setup), @status)";
                                prvCommon.f_AddParm(prvCommon.curDB, cmd, "@id", l_id, "int");
                                prvCommon.f_AddParm(prvCommon.curDB, cmd, "@type_id", l_type_id, "int");
                                prvCommon.f_AddParm(prvCommon.curDB, cmd, "@color_id", l_color_id, "int");
                                prvCommon.f_AddParm(prvCommon.curDB, cmd, "@name", l_name, "string");
                                //      prvCommon.f_AddParm(prvCommon.curDB, cmd, "@cities_id", "", "string");
                                prvCommon.f_AddParm(prvCommon.curDB, cmd, "@status", 1, "int");  // предполагаем действующие линии
                                cmd.ExecuteNonQuery();
                            }
                            else if (c_Action == 'D')
                            {
                                cmd.CommandText = "delete from lines where id=@id";
                                prvCommon.f_AddParm(prvCommon.curDB, cmd, "@id", l_id, "int");
                                //cmd.Parameters.AddWithValue("@id", l_id);
                                cmd.ExecuteNonQuery();
                            }
                            else if (c_Action == 'U')
                            {
                                cmd.CommandText = "update lines set color_id = @color_id, name = @name where id=@id";
                                prvCommon.f_AddParm(prvCommon.curDB, cmd, "@id", l_id, "int");
                                prvCommon.f_AddParm(prvCommon.curDB, cmd, "@color_id", l_color_id, "int");
                                prvCommon.f_AddParm(prvCommon.curDB, cmd, "@name", l_name, "string");
                                //cmd.Parameters.AddWithValue("@id", l_id);
                                cmd.ExecuteNonQuery();
                            }
                           }
                        catch (Exception ex)
                        {
                            MessageBox.Show(" Ошибка добавления " + ex.Message);
                        }
                        finally
                        {
                            c_Action = 'N'; // сбрасываем режим
                            SelectLineCombo.Enabled = false;
                            t_id.ReadOnly = true;  // независимо от результата дизейблим конролы редактирования
                            t_name.ReadOnly = true;
                        }
                    }
                    FillData();
                }
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (c_Action != 'N')
            {
                MessageBox.Show("Сохраните или отмените предыдущие изменения");
            }
            else
            {
                c_Action = 'U';             // устанавливаем режим добавления
                t_name.ReadOnly = false;   // открываем редактирование
                SelectLineCombo.Enabled = true;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            c_Action = 'N'; // сбрасываем режим
            SelectLineCombo.Enabled = false;
            t_id.ReadOnly = true;  // независимо от результата дизейблим конролы редактирования
            t_name.ReadOnly = true;
        }
    }
}
