﻿namespace ICanHasDotnetCore.SourcePackageFileReaders
{
    public class SourcePackageFile
    {
        public SourcePackageFile(string name, string originalFileName, byte[] contents)
        {
            Name = name;
            OriginalFileName = originalFileName;
            Contents = contents;
        }

        public string Name { get; set; }
        public string OriginalFileName { get;  }
        public byte[] Contents { get; }
    }
}