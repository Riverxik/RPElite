using Newtonsoft.Json.Linq;

namespace RPElite
{
    class EventLogger
    {
        public static string GetPrettyLog(string rawEntry)
        {
            JObject obj = JObject.Parse(rawEntry);
            switch (obj.Value<string>("event"))
            {
                // Travel events.
                // Docking.
                case "Docked": return DoDocked(obj);
                case "DockingCancelled": return DoDockingCancelled(obj);
                case "DockingDenied": return DoDockingDenied(obj);
                case "DockingGranted": return DoDockingGranted(obj);
                case "DockingRequested": return DoDockingRequested(obj);
                case "DockingTimeout": return DoDockingTimeout(obj);
                // FSD
                case "FSDJump": return DoFSDJump(obj);
                case "FSDTarget": return DoFSDTarget(obj);
                case "StartJump": return DoStartJump(obj);
                case "SupercruiseEntry": return DoSupercruiseEntry(obj);
                case "SupercruiseExit": return DoSupercruiseExit(obj);
                // Landing, liftoff
                case "Liftoff": return DoLiftoff(obj);
                case "Touchdown": return DoTouchdown(obj);
                case "Undocked": return DoUndocked(obj);
                default: return "Undefined: " + rawEntry;
            }
        }

        private static string DoDocked(JObject obj)
        {
            string stationName = obj.Value<string>("StationName");
            string starSystem = obj.Value<string>("StarSystem");
            double distFromStar = obj.Value<double>("DistFromStarLS");
            return string.Format("-> Пристыкован к [{0}] [{1}] ({2:0.00} св.с.)", starSystem, stationName, distFromStar);
        }

        private static string DoDockingCancelled(JObject obj)
        {
            string stationName = obj.Value<string>("StationName");
            return string.Format("-> Стыковка к [{0}] отменена", stationName);
        }

        private static string DoDockingDenied(JObject obj)
        {
            string stationName = obj.Value<string>("StationName");
            string reason = obj.Value<string>("Reason");
            string res = string.Format("-> Разрешение на стыковку к [{0}] отклонено. ", stationName);
            switch (reason)
            {
                case "NoSpace": res += "Причина: Нет свободных площадок."; break;
                case "TooLarge": res += "Причина: Нет площадок нужного размера."; break;
                case "Hostile": res += "Причина: Враждебный корабль."; break;
                case "Offences": res += "Причина: Обнаружены правонарушения."; break;
                case "Distance": res += "Причина: Корабль далеко от станции."; break;
                case "ActiveFighter": res += "Причина: Выпущен истребитель."; break;
                default: break;
            }
            return res;
        }

        private static string DoDockingGranted(JObject obj)
        {
            // StationType, MarketID
            string stationName = obj.Value<string>("StationName");
            string landingPad = obj.Value<string>("LandingPad");
            return string.Format("-> Стыковка к [{0}] разрешена. Посадочная площадка: {1}", stationName, landingPad);
        }

        private static string DoDockingRequested(JObject obj)
        {
            string stationName = obj.Value<string>("StationName");
            return string.Format("-> Запрос разрешения на стыковку с [{0}]", stationName);
        }

        private static string DoDockingTimeout(JObject obj)
        {
            string stationName = obj.Value<string>("StationName");
            return string.Format("-> Истекло время разрешения на стыковку с [{0}]", stationName);
        }

        private static string DoFSDJump(JObject obj)
        {
            string starSystem = obj.Value<string>("StarSystem");
            double jumpDist = obj.Value<double>("JumpDist");
            return string.Format("-> Прыжок в [{0}] ({1:0.00} св.л.)", starSystem, jumpDist);
        }

        private static string DoFSDTarget(JObject obj)
        {
            string starSystem = obj.Value<string>("Name");
            string starClass = obj.Value<string>("StarClass");
            int jumps = obj.Value<int>("RemainingJumpsInRoute");
            return string.Format("-> Новая цель: [{0}]({1}), осталось прыжков: {2}", starSystem, starClass, jumps);
        }

        private static string DoStartJump(JObject obj)
        {
            return string.Format("-> Зарядка ФСД");
        }

        private static string DoSupercruiseEntry(JObject obj)
        {
            string starSystem = obj.Value<string>("StarSystem");
            return string.Format("-> Выход в суперкруиз [{0}]", starSystem);
        }

        private static string DoSupercruiseExit(JObject obj)
        {
            string starSystem = obj.Value<string>("StarSystem");
            string body = obj.Value<string>("Body");
            return string.Format("-> Выход из суперкруиза [{0}][{1}]", starSystem, body);
        }

        private static string DoLiftoff(JObject obj)
        {
            double latitude = obj.Value<double>("Latitude");
            double longitude = obj.Value<double>("Longitude");
            string starSystem = obj.Value<string>("StarSystem");
            string body = obj.Value<string>("Body");
            // OnStation, OnPlanet, NearesDestination, PlayerControlled
            return string.Format("-> Взлёт с [{0}][{1}], ({2:0.00};{3:0.00})", body, starSystem, latitude, longitude);
        }

        private static string DoTouchdown(JObject obj)
        {
            double latitude = obj.Value<double>("Latitude");
            double longitude = obj.Value<double>("Longitude");
            string starSystem = obj.Value<string>("StarSystem");
            string body = obj.Value<string>("Body");
            // OnStation, OnPlanet, NearesDestination, PlayerControlled
            return string.Format("-> Посадка на [{0}][{1}], ({2:0.00};{3:0.00})", body, starSystem, latitude, longitude);
        }

        private static string DoUndocked(JObject obj)
        {
            string stationName = obj.Value<string>("StationName");
            return string.Format("-> Расстыковка с [{0}]", stationName);
        }
    }
}
