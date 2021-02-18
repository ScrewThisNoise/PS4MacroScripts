using PS4MacroAPI;

namespace PS4MacroScripts
{
    public static class MultiplePresses
    {
        public static void Press(string keytopress, int TimesPress, int waiter, ScriptBase script)
        {
            keytopress = keytopress.ToLower();
            while (TimesPress > 0)
            {
                switch (keytopress)
                {
                    case "cross":
                        script.Press(new DualShockState() { Cross = true });
                        break;
                    case "circle":
                        script.Press(new DualShockState() { Circle = true });
                        break;
                    case "dpad_right":
                        script.Press(new DualShockState() { DPad_Right = true });
                        break;
                    case "dpad_left":
                        script.Press(new DualShockState() { DPad_Left = true });
                        break;
                    case "dpad_down":
                        script.Press(new DualShockState() { DPad_Down = true });
                        break;
                    case "dpad_up":
                        script.Press(new DualShockState() { DPad_Up = true });
                        break;
                }
                script.Sleep(waiter);
                TimesPress--;
            }
        }
    }
}
