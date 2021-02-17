using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS4MacroAPI;

namespace PS4MacroScripts
{
    class ChooseCast : Scene
    {
        public override string Name => "Hostess_CastScreen";

        private static RectMap menuTiltleMap = new RectMap()
        {
            X = 247,
            Y = 137,
            Width = 113,
            Height = 20,
            Hash = 8583335366327808
        };

        private static RectMap HinaMap = new RectMap()
        {
            X = 89,
            Y = 203,
            Width = 91,
            Height = 88,
            Hash = 2544323545946378063
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(menuTiltleMap, 98);
        }

        public override void OnMatched(ScriptBase script)
        {
            var waitTime = 500;
            if (script.MatchTemplate(HinaMap, 98))
            {
                MultiplePresses.Press("Cross", 1, waitTime, script); // Selected Hina
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script);
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script); // Selected Emma
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script);
                MultiplePresses.Press("DPad_Right", 2, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script); // Selected Liz
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("DPad_Down", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script);
                MultiplePresses.Press("DPad_Right", 3, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script); // Selected Bright
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script);
                MultiplePresses.Press("DPad_Down", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script); // Selected Rena
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script);
                MultiplePresses.Press("DPad_Down", 1, waitTime, script);
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script); // Selected Sabrina
            }
            else
            {
                MultiplePresses.Press("DPad_Down", 1, waitTime, script);
                MultiplePresses.Press("DPad_Right", 2, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script); // Selected Jacqueline
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script);
                MultiplePresses.Press("DPad_Down", 1, waitTime, script);
                MultiplePresses.Press("DPad_Right", 3, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script); // Selected Susan
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script);
                MultiplePresses.Press("DPad_Down", 2, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script); // Selected Miriam
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("DPad_Down", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script);
                MultiplePresses.Press("DPad_Down", 2, waitTime, script);
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script); // Selected Fan
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script);
                MultiplePresses.Press("DPad_Down", 2, waitTime, script);
                MultiplePresses.Press("DPad_Right", 2, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script); // Selected Jordan
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script);
                MultiplePresses.Press("DPad_Down", 2, waitTime, script);
                MultiplePresses.Press("DPad_Right", 3, waitTime, script);
                MultiplePresses.Press("Cross", 1, waitTime, script); // Selected Jordan
            }

            // Done! Returning to Main Menu!
            MultiplePresses.Press("Circle", 1, waitTime, script);
        }
    }
}
