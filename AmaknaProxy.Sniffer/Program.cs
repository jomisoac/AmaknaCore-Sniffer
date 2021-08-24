using AmaknaProxy.API.Managers;
using AmaknaProxy.API.Protocol;
using AmaknaProxy.API.Utils.Logger;
using AmaknaProxy.Engine.Managers;
using AmaknaProxy.Engine.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmaknaProxy.Sniffer
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (System.Diagnostics.Process.GetProcessesByName("AmaknaProxy.Sniffer").Length > 1)
                return;
            WindowManager.Init(new MainForm());
            Application.Run(((MainForm)WindowManager.MainWindow));
        }

        public static void LoadProgram(ContainerLogger logger)
        {
            int time = Environment.TickCount;

            ConsoleManager.InitLogger(logger);
            logger.Info("#Comenzando la solución ...");

            if (!ConfigurationManager.IsFileExists() || ConfigurationManager.GetEntryByName("GamePath") == null)
            {
                logger.Warning("No se encontró ningún archivo de configuración.");

                ConfigurationManager.SerializeConfig();

                Application.Run(new PathForm());

                if (ConfigurationManager.GetEntryByName("GamePath") == null)
                {
                    System.Environment.Exit(1);
                    return;
                }

                logger.Debug("Configuración definida.");
            }
            else
            {
                ConfigurationManager.DeserializeConfig();
                logger.Debug("Se cargó el archivo de configuración.");
            }

            ProtocolTypeManager.Initialize();
            MessageReceiver.Initialize();

            try
            {
                NetworkManager.StartServers();
                logger.Debug("Servidores iniciados.");
            }
            catch (Exception ex)
            {
                logger.Error("[SERVERS] " + ex.Message);
                logger.Error("SERVERS - OFF");
            }

            logger.Debug(string.Format("{0}ms", Environment.TickCount - time));

            OnProgramLoaded(null);
        }

        #region Events

        public static event EventHandler<ProgramLoadedEventArgs> ProgramLoaded;

        private static void OnProgramLoaded(ProgramLoadedEventArgs e)
        {
            if (ProgramLoaded != null)
                ProgramLoaded(null, e);
        }

        public class ProgramLoadedEventArgs : EventArgs
        { }

        #endregion
    }
}
