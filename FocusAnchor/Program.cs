using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace FocusAnchor
{
    static class Program
    {
        public static string currentAction = "click to set action...";
        public static Queue<string> nextActions = new Queue<string>( );

        private static HoverForm hoverForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( )
        {
            RestoreFromFile( );
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );

            hoverForm = new HoverForm( );
            Application.Run( hoverForm );
        }

        public static void Quit( )
        {
            Application.Exit( );
        }

        //=======================================================================//

        public static void NextAction( )
        {
            currentAction = nextActions.Dequeue( );
            hoverForm.UpdateDisplay( );
            SaveToFile( );
        }
        
        public static void ClearAction( )
        {
            currentAction = "";
            hoverForm.UpdateDisplay( );
            SaveToFile( );
        }

        public static void PromptForAction( )
        {
            currentAction = new SetActionForm( ).ShowMainDialog( );
            hoverForm.UpdateDisplay( );
            SaveToFile( );
        }

        public static void EnqueueAction( )
        {
            nextActions.Enqueue( new SetActionForm( ).ShowQueueDialog( ) );
            hoverForm.UpdateDisplay( );
            SaveToFile( );
        }


        public static void PromptForActionList( )
        {
            new ToDoListForm( ).ShowDialog( );
            hoverForm.UpdateDisplay( );
            SaveToFile( );
        }

        //=======================================================================//

        private const string DATA_FILE_NAME = "data.dat";
        private static void RestoreFromFile( )
        {
            if ( !File.Exists( DATA_FILE_NAME ) )
                return;

            BinaryReader reader = new BinaryReader( new FileStream( DATA_FILE_NAME, FileMode.Open ) );
            currentAction = reader.ReadString( );
            for ( long i = 0, num = reader.ReadInt64( ); i < num; i++ )
                nextActions.Enqueue( reader.ReadString( ) );
            reader.Close( );
        }

        private static void SaveToFile( )
        {
            BinaryWriter writer = new BinaryWriter( new FileStream( DATA_FILE_NAME, FileMode.Create ) );
            writer.Write( currentAction );
            writer.Write( (Int64) nextActions.Count );
            foreach ( String action in nextActions )
                writer.Write( action );
            writer.Close( );
        }




    }
}
