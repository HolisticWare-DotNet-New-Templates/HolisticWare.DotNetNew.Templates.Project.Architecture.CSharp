
Task("nuget-structure-analysis")
.Does
    (
        () =>
        {
            string path = "./output/*.nupkg";
            FilePathCollection files_configs = GetFiles(path);
            foreach(FilePath f in files_configs)
            {
                Information($"File  = {f}");
                string d_zip = $"{f.ToString().Replace(".nupkg", "")}";
                if (DirectoryExists(d_zip))
                {
                    DeleteDirectory
                            (
                                d_zip,
                                new DeleteDirectorySettings
                                {
                                    Recursive = true,
                                    Force = true
                                }
                            );
                }
                Unzip($"{f}", d_zip);

                IEnumerable<string> redirected_std_out;
                IEnumerable<string> redirected_std_err;
                int exit_code =
                                StartProcess
                                    (
                                        "tree",
                                        new ProcessSettings
                                        {
                                            Arguments = $"-H {f.ToString().Replace(".nupkg", "")}",
                                            // WorkingDirectory = "./"
                                            RedirectStandardOutput = true,
                                            RedirectStandardError = true
                                        },
                                        out redirected_std_out,
                                        out redirected_std_err
                                    );

                System.IO.File.WriteAllLines
                                    (
                                        $"{f.ToString().Replace(".nupkg", ".md")}",
                                        redirected_std_out.ToArray()
                                    );
            }
        }
    );
