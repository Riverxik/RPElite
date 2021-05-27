using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPElite
{
    class PluginEngine
    {
        public static Market market;
        public static Commander commander;
        public static LogChecker log;

        public static void Init()
        {
            FoodFactory.Init();
            market = new Market();
            commander = new Commander();
            log = new LogChecker();
        }
    }
}
