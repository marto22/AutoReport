using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoReports
{
    class ConstantesApp
    {
        System.Windows.Forms.RadioButton[] ArrayRadioButtonsConexiones = new System.Windows.Forms.RadioButton[3];

        public const String nombreDeLaConsultaARealizarRadioBut1 = "Weekly_Report";
        public const String nombreDelArchivoDeLaConsulta1 = "Weekly Report_LastVersion.sql";
        public const String duracionRb1 = "01:25:00";

        public const String nombreDeLaConsultaARealizarRadioBut2 = "Products";
        public const String nombreDelArchivoDeLaConsulta2 = "Export Products - UPDATED.sql";
        public const String duracionRb2 = "00:05:00";

        public const String nombreDeLaConsultaARealizarRadioBut3 = "Rules_Affects_To";
        public const String nombreDelArchivoDeLaConsulta3 = "DSM-494 Rules_Affects to (Case).sql";
        public const String duracionRb3 = "00:01:00";

        public const String nombreDeLaConsultaARealizarRadioBut4 = "Rules_Applies_To";
        public const String nombreDelArchivoDeLaConsulta4 = "DSM-494 Rules_AppliesTo.sql";
        public const String duracionRb4 = "00:01:00";

        public const String nombreDeLaConsultaARealizarRadioBut5 = "BackUpLogTrace_xxx_17";
        public const String nombreDelArchivoDeLaConsulta5 = "LogTraceBackup.sql";
        public const String duracionRb5 = "00:01:00";



        public const string ConnectionLocal =   "Data Source=BCN-MMAGALLANES\\SQLEXPRESS;" +
                                                   "Initial Catalog=GSB_CPQ_DEV;" +
                                                   "Integrated Security=SSPI;";

        public const string ConnectionITG =     "Data Source=dra-itg.glb.itcs.hpicorp.net;" +
                                                 "Initial Catalog=dra_itg;" +
                                                 "Integrated Security=SSPI;";

        public const string ConnectionProd =     "Data Source=drakkar-pro.glb.itcs.hpicorp.net;" +
                                                 "Initial Catalog=drakkar_pro;" +
                                                 "Integrated Security=SSPI;";


    }
}
