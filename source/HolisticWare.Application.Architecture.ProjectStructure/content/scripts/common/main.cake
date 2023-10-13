// #addin nuget:?package=System.Threading.Tasks&version=4.3.0
using System.Collections.Concurrent;

//---------------------------------------------------------------------------------------
Task ("clean")
    .Does
    (
        () =>
        {
            RunTarget("clean-folders");
            RunTarget("clean-files");
        }
    );

Task ("clean-folders")
    .Does
    (
        () =>
        {
            ConcurrentDictionary<string, DirectoryPathCollection> directories = new();

            Parallel.ForEach
                        (
                            clean_folder_patterns,
                            folder_pattern =>
                            {
                                directories[folder_pattern] = GetDirectories(folder_pattern);
                            }
                        );

            Parallel.ForEach
                        (
                            directories.Values,
                            directory_path_collection =>
                            {
                                Parallel.ForEach
                                            (
                                                directory_path_collection,
                                                directory_path =>
                                                {
                                                    Information($"      Directory: {directory_path}");

                                                    if (DirectoryExists (directory_path))
                                                    {
                                                        DeleteDirectory
                                                                    (
                                                                        directory_path,
                                                                        new DeleteDirectorySettings
                                                                        {
                                                                            Recursive = true,
                                                                            Force = true
                                                                        }
                                                                    );
                                                    }
                                                }
                                            );
                            }
                        );
    
            return;
         }
   );

Task ("clean-files")
    .Does
    (
        () =>
        {
            ConcurrentDictionary<string, FilePathCollection> files = new();

            Parallel.ForEach
                        (
                            clean_file_patterns,
                            file_pattern =>
                            {
                                files[file_pattern] = GetFiles(file_pattern);
                            }
                        );

            Parallel.ForEach
                        (
                            files.Values,
                            file_path_collection =>
                            {
                                Parallel.ForEach
                                            (
                                                file_path_collection,
                                                file_path =>
                                                {
                                                    Information($"      File: {file_path}");

                                                    if (FileExists (file_path))
                                                    {
                                                        DeleteFile(file_path);
                                                    }
                                                }
                                            );
                            }
                        );

            return;
        }
    );
//---------------------------------------------------------------------------------------

