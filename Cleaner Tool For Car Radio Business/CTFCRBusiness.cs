using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Cleaner_Tool_For_Car_Radio_Business
{
    /// <summary>
    /// Implement the business layer.
    /// </summary>
    public abstract class CTFCRBusiness
    {
        #region Attributes
            /// <summary>
            /// Regex for cleaning bad characters.
            /// </summary>
            private static Regex reg = new Regex(@"\W");

            /// <summary>
            /// List of valids extensions for the application.
            /// </summary>
            private static List<string> list_ext = new List<string> { ".mp3", ".wma", ".m4a", ".ogg", ".flac" };

            /// <summary>
            /// Replacement char.
            /// </summary>
            private static string rep = "-";
        #endregion

        #region Methods
            /// <summary>
            /// Assemble and return the destination path.
            /// </summary>
            /// <param name="path_to">string Destination folder.</param>
            /// <param name="file">string File path.</param>
            /// <returns>string Destination folder assembled.</returns>
            public static string GetFullPath(string path_to, string file)
            {
                return path_to + "\\" + CTFCRBusiness.reg.Replace(Path.GetFileNameWithoutExtension(file), CTFCRBusiness.rep) + Path.GetExtension(file).ToLower();
            }

            /// <summary>
            /// Erase the tags of the file.
            /// </summary>
            /// <param name="full_path_to">string Full path of the file.</param>
            public static void EraseTags(string full_path_to)
            {
                TagLib.File tag_of = TagLib.File.Create(full_path_to);

                tag_of.Tag.Album = "";
                tag_of.Tag.AlbumArtists = new string[1];
                tag_of.Tag.Artists = new string[1];
                tag_of.Tag.Comment = "";
                tag_of.Tag.Composers = new string[1];
                tag_of.Tag.Conductor = "";
                tag_of.Tag.Copyright = "";
                tag_of.Tag.Title = "";

                tag_of.Save();
            }

            /// <summary>
            /// Clean properly the tags of the file by bad character replacement.
            /// </summary>
            /// <param name="full_path_to">string Full path of the file.</param>
            public static void CleanTags(string full_path_to)
            {
                TagLib.File tag_of = TagLib.File.Create(full_path_to);

                tag_of.Tag.Album = String.IsNullOrWhiteSpace(tag_of.Tag.Album) ? "" : CTFCRBusiness.reg.Replace(tag_of.Tag.Album, CTFCRBusiness.rep);
                tag_of.Tag.AlbumArtists = new string[1];
                tag_of.Tag.Artists = new string[1];
                tag_of.Tag.Comment = String.IsNullOrWhiteSpace(tag_of.Tag.Comment) ? "" : CTFCRBusiness.reg.Replace(tag_of.Tag.Comment, CTFCRBusiness.rep);
                tag_of.Tag.Composers = new string[1];
                tag_of.Tag.Conductor = String.IsNullOrWhiteSpace(tag_of.Tag.Conductor) ? "" : CTFCRBusiness.reg.Replace(tag_of.Tag.Conductor, CTFCRBusiness.rep);
                tag_of.Tag.Copyright = String.IsNullOrWhiteSpace(tag_of.Tag.Copyright) ? "" : CTFCRBusiness.reg.Replace(tag_of.Tag.Copyright, CTFCRBusiness.rep);
                tag_of.Tag.Title = String.IsNullOrWhiteSpace(tag_of.Tag.Title) ? "" : CTFCRBusiness.reg.Replace(tag_of.Tag.Title, CTFCRBusiness.rep);

                tag_of.Save();
            }

            /// <summary>
            /// Compare the valids extensions list with each file extension.
            /// </summary>
            /// <param name="path_to">string Folder path.</param>
            /// <returns>int The number of valid file into the folder.</returns>
            public static int GetNbValidFileInto(string path_to)
            {
                int cpt = 0;

                foreach (string file in Directory.GetFiles(path_to))
                {
                    if (CTFCRBusiness.list_ext.Contains(Path.GetExtension(file).ToLower()))
                        cpt++;
                }

                if(cpt == 0)
                    throw new NbFileNullException("Aucun fichier valide n'est présent dans le répertoire Source.");

                return cpt;
            }
            
            /// <summary>
            /// Get list of valid files.
            /// </summary>
            /// <param name="path_to">string Folder path.</param>
            /// <returns>List<string> List of files into the folder.</returns>
            public static List<string> GetValidFileInto(string path_to)
            {
                List<string> list_files = new List<string>();

                foreach (string file in Directory.GetFiles(path_to))
                {
                    if (CTFCRBusiness.list_ext.Contains(Path.GetExtension(file).ToLower()))
                        list_files.Add(file);
                }

                return list_files;
            }

            /// <summary>
            /// Copy the file.
            /// </summary>
            /// <param name="path_file">string Source file.</param>
            /// <param name="full_path_to">string Destination file.</param>
            /// <param name="error">out string Error parameter.</param>
            public static void Copy(string path_file, string full_path_to, out string error)
            {
                error = "";

                if (File.Exists(full_path_to))
                    error = "FILE_ALREADY_EXIST";
                else
                    CTFCRBusiness.Copy(path_file, full_path_to);
            }
            
            /// <summary>
            /// Copy the file. [Overload]
            /// </summary>
            /// <param name="path_file">string Source file.</param>
            /// <param name="full_path_to">string Destination file.</param>
            public static void Copy(string path_file, string full_path_to)
            {
                File.Copy(path_file, full_path_to, true);
            }
        #endregion
    }
}
