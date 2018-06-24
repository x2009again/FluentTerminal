﻿namespace FluentTerminal.Models.Responses
{
    public class CreateTerminalResponse
    {
        public int Id { get; set; }
        public bool Success { get; set; }
        public int Port { get; set; }
        public string Error { get; set; }
        public string ShellExecutableName { get; set; }
        public string PipeName { get; set; }
    }
}