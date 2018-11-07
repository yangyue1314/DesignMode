using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class SimpleRemoteControl
    {
        Command command;
        public SimpleRemoteControl() { }
        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ButtonPress()
        {
            command.Execute();
        }

        public void ButtonUp()
        {
            command.Undo();
        }
    }
}
