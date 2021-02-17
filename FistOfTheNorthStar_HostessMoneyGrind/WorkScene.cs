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
            X = 0,
            Y = 0,
            Width = 0,
            Height = 0,
            Hash = 0
        };

        private static RectMap SalesMap = new RectMap()
        {
            X = 0,
            Y = 0,
            Width = 0,
            Height = 0,
            Hash = 0
        };

        private static RectMap SkillStatsMap = new RectMap()
        {
            X = 0,
            Y = 0,
            Width = 0,
            Height = 0,
            Hash = 0
        };

        private static RectMap t1GuestMap = new RectMap()
        {
            X = 0,
            Y = 0,
            Width = 0,
            Height = 0,
            Hash = 0
        };

        private static RectMap t1GirlMap = new RectMap()
        {
            X = 0,
            Y = 0,
            Width = 0,
            Height = 0,
            Hash = 0
        };

        private static RectMap t2GuestMap = new RectMap()
        {
            X = 0,
            Y = 0,
            Width = 0,
            Height = 0,
            Hash = 0
        };

        private static RectMap t2GirlMap = new RectMap()
        {
            X = 0,
            Y = 0,
            Width = 0,
            Height = 0,
            Hash = 0
        };

        private static RectMap t3GuestMap = new RectMap()
        {
            X = 0,
            Y = 0,
            Width = 0,
            Height = 0,
            Hash = 0
        };

        private static RectMap t3GirlMap = new RectMap()
        {
            X = 0,
            Y = 0,
            Width = 0,
            Height = 0,
            Hash = 0
        };

        private static RectMap t4GuestMap = new RectMap()
        {
            X = 0,
            Y = 0,
            Width = 0,
            Height = 0,
            Hash = 0
        };

        private static RectMap t4GirlMap = new RectMap()
        {
            X = 0,
            Y = 0,
            Width = 0,
            Height = 0,
            Hash = 0
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(TitleMap, 98);
        }

        public override void OnMatched(ScriptBase script)
        {
            var waitTime = 10;
            // Checking if sales and skill is 0 so that the arrow can get in position
            if (script.MatchTemplate(SalesMap, 98) && script.MatchTemplate(SkillStatsMap, 98))
            {
                // RRRN
                MultiplePresses.Press("DPad_Right", 3, waitTime, script);
            }

            // Cursor defaults at the girl right for Table 1 (the one in the upper left), and returns there everytime a placement is filled.

            // Table 1
            if (script.MatchTemplate(t1GuestMap, 98) && !script.MatchTemplate(t1GirlMap, 98))
            {
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Left", 2, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Right", 2, waitTime, script);
            }

            // Table 2
            if (script.MatchTemplate(t2GuestMap, 98) && !script.MatchTemplate(t2GirlMap, 98))
            {
                MultiplePresses.Press("DPad_Down", 1, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Left", 2, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Right", 2, waitTime, script);
                MultiplePresses.Press("DPad_Up", 1, waitTime, script);
            }

            // Table 3
            if (script.MatchTemplate(t3GuestMap, 98) && !script.MatchTemplate(t3GirlMap, 98))
            {
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Right", 2, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Left", 3, waitTime, script);
            }

            // Table 4
            if (script.MatchTemplate(t4GuestMap, 98) && !script.MatchTemplate(t4GirlMap, 98))
            {
                MultiplePresses.Press("DPad_Right", 1, waitTime, script);
                MultiplePresses.Press("DPad_Down", 1, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Right", 2, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script);
                MultiplePresses.Press("DPad_Left", 3, waitTime, script);
                MultiplePresses.Press("DPad_Up", 1, waitTime, script);
            }
        }
    }
}
