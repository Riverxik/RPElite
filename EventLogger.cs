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
                // Game start.
                case "Commander": return DoCommander(obj);
                case "Materials": return DoMaterials(obj);
                case "ShipLockerMaterials": return DoShipLockerMaterials(obj);
                case "Rank": return DoRank(obj);
                case "LoadGame": return DoLoadGame(obj);
                case "Location": return DoLocation(obj);
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
                // Chat.
                case "ReceiveText": return DoReceiveText(obj);
                default: return "Undefined: " + rawEntry;
            }
        }

        private static string DoCommander(JObject obj)
        {
            string name = obj.Value<string>("Name");
            return string.Format("<-- Загрузка интерфейса -->\r\n<-- Пилот: {0} -->", name);
        }

        private static string DoMaterials(JObject obj)
        {
            return "<-- Считывание информации о материалах -->";
        }

        private static string DoShipLockerMaterials(JObject obj)
        {
            string res = "<-- Считывание информации о предметах на корабле -->";
            // Items, Components, Data
            JArray consumables = obj.Value<JArray>("Consumables");
            foreach (JObject item in consumables.Children())
            {
                string name = item.Value<string>("Name");
                string localized = item.Value<string>("Name_Localised");
                int count = item.Value<int>("Count");
                if (localized.Length > 0) name = localized;
                res += string.Format("\r\n>> Предмет: {0}, количество: {1} <<", name, count);
            }
            return res;
        }

        private static string DoRank(JObject obj)
        {
            string res = "<-- Считывание информации о рангах -->";
            string combat = GetCombatRank(obj.Value<int>("Combat"));
            string trade = GetTradeRank(obj.Value<int>("Trade"));
            string explore = GetExploreRank(obj.Value<int>("Explore"));
            string soldier = GetSoldierRank(obj.Value<int>("Soldier"));
            string exobiologist = GetExobiologistRank(obj.Value<int>("Exobiologist"));
            string empire = GetEmpireRank(obj.Value<int>("Empire"));
            string federation = GetFederalRank(obj.Value<int>("Federation"));
            res += string.Format("\r\n>> Боевой: {0} <<\r\n>> Торговый: {1} <<\r\n>> Исследовательский: {2} <<", combat, trade, explore);
            res += string.Format("\r\n>> Наёмник: {0} <<\r\n>> Экзобиолог: {1} <<", soldier, exobiologist);
            res += string.Format("\r\n>> Империя: {0} <<\r\n>> Федерация: {1} <<", empire, federation);
            return res;
        }

        private static string GetCombatRank(int rank)
        {
            switch (rank)
            {
                default:
                case 0: return "Безвредный";
                case 1: return "В целом безвредный";
                case 2: return "Новичок";
                case 3: return "Специалист";
                case 4: return "Эксперт";
                case 5: return "Мастер";
                case 6: return "Опасный";
                case 7: return "Смертоносный";
                case 8: return "Элита";
            }
        }

        private static string GetTradeRank(int rank)
        {
            switch (rank)
            {
                default:
                case 0: return "Нищий";
                case 1: return "Полунищий";
                case 2: return "Мелкий торговец";
                case 3: return "Агент";
                case 4: return "Коммерсант";
                case 5: return "Брокер";
                case 6: return "Предприниматель";
                case 7: return "Магнат";
                case 8: return "Элита";
            }
        }

        private static string GetExploreRank(int rank)
        {
            switch (rank)
            {
                default:
                case 0: return "Бесцельный";
                case 1: return "Почти бесцельный";
                case 2: return "Разведчик";
                case 3: return "Изыскатель";
                case 4: return "Путешественник";
                case 5: return "Следопыт";
                case 6: return "Скиталец";
                case 7: return "Первопроходец";
                case 8: return "Элита";
            }
        }

        private static string GetSoldierRank(int rank)
        {
            switch (rank)
            {
                default:
                case 0: return "Беззащитный";
                case 1: return "Почти беззащитный";
                case 2: return "Новобранец";
                case 3: return "Солдат";
                case 4: return "Стрелок";
                case 5: return "Воин";
                case 6: return "Градиатор";
                case 7: return "Снайпер";
                case 8: return "Элита";
            }
        }

        private static string GetExobiologistRank(int rank)
        {
            switch (rank)
            {
                default:
                case 0: return "Бесцельный";
                case 1: return "Почти бесцельный";
                case 2: return "Составитель";
                case 3: return "Сборщик";
                case 4: return "Каталогер";
                case 5: return "Систематик";
                case 6: return "Эколог";
                case 7: return "Генетик";
                case 8: return "Элита";
            }
        }

        private static string GetEmpireRank(int rank)
        {
            switch (rank)
            {
                default:
                case 0: return "Чужак";
                case 1: return "Крепостной";
                case 2: return "Мастер"; // Imperial Courier
                case 3: return "Оруженосец"; // Achenar
                case 4: return "Рыцарь"; 
                case 5: return "Лорд";
                case 6: return "Барон"; // Imperial clipper, Summerland
                case 7: return "Виконт"; 
                case 8: return "Граф";
                case 9: return "Эрл"; // Facece
                case 10: return "Маркиз";
                case 11: return "Герцог"; // Imperial Cutter
                case 12: return "Принц";
                case 13: return "Король";
            }
        }

        private static string GetFederalRank(int rank)
        {
            switch (rank)
            {
                default:
                case 0: return "Рекрут";
                case 1: return "Кадет";
                case 2: return "Гардемарин"; // Federal dropship
                case 3: return "Старшина"; // Sol
                case 4: return "Главный старшина"; // Federal assault ship, Vega, Beta Hydri
                case 5: return "Уорент-офицер"; // PLX 695
                case 6: return "Энсин"; // Federal Gunship, Ross 128
                case 7: return "Лейтенант"; // Exbeur
                case 8: return "Капитан-лейтенант";
                case 9: return "Начальник гарнизона"; // Hors
                case 10: return "Командир корабля";
                case 11: return "Контр-адмирал"; // Federal Corvette
                case 12: return "Вице-адмирал";
                case 13: return "Адмирал";
            }
        }

        private static string DoLoadGame(JObject obj)
        {
            string res = "<-- Проверка состояния пилота -->";
            string ship = obj.Value<string>("Ship");
            string shipName = obj.Value<string>("ShipName");
            int credits = obj.Value<int>("Credits");
            if (shipName.Length > 0)
            {
                // On the ship.
                res += string.Format("\r\n>> Корабль: {0} ({1})", shipName, ship);
            } else
            {
                // On the ground.
                string localized = obj.Value<string>("Ship_Localised");
                if (localized.Length > 0) ship = localized;
                res += string.Format("\r\n>> Костюм: {0}", ship);
            }
            res += string.Format("\r\n>> Кредиты: {0}", credits);
            return res;
        }

        private static string DoLocation(JObject obj)
        {
            // TODO: implement this correctly.
            string res = "<-- Проверка местоположения -->";
            bool isDocked = obj.Value<bool>("Docked");
            bool isOnFoot = obj.Value<bool>("OnFoot");
            string starSystem = obj.Value<string>("StarSystem");
            string body = obj.Value<string>("Body"); // in oddysey on food will be station name
            double latitude = obj.Value<double>("Latitude");
            double longitude = obj.Value<double>("Longitude");
            if (isDocked)
            {
                // Probably old horizons version
                string stationName = obj.Value<string>("StationName"); 
                string stationType = obj.Value<string>("StationType");
                res += string.Format("\r\n>> Станция: {0} ({1})", stationName, stationType);
            }
            if (isOnFoot)
            {
                string bodyType = obj.Value<string>("BodyType");
                res += string.Format("\r\n>> Станция: {0} ({1})", body, bodyType);
            }
            res += "\r\n-------------------------";
            return res;
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

        private static string DoReceiveText(JObject obj)
        {
            string from = obj.Value<string>("From");
            string message = obj.Value<string>("Message");
            string localized = obj.Value<string>("Message_Localised");
            if (localized.Length > 0) message = localized;
            string res;
            if (from.Length == 0) res = string.Format("-> {0}", message);
            else res = string.Format("-> [{0}] -->-- {1}", from, message);
            return res;
        }
    }
}
