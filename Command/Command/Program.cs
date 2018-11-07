using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            LightOffCommand lightOffCommand = new LightOffCommand(light);

            SimpleRemoteControl simpleRemoteControl = new SimpleRemoteControl();
            simpleRemoteControl.SetCommand(lightOnCommand);
            simpleRemoteControl.ButtonPress();
            simpleRemoteControl.ButtonUp();
        }
    }
}
