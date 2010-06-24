using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using FocusAnchor.Properties;

namespace FocusAnchor
{
    static class Program
    {
        private static HoverForm hoverForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( )
        {        
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );

            hoverForm = new HoverForm( );
            Application.Run( hoverForm );
        }

        public static void Quit( )
        {
            Settings.Default.Save( );
            Application.Exit( );
        }

        /************************************************************************/
        /*                      TASK MANAGEMENT                                 */
        /************************************************************************/

        public static void NextAction( )
        {
            if ( Settings.Default.NextActions.Count == 0 )
                Settings.Default.CurrentTask = "";
            else
            {
                Settings.Default.CurrentTask = Settings.Default.NextActions[0];
                Settings.Default.NextActions.RemoveAt( 0 );
            }
        }

        public static void UpdateSettings()
        {
            Settings.Default.Save( );
            hoverForm.UpdateDisplay( );            
        }

        public static void ClearAction( )
        {
            Settings.Default.CurrentTask = "";
            UpdateSettings( );
        }

        public static void PromptForAction( )
        {
            Settings.Default.CurrentTask = new SetActionForm( ).ShowMainDialog( );
            UpdateSettings( );
        }

        public static void EnqueueAction( )
        {
            Settings.Default.NextActions.Add( new SetActionForm( ).ShowQueueDialog( ) );
            UpdateSettings( );
        }

        public static void PromptForActionList( )
        {
            new ToDoListForm( ).ShowDialog( );
            UpdateSettings( );
        }

    }
}
