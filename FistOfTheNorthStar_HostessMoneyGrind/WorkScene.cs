using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS4MacroAPI;

namespace PS4MacroScripts
{
    class WorkScene : Scene
    {
        public override string Name => "Hostess_WorkScreen";

        private static RectMap TitleMap = new RectMap()
        {
            X = 503,
            Y = 114,
            Width = 78,
            Height = 18,
            Hash = 236288894927011330
        };

        private static RectMap t1GuestMap = new RectMap()
        {
            X = 479,
            Y = 187,
            Width = 44,
            Height = 47,
            Hash = 18446744071545290752
        };

        private static RectMap t2GuestMap = new RectMap()
        {
            X = 479,
            Y = 334,
            Width = 44,
            Height = 47,
            Hash = 18446743521789476864
        };

        private static RectMap t3GuestMap = new RectMap()
        {
            X = 844,
            Y = 187,
            Width = 44,
            Height = 47,
            Hash = 18446744071293632512
        };

        private static RectMap t4GuestMap = new RectMap()
        {
            X = 844,
            Y = 334,
            Width = 44,
            Height = 47,
            Hash = 18446743521789476864
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(TitleMap, 95);
        }

        private bool guest1served = true;
        private bool guest2served = true;
        private bool guest3served = true;
        private bool guest4served = true;

        public override void OnMatched(ScriptBase script)
        {
            var waitTime = 10;

            // Resetting guest served status if applicable
            if(script.MatchTemplate(t1GuestMap))
                guest1served = false;
            if (script.MatchTemplate(t2GuestMap))
                guest2served = false;
            if (script.MatchTemplate(t3GuestMap))
                guest3served = false;
            if (script.MatchTemplate(t4GuestMap))
                guest4served = false;

            // Cursor defaults at the first girl in the leftmost list, and returns there everytime a customer is served.

            // Table 1
            if (!script.MatchTemplate(t1GuestMap) && !guest1served)
            {
                Logger.Writer("T1!");
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Right", 2, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Left", 3, waitTime, script);
                guest1served = true;
            }

            // Table 2
            if (!script.MatchTemplate(t2GuestMap) && !guest2served)
            {
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("DPad_Down", 1, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Right", 2, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Up", 1, waitTime, script);
                MultiplePresses.Press("DPad_Left", 3, waitTime, script);
                guest2served = true;
            }

            // Table 3
            if (!script.MatchTemplate(t3GuestMap) && !guest3served)
            {
                MultiplePresses.Press("DPad_Left", 1, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Left", 2, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Right", 3, waitTime, script);
                guest3served = true;
            }

            // Table 4
            if (!script.MatchTemplate(t4GuestMap) && !guest4served)
            {
                MultiplePresses.Press("DPad_Left", 1, waitTime, script);
                MultiplePresses.Press("DPad_Down", 1, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Left", 2, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Up", 1, waitTime, script);
                MultiplePresses.Press("DPad_Right", 3, waitTime, script);
                guest4served = true;
            }
        }
    }
}
