﻿using System;
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
                return;

            Settings.Default.CurrentTask = Settings.Default.NextActions[0];
            Settings.Default.NextActions.RemoveAt( 0 );
            hoverForm.UpdateDisplay( );
            Settings.Default.Save( );
        }

        public static void ClearAction( )
        {
            Settings.Default.CurrentTask = "";
            hoverForm.UpdateDisplay( );
            Settings.Default.Save( );
        }

        public static void PromptForAction( )
        {
            Settings.Default.CurrentTask = new SetActionForm( ).ShowMainDialog( );
            hoverForm.UpdateDisplay( );
            Settings.Default.Save( );
        }

        public static void EnqueueAction( )
        {
            Settings.Default.NextActions.Add( new SetActionForm( ).ShowQueueDialog( ) );
            hoverForm.UpdateDisplay( );
            Settings.Default.Save( );
        }

        public static void PromptForActionList( )
        {
            new ToDoListForm( ).ShowDialog( );
            hoverForm.UpdateDisplay( );
            Settings.Default.Save( );
        }

    }
}
