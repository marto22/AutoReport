using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace AutoReports
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private SqlConnection connection;
        private DateTime tiempoInicioDeConsulta;
        private String DatetimeFile;
        private String nombreDeLaConsultaARealizar;


        string connectionString = "Data Source=drakkar-pro.glb.itcs.hpicorp.net;" +
                                   "Initial Catalog=drakkar_pro;" +
                                   "Integrated Security=SSPI;";

      /*        //connectionString LOCAL
        String connectionString = "Data Source=BCN-MMAGALLANES\\SQLEXPRESS;" +
                                          "Initial Catalog=GSB_CPQ_DEV;" +
                                          "Integrated Security=SSPI;";
      */
        String Query = "Select * FROM products";

        public Form1()
        {
            InitializeComponent();
            this.Show();
        }




        private void RealizarConsultaYExportar(String Filename)
        {
            toolStripProgressBar1.Value = 20;
            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "Weekly_Report";
                Query = QueryTextBox.Text;
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dt);

                XLWorkbook wb = new XLWorkbook();

                // Add a DataTable as a worksheet
                wb.Worksheets.Add(dt);
                DatetimeFile = DateTime.Now.ToString("yyyyMMddHHmmss");
                wb.SaveAs("c:\\temp\\" + Filename + "_" + DatetimeFile + ".xlsx");

                StatusLabel1.Text = "Consulta " + nombreDeLaConsultaARealizar + " realizada correctamente.";
                StatusLabel1.ForeColor = Color.Green;
                toolStripProgressBar1.Value = 100;
            }
            catch (Exception ex)
            {
                StatusLabel1.Text = ex.Message;
                StatusLabel1.ForeColor = Color.Red;
                toolStripProgressBar1.Value = 0;
            }

        }

        private async void RealizarConsultaYExportarAsync(String Filename)
        {
            SqlCommand command =new SqlCommand();
            toolStripProgressBar1.Value = 40;
            Query = QueryTextBox.Text;
            StatusLabel1.Text = "Realizando la consulta...";
            String flagError = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            connection = await Task.Run(() =>   // TaskEx.Run in the CTP
            {
                var sql = new SqlConnection();
                sql.ConnectionString = connectionString;
                
                try
                {
                    DataTable dt = new DataTable();
                    dt.TableName = "Weekly_Report";
                    
                    command = new SqlCommand(Query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    command.CommandTimeout = 5000;
                    dataAdapter.Fill(dt);

                    XLWorkbook wb = new XLWorkbook();

                    // Add a DataTable as a worksheet
                    wb.Worksheets.Add(dt);
                    DatetimeFile = DateTime.Now.ToString("yyyyMMddHHmmss");
                    wb.SaveAs("c:\\temp\\" + Filename + "_" + DatetimeFile + ".xlsx");



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "---> SQL Timeout: " + command.CommandTimeout);
                }

                return sql;
            });
            if (flagError != "")
            {
                 StatusLabel1.Text = flagError;
                 StatusLabel1.ForeColor = Color.Red;
                 toolStripProgressBar1.Value = 0;
            }
            else
            {
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                TimeSpan ts = TimeSpan.FromMilliseconds(elapsedMs);
                string t = string.Format("{0:D2}h:{1:D2}m:{2:D2}s", ts.Hours, ts.Minutes, ts.Seconds);

                StatusLabel1.Text = "Consulta " + nombreDeLaConsultaARealizar + " realizada correctamente en " + t + "." ;
                StatusLabel1.ForeColor = Color.Green;
                toolStripProgressBar1.Value = 100;
                System.Diagnostics.Process.Start(@"c:\temp");
            }

            /*

            try
            {

            }
            catch (Exception ex)
            {

            }
            */
        }



        private async void Form1_Load(object sender, EventArgs e)
        {
            CambiarConnectionStringPorRadiobuttons();
            ComprobarConexion();
        }

        private async void ComprobarConexion()
        {
            //DESHABILITO LOS RB
            System.Windows.Forms.RadioButton[] radioButtons =  {radioButtonITG,radioButtonLocal, radioButtonProd};
            for (int i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i].Enabled = false;
            }
            toolStripSplitButton1.Enabled = false;
            StatusLabel1.Text = "Conectando con el servidor... ";
            StatusLabel1.ForeColor = Color.Black;

            toolStripProgressBar1.Value = 20;
            connection = await Task.Run(() =>   // TaskEx.Run in the CTP
            {
                var sql = new SqlConnection();
                sql.ConnectionString = connectionString;
                
                try
                {
                    if(sql.State != ConnectionState.Open)
                    sql.Open();
                    
                }
                catch (Exception ex)
                {

                }
                
                return sql;
            });

            //HABILITO LOS RD Y EL SPLITBUT UNA VEZ TERMINADA LA CONSULTA
            for (int i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i].Enabled = true;
            }
            toolStripSplitButton1.Enabled = true;

            if (connection.State == ConnectionState.Open)
            {
                StatusLabel1.ForeColor = Color.Green;
                StatusLabel1.Text = connection.State.ToString() + " --> " + connection.DataSource + " --> " + connection.Database + " --> " + connection.Credential;
                toolStripProgressBar1.Value = 100;                
            }
            else
            {
                StatusLabel1.ForeColor = Color.Red;
                StatusLabel1.Text = connection.State.ToString() + " / " + connection.DataSource + " / " + connection.Database + " / " + connection.Credential;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.BackColor = Color.Red;
            }

        }
        
        private async void comprobarConexionconCancel()
        {
            var ts = new CancellationTokenSource();
            CancellationToken ct = ts.Token;
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    // do some heavy work here
                    Thread.Sleep(100);
                    if (ct.IsCancellationRequested)
                    {
                        // another thread decided to cancel
                        Console.WriteLine("task canceled");
                        break;
                    }
                }
            }, ct);

            // Simulate waiting 3s for the task to complete
            Thread.Sleep(3000);

            // Can't wait anymore => cancel this task 
            ts.Cancel();
            Console.ReadLine();

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 20;
            ComprobarConexion();

        }

        private void CambiarConnectionStringPorRadiobuttons()
        {
            if (radioButtonLocal.Checked == true)
            {
                connectionString = ConstantesApp.ConnectionLocal;
            }
            else if (radioButtonITG.Checked == true)
            {
                connectionString = ConstantesApp.ConnectionITG;
            }
            else if (radioButtonProd .Checked == true)
            {
                connectionString = ConstantesApp.ConnectionProd;
            }
            else{
                connectionString = ConstantesApp.ConnectionProd;
            }
        }


        //BORRAR ESTOS EVENTOS:
        private void Ejecutarbutton1_Click(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }
        //------------


        private void Cargarbutton1_Click(object sender, EventArgs e)
        {

        }

        //EVENTO QUE TIENEN TODOS LOS RADIOBUT DE CONEXIÓN AL SERVIDOR DB
        private void radioButtonProd_CheckedChanged(object sender, EventArgs e)
        {
            CambiarConnectionStringPorRadiobuttons();
            ComprobarConexion();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ComprobarConsultaSeleccionadaPorRadioBut();
        }

        private void ComprobarConsultaSeleccionadaPorRadioBut()
        {
            string PathDelScript = "";
            metroDateTime1.Enabled = false;

            if (metroRadioButton1.Checked == true)
            {
                nombreDeLaConsultaARealizar = ConstantesApp.nombreDeLaConsultaARealizarRadioBut1;
                PathDelScript = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Scripts\Weekly Report_LastVersion.sql";
            }
            else if (metroRadioButton2.Checked == true)
            {
                nombreDeLaConsultaARealizar = ConstantesApp.nombreDeLaConsultaARealizarRadioBut2;
                PathDelScript = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Scripts\Export Products - UPDATED.sql";
            }
            else if (metroRadioButton3.Checked == true)
            {
                nombreDeLaConsultaARealizar = ConstantesApp.nombreDeLaConsultaARealizarRadioBut3;
                PathDelScript = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Scripts\DSM-494 Rules_Affects to (Case).sql";
            }
            else if (metroRadioButton4.Checked == true)
            {
                nombreDeLaConsultaARealizar = ConstantesApp.nombreDeLaConsultaARealizarRadioBut4;
                PathDelScript = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Scripts\DSM-494 Rules_AppliesTo.sql";
            }
            else if (metroRadioButton5.Checked == true)
            {
                metroDateTime1.Enabled = true;
                nombreDeLaConsultaARealizar = ConstantesApp.nombreDeLaConsultaARealizarRadioBut5;
                PathDelScript = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Scripts\LogTraceBackup.sql";
            }
            else
            {
                nombreDeLaConsultaARealizar = "Query";
            }


            if (PathDelScript != "")
            {
                QueryTextBox.Text = System.IO.File.ReadAllText(PathDelScript);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
            { 
            connection.Close();
            }
            StatusLabel1.Text = "Conexión terminada con el servidor.";
            StatusLabel1.ForeColor = Color.Black;
            toolStripProgressBar1.Value = 0;

        }

        private void guardarButton1_Click(object sender, EventArgs e)
        {
        }

        //DatePicker Change Value
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ComprobarConsultaSeleccionadaPorRadioBut();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            ComprobarConsultaSeleccionadaPorRadioBut(); //

            DateTime date = metroDateTime1.Value;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            //AQUI LO SUYO SERÍA HACER UN BETWEEN
            StringBuilder builder = new StringBuilder(QueryTextBox.Text);
            builder.Replace("fecha", metroDateTime1.Value.ToString("yyyy-MM") + "-" + firstDayOfMonth + "'");
            builder.Replace("fecha", metroDateTime1.Value.ToString("yyyy-MM") + "-" + firstDayOfMonth + "'");

            // StringBuilder builder = new StringBuilder(QueryTextBox.Text);
            // builder.Replace("fecha'", dateTimePicker1.Value.ToString("yyyy-MM")+"-01'");

            string y = builder.ToString();
            QueryTextBox.Text = y;
        }

        private void metroButtonEjecutar_Click(object sender, EventArgs e)
        {
            //PARA CONSULTAS QUE REALIZAN MODIFICACIONES EN LA TABLA SE PIDE CONFIRMACIÓN
            if (metroRadioButton5.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estás seguro? Esta consulta realiza un DELETE de las filas anteriores al mes seleccionado y exportará las posteriores. ¡Revisalo!", "¡Mira donde pisas!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarConsultaYExportarAsync(nombreDeLaConsultaARealizar);
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            //PARA TODAS LAS DEMÁS CONSULTAS
            else
            {
                //ComprobarConsultaSeleccionadaPorRadioBut();
                RealizarConsultaYExportarAsync(nombreDeLaConsultaARealizar);
            }

        }

        private void metroButtonCargar_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            QueryTextBox.Text = System.IO.File.ReadAllText(dlg.FileName);
        }

        private void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Estás seguro que quieres Guardar este script para el Reporte " + nombreDeLaConsultaARealizar + "?");
        }
    }
}


