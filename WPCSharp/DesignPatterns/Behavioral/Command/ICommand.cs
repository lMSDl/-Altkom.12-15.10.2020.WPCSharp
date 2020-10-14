﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public interface ICommand
    {
        bool Execute();
        void Undo();
    }
}
