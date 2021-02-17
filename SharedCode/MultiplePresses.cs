using PS4MacroAPI;

namespace PS4MacroScripts
{
    public static class MultiplePresses
    {
        public static void Press(string keytopress, int TimesPress, int waiter, ScriptBase script)
        {
            while (TimesPress > 0)
            {
                switch (keytopress)
                {
                    case "Cross":
                        script.Press(new DualShockState() { Cross = true });
                        break;
                    case "Circle":
                        script.Press(new DualShockState() { Circle = true });
                        break;
                    case "DPad_Right":
                        script.Press(new DualShockState() { DPad_Right = true });
                        break;
                    case "DPad_Left":
                        script.Press(new DualShockState() { DPad_Left = true });
                        break;
                    case "DPad_Down":
                        script.Press(new DualShockState() { DPad_Down = true });
                        break;
                    case "DPad_Up":
                        script.Press(new DualShockState() { DPad_Up = true });
                        break;
                }


                script.Sleep(waiter);
                TimesPress--;
            }
        }
    }
}
