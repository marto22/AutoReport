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
        public const String nombreDeLaConsultaARealizarRadioBut2 = "Products";
        public const String nombreDeLaConsultaARealizarRadioBut3 = "Rules_Affects_To";
        public const String nombreDeLaConsultaARealizarRadioBut4 = "Rules_Applies_To";
        public const String nombreDeLaConsultaARealizarRadioBut5 = "BackUpLogTrace_xxx_17"; 


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
