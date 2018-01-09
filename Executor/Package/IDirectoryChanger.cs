﻿namespace Executor.Package
{
    public interface IDirectoryChanger
    {
        void ChangeCurrentDirectoryRelative(string relativePath);
        void ChangeCurrentDirectoryAbsolute(string absolutePath);

    }
}