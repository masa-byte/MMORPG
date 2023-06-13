#nullable disable
using MMORPG.Entities;
using NHibernate;

namespace MMORPG
{
    public class DTOManager
    {

        public static string TransformText(string text)
        {
            string[] words = text.Split(' ');

            if (words.Length > 0)
            {
                for (int i = 0; i < words.Length; i++)
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLowerInvariant();
            }

            string transformedSentence = string.Join(" ", words);
            return transformedSentence;
        }

        public static string ParseType(string text)
        {
            string[] split = text.Split('.');
            return split[split.Length - 1].Trim().ToUpper();
        }

        public static Player SignInPlayer(string nickname, string password)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();
                Player? playerCheck = s.Query<Player>()
                    .Where(player => player.Nickname.Equals(nickname) && player.Password.Equals(password))
                    .FirstOrDefault();

                if (playerCheck == null)
                {
                    return null;
                }

                return playerCheck;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static bool CheckNicknameUnique(string nickname)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();
                Player? playerCheck = s.Query<Player>()
                    .Where(player => player.Nickname.Equals(nickname))
                    .FirstOrDefault();

                if (playerCheck != null)
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return true;
        }

        public static Player SignUpPlayer(PlayerView playerView, string password)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();

                bool unique = CheckNicknameUnique(playerView.Nickname);
                if (unique)
                {
                    Player playerToSave = new Player()
                    {
                        Nickname = playerView.Nickname,
                        Password = password,
                        Name = playerView.Name.ToUpper(),
                        Surname = playerView.Surname.ToUpper(),
                        Age = playerView.Age,
                        Gender = playerView.Gender
                    };

                    s.Save(playerToSave);

                    return playerToSave;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static double GetAvailableFunds(string nickname)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();
                Player player = s.Query<Player>()
                    .Where(player => player.Nickname.Equals(nickname))
                    .FirstOrDefault();

                if (player == null)
                    return -1;
                return player.Characters.Sum(character => character.Gold);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return 0;
        }

        public static double GetExperience(string nickname)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();
                Player player = s.Query<Player>()
                    .Where(player => player.Nickname.Equals(nickname))
                    .FirstOrDefault();

                if (player == null)
                    return -1;
                return player.Characters.Sum(character => character.Experience);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return 0;
        }

        public static IEnumerable<PlayerView> ReturnAllPlayersRanked()
        {
            ISession s = default;
            List<PlayerView> playerViews = new List<PlayerView>();

            try
            {
                s = DataLayer.GetSession();
                // If player has no sessions yet,
                // the query below puts him at the top of the list
                // (he should be on bottom)
                /*
                 IEnumerable<Player> players = s.Query<Player>()
                    .OrderByDescending(player => player.Sessions.Sum(session => session.Points));
                 */

                // this query fixes the issue
                IEnumerable<Player> players = s.Query<Player>()
                    .Where(player => player.Sessions.Count > 0)
                    .OrderByDescending(player => player.Sessions.Sum(session => session.Points));

                players = players.Concat(s.Query<Player>()
                    .Where(player => player.Sessions.Count == 0));

                foreach (Player p in players)
                {
                    playerViews.Add(new PlayerView(p.Id, p.Nickname, TransformText(p.Name), TransformText(p.Surname), p.Gender, p.Age, ReturnPlayerPoints(p.Id)));
                }
                return playerViews;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static double ReturnPlayerPoints(int playerId)
        {

            ISession s = default;
            double points = 0;

            try
            {
                s = DataLayer.GetSession();
                Player player = s.Query<Player>().Where(player => player.Id == playerId).First();
                foreach (Session session in player.Sessions)
                {
                    points += session.Points;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return points;
        }

        public static double ReturnPlayerPoints(string nickname)
        {

            ISession s = default;
            double points = 0;

            try
            {
                s = DataLayer.GetSession();
                Player player = s.Query<Player>().Where(player => player.Nickname.Equals(nickname)).FirstOrDefault();
                if (player != null)
                    foreach (Session session in player.Sessions)
                    {
                        points += session.Points;
                    }
                else
                    return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return points;
        }

        public static IEnumerable<CharacterView> ReturnAllPlayerCharacters(string nickname)
        {
            ISession s = default;
            List<CharacterView> characters = new List<CharacterView>();
            try
            {
                s = DataLayer.GetSession();
                Player player = s.Query<Player>()
                    .Where(player => player.Nickname.Equals(nickname))
                    .FirstOrDefault();

                if (player != null)
                    foreach (var character in player.Characters)
                    {
                        characters.Add(new CharacterView(character.Id, ParseType(character.GetType().ToString().ToUpper()),
                            character.Race, character.Gold, character.Experience));
                    }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return characters;
        }

        public static IEnumerable<PlayerView> ReturnAllPlayersFromTeam(string teamName)
        {
            ISession s = default;
            List<PlayerView> playerViews = new List<PlayerView>();

            try
            {
                s = DataLayer.GetSession();
                IEnumerable<Player> players = s.Query<Player>()
                    .Where(player => player.Team.Name.Equals(teamName));

                foreach (Player p in players)
                {
                    playerViews.Add(new PlayerView(p.Id, p.Nickname, TransformText(p.Name), TransformText(p.Surname), p.Gender, p.Age, ReturnPlayerPoints(p.Id)));
                }
                return playerViews;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static IEnumerable<TeamView> ReturnAllTeamsRanked()
        {
            ISession s = default;
            List<TeamView> teamViews = new List<TeamView>();

            try
            {
                s = DataLayer.GetSession();

                IEnumerable<Team> teams = s.Query<Team>().Where(team => team.Placement == 0 && team.Transitions.Count > 0);

                foreach (Team team in teams)
                {
                    CalculateInitialTeamPoints(team);
                    s.Update(team);
                }

                s.Flush();

                IEnumerable<Team> teamsRanked = s.Query<Team>()
                    .OrderByDescending(team => team.Placement);

                foreach (Team t in teamsRanked)
                {
                    teamViews.Add(new TeamView(t.Id, TransformText(t.Name), t.BonusPoints, t.Placement, t.Players));
                }
                return teamViews;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static void CalculateInitialTeamPoints(Team team)
        {
            double points = 0;

            try
            {
                foreach (Transit transit in team.Transitions)
                {
                    points += transit.EnemiesDefeated + team.BonusPoints;
                }
                team.Placement = points;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static IEnumerable<BlessingView> ReturnAllBlessings()
        {
            ISession s = null;
            List<BlessingView> blessingsView = new List<BlessingView>();

            try
            {
                s = DataLayer.GetSession();
                IEnumerable<Blessing> blessings = s.Query<Blessing>().OrderBy(blessing => blessing.Id);

                foreach (Blessing b in blessings)
                {
                    blessingsView.Add(new BlessingView(b.Id, TransformText(b.Name)));
                }
                return blessingsView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static string RemoveBlessing(int blessingId)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();

                Blessing blessing = s.Query<Blessing>().Where(blessing => blessing.Id == blessingId).FirstOrDefault();

                if (blessing == null)
                    return "Blessing doesn't exist!";

                if (blessing.UsedByPriests.Count > 0)
                {
                    return "Priests use this blessing, can't remove it!";
                }

                s.Delete(blessing);
                if (s.Get<Blessing>(blessingId) == null)
                    return "Successful";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Error";
        }

        public static BlessingView ReturnBlessing(int blessingId)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();
                Blessing blessing = s.Query<Blessing>().Where(blessing => blessing.Id == blessingId).FirstOrDefault();

                if (blessing == null)
                    return null;

                BlessingView blessingView = new BlessingView(blessing.Id, TransformText(blessing.Name));
                return blessingView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return null;
        }

        public static string SaveBlessing(BlessingView blessing)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();
                Blessing? blessingCheck = s.Query<Blessing>()
                    .Where(bless => bless.Name.Equals(blessing.Name.ToUpper()))
                    .FirstOrDefault();

                if (blessingCheck != null)
                {
                    return "This blessing already exists!";
                }

                Blessing blessingToSave = new Blessing
                {
                    Name = blessing.Name.ToUpper()
                };

                s.Save(blessingToSave);
                return "Successful!";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Error";
        }

        public static string UpdateBlessing(BlessingView blessing)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();

                Blessing blessingToUpdate = s.Query<Blessing>().Where(bless => bless.Id == blessing.Id).FirstOrDefault();

                if (blessingToUpdate == null)
                {
                    return "Blessing doesn't exist!";
                }
                blessingToUpdate.Name = blessing.Name.ToUpper();

                s.Update(blessingToUpdate);
                return "Successful!";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Error";
        }

        public static IEnumerable<ItemView> ReturnAllPlayerItems(string nickname)
        {
            ISession s = null;
            List<ItemView> itemsView = new List<ItemView>();

            try
            {
                s = DataLayer.GetSession();
                List<Owns> owns = s.Query<Owns>().Where(owns => owns.Player.Nickname.Equals(nickname)).ToList();

                foreach (Owns o in owns)
                {
                    itemsView.Add(new ItemView(
                        o.Item.Id, TransformText(o.Item.Name), o.Item.BonusPoints, TransformText(o.Item.Description),
                        o.Item.Price, o.Item.ExpNeeded, o.Item.Weapon, o.Item.WeaponType,
                        o.Item.AttackPoints, o.Item.Armour, o.Item.DefensePoints,
                        o.Item.AllowedRaces.Select(allowedRace => new AllowedRaceView(allowedRace.RaceName)).ToList(),
                        o.Item.AllowedClasses.Select(allowedRace => new AllowedClassView(allowedRace.ClassName)).ToList()
                    ));
                }
                return itemsView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static IEnumerable<ItemView> ReturnAllItems()
        {
            ISession s = null;
            List<ItemView> itemsView = new List<ItemView>();

            try
            {
                s = DataLayer.GetSession();
                IEnumerable<Item> items = s.Query<Item>().OrderBy(item => item.Id);

                foreach (Item i in items)
                {
                    itemsView.Add(new ItemView(
                        i.Id, TransformText(i.Name), i.BonusPoints, TransformText(i.Description),
                        i.Price, i.ExpNeeded, i.Weapon, i.WeaponType,
                        i.AttackPoints, i.Armour, i.DefensePoints,
                        i.AllowedRaces.Select(allowedRace => new AllowedRaceView(allowedRace.RaceName)).ToList(),
                        i.AllowedClasses.Select(allowedRace => new AllowedClassView(allowedRace.ClassName)).ToList()
                    ));
                }
                return itemsView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static ItemView ReturnItem(int itemId)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();
                Item? item = s.Query<Item>().Where(item => item.Id == itemId).FirstOrDefault();

                if (item == null)
                    return null;

                ItemView itemView = new ItemView(
                    item.Id, TransformText(item.Name), item.BonusPoints, TransformText(item.Description),
                    item.Price, item.ExpNeeded, item.Weapon, item.WeaponType,
                    item.AttackPoints, item.Armour, item.DefensePoints,
                    item.AllowedRaces.Select(allowedRace => new AllowedRaceView(allowedRace.RaceName)).ToList(),
                    item.AllowedClasses.Select(allowedRace => new AllowedClassView(allowedRace.ClassName)).ToList()
                );
                return itemView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return null;
        }

        public static string SaveItem(ItemView itemView)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();
                Item? itemCheck = s.Query<Item>()
                    .Where(item => item.Name.Equals(itemView.Name.ToUpper()))
                    .FirstOrDefault();

                if (itemCheck != null)
                {
                    return "This item already exists!";
                }

                Item itemToSave = new Item()
                {
                    Id = itemView.Id,
                    Name = itemView.Name.ToUpper(),
                    BonusPoints = (double)itemView.BonusPoints,
                    Description = itemView.Description.ToUpper(),
                    Price = (double)itemView.Price,
                    ExpNeeded = (double)itemView.ExpNeeded,
                    Weapon = (char)itemView.Weapon,
                    WeaponType = itemView.WeaponType,
                    AttackPoints = itemView.AttackPoints,
                    Armour = (char)itemView.Armour,
                    DefensePoints = itemView.DefensePoints,
                };

                foreach (AllowedRaceView allowedRace in itemView.AllowedRaces)
                {
                    AllowedRace allowedRaceToSave = new AllowedRace()
                    {
                        RaceName = allowedRace.RaceName,
                        Item = itemToSave
                    };
                    itemToSave.AllowedRaces.Add(allowedRaceToSave);
                }

                foreach (AllowedClassView allowedClass in itemView.AllowedClasses)
                {
                    AllowedClass allowedClassToSave = new AllowedClass()
                    {
                        ClassName = allowedClass.ClassName,
                        Item = itemToSave
                    };
                    itemToSave.AllowedClasses.Add(allowedClassToSave);
                }

                s.Save(itemToSave);

                return "Successful!";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Erorr";
        }

        public static string RemoveItem(int itemId)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();
                Item item = s.Query<Item>()
                    .Where(item => item.Id == itemId)
                    .FirstOrDefault();

                if (item == null)
                {
                    return "This item doesn't exist!";
                }

                List<Owns> ownings = s.Query<Owns>()
                    .Where(owns => owns.Item.Id == itemId)
                    .ToList();

                foreach (Owns owns in ownings)
                {
                    owns.Player.Characters[0].Gold += owns.Item.Price;
                }

                item.AllowedRaces.Clear();
                item.AllowedClasses.Clear();

                s.Delete(item);
                if (s.Get<Item>(itemId) == null)
                    return "Successful!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Erorr";
        }

        public static string UpdateItem(ItemView itemView)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();

                Item itemToUpdate = s.Query<Item>()
                    .Where(item => item.Id == itemView.Id)
                    .FirstOrDefault();

                if (itemToUpdate == null)
                {
                    return "This item doesn't exist!";
                }

                itemToUpdate.Name = itemView.Name != null ? itemView.Name.ToUpper() : itemToUpdate.Name;
                itemToUpdate.BonusPoints = (double)(itemView.BonusPoints != null ? itemView.BonusPoints : itemToUpdate.BonusPoints);
                itemToUpdate.Description = itemView.Description != null ? itemView.Description.ToUpper() : itemToUpdate.Description;
                itemToUpdate.Price = (double)(itemView.Price != null ? itemView.Price : itemToUpdate.Price);
                itemToUpdate.ExpNeeded = (double)(itemView.ExpNeeded != null ? itemView.ExpNeeded : itemToUpdate.ExpNeeded);
                itemToUpdate.Weapon = (char)(itemView.Weapon != null ? itemView.Weapon : itemToUpdate.Weapon);
                itemToUpdate.WeaponType = itemView.WeaponType != null ? itemView.WeaponType : itemToUpdate.WeaponType;
                itemToUpdate.AttackPoints = itemView.AttackPoints != null ? itemView.AttackPoints : itemToUpdate.AttackPoints;
                itemToUpdate.Armour = (char)(itemView.Armour != null ? itemView.Armour : itemToUpdate.Armour);
                itemToUpdate.DefensePoints = itemView.DefensePoints != null ? itemView.DefensePoints : itemToUpdate.DefensePoints;

                if (itemView.AllowedRaces != null)
                {
                    itemToUpdate.AllowedRaces.Clear();
                    itemView.AllowedRaces.ForEach(allowedRace =>
                    {
                        AllowedRace allowedRaceToSave = new AllowedRace()
                        {
                            RaceName = allowedRace.RaceName,
                            Item = itemToUpdate
                        };
                        itemToUpdate.AllowedRaces.Add(allowedRaceToSave);
                    });
                }
                if (itemView.AllowedClasses != null)
                {
                    itemToUpdate.AllowedClasses.Clear();


                    itemView.AllowedClasses.ForEach(allowedClass =>
                    {
                        AllowedClass allowedClassToSave = new AllowedClass()
                        {
                            ClassName = allowedClass.ClassName,
                            Item = itemToUpdate
                        };
                        itemToUpdate.AllowedClasses.Add(allowedClassToSave);
                    });
                }

                s.Update(itemToUpdate);
                return "Successful!";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Error";
        }

        public static string BuyItem(int playerId, int itemId)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();

                Item item = s.Query<Item>()
                    .Where(item => item.Id == itemId)
                    .FirstOrDefault();

                if (item == null)
                {
                    return "This item doesn't exist!";
                }
                Player player = s.Query<Player>()
                    .Where(player => player.Id == playerId)
                    .FirstOrDefault();

                if (player == null)
                {
                    return "This player doesn't exist!";
                }

                if (player.OwnsItems.Where(owns => owns.Item.Id == item.Id).FirstOrDefault() != null)
                {
                    return "You already own this item!";
                }
                if (player.Characters.Sum(character => character.Gold) < item.Price)
                {
                    return "Insufficient funds!";
                }
                if (player.Characters.Sum(character => character.Experience) < item.ExpNeeded)
                {
                    return "Level up then come back!";
                }
                if (!player.Characters.Any(character => item.AllowedRaces.Select(race => race.RaceName).Contains(character.Race)))
                {
                    return "Your characters' race isn't compatible!";
                }
                if (!player.Characters.Any(character =>
                    item.AllowedClasses.Select(clas => clas.ClassName)
                    .Contains(ParseType(character.GetType().ToString()))))
                {
                    return $"Your characters' class isn't compatible: {ParseType(player.Characters[0].GetType().ToString())}!";
                }

                if (player.Characters[0].Gold >= item.Price)
                {
                    player.Characters[0].Gold -= item.Price;
                }
                else
                {
                    double tmp = item.Price - player.Characters[0].Gold;
                    player.Characters[0].Gold = 0;
                    player.Characters[1].Gold -= tmp;
                }

                Owns owns = new Owns()
                {
                    Item = item,
                    Player = player
                };

                s.Save(owns);

                return "Successfully bought!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Error";
        }

        public static string SellItem(int playerId, int itemId)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();

                Owns owns = s.Query<Owns>()
                    .Where(owns => owns.Player.Id == playerId && owns.Item.Id == itemId)
                    .FirstOrDefault();

                if (owns == null)
                {
                    return "You don't own this item!";
                }
                owns.Player.Characters[0].Gold += owns.Item.Price;

                s.Delete(owns);

                return "Successfully sold!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Error";
        }

        public static IEnumerable<TrackView> ReturnAllTracks()
        {
            ISession s = null;
            List<TrackView> tracksView = new List<TrackView>();

            try
            {
                s = DataLayer.GetSession();
                IEnumerable<Track> tracks = s.Query<Track>().OrderBy(item => item.Id);

                foreach (Track t in tracks)
                {
                    tracksView.Add(new TrackView(
                        t.Id, TransformText(t.Name), t.Team, t.Bonus,
                        t.RequiredRaces.Select(requiredRace => new RequiredRaceView(requiredRace.RaceName)).ToList(),
                        t.RequiredClasses.Select(requiredRace => new RequiredClassView(requiredRace.ClassName)).ToList()
                    ));
                }
                return tracksView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static TrackView ReturnTrack(int trackId)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();
                Track? track = s.Query<Track>()
                    .Where(track => track.Id == trackId)
                    .FirstOrDefault();

                if (track == null)
                {
                    return null;
                }

                TrackView trackView = new TrackView(
                    track.Id, TransformText(track.Name), track.Team, track.Bonus,
                    track.RequiredRaces.Select(requiredRace => new RequiredRaceView(requiredRace.RaceName)).ToList(),
                    track.RequiredClasses.Select(requiredRace => new RequiredClassView(requiredRace.ClassName)).ToList()
                );
                return trackView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return null;
        }

        public static string SaveTrack(TrackView trackView)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();
                Track? trackCheck = s.Query<Track>()
                    .Where(track => track.Name.Equals(trackView.Name.ToUpper()))
                    .FirstOrDefault();
                Console.WriteLine(trackCheck);

                if (trackCheck != null)
                {
                    return "This track already exists!";
                }

                Track trackToSave = new Track()
                {
                    Name = trackView.Name.ToUpper(),
                    Team = (char)trackView.Team,
                    Bonus = (double)trackView.Bonus
                };

                foreach (RequiredRaceView requiredRace in trackView.RequiredRaces)
                {
                    RequiredRace requiredRaceToSave = new RequiredRace()
                    {
                        RaceName = requiredRace.RaceName,
                        Track = trackToSave
                    };
                    trackToSave.RequiredRaces.Add(requiredRaceToSave);
                }

                foreach (RequiredClassView requiredClass in trackView.RequiredClasses)
                {
                    RequiredClass requiredClassToSave = new RequiredClass()
                    {
                        ClassName = requiredClass.ClassName,
                        Track = trackToSave
                    };
                    trackToSave.RequiredClasses.Add(requiredClassToSave);
                }

                // RequiredRaces and RequiredClasses are saved automatically
                // because of the .Cascade.All().Inverse() option

                s.Save(trackToSave);

                return "Successful!";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Error";
        }

        public static string RemoveTrack(int trackId)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();
                Track track = s.Query<Track>()
                    .Where(track => track.Id == trackId)
                    .FirstOrDefault();

                if (track == null)
                {
                    return "This track doesn't exist!";
                }

                if (track.Transitions.Count > 0)
                {
                    return "Players have already made transitions!";
                }

                track.RequiredRaces.Clear();
                track.RequiredClasses.Clear();

                s.Delete(track);
                if (s.Get<Track>(trackId) == null)
                    return "Successful";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Error";
        }

        public static string UpdateTrack(TrackView track)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();

                Track trackToUpdate = s.Query<Track>()
                    .Where(track => track.Id == track.Id)
                    .FirstOrDefault();

                if (trackToUpdate == null)
                {
                    return "This track doesn't exist!";
                }

                trackToUpdate.Name = track.Name != null ? track.Name.ToUpper() : trackToUpdate.Name;
                trackToUpdate.Team = (char)(track.Team != null ? track.Team : trackToUpdate.Team);
                trackToUpdate.Bonus = (double)(track.Bonus != null ? track.Bonus : trackToUpdate.Bonus);

                if (track.RequiredRaces != null)
                {
                    trackToUpdate.RequiredRaces.Clear();
                    track.RequiredRaces.ForEach(requiredRace =>
                    {
                        RequiredRace requiredRaceToUpdate = new RequiredRace()
                        {
                            RaceName = requiredRace.RaceName,
                            Track = trackToUpdate
                        };
                        trackToUpdate.RequiredRaces.Add(requiredRaceToUpdate);
                    });
                }

                if (track.RequiredClasses != null)
                {
                    trackToUpdate.RequiredClasses.Clear();
                    track.RequiredClasses.ForEach(requiredClass =>
                    {
                        RequiredClass requiredClassToUpdate = new RequiredClass()
                        {
                            ClassName = requiredClass.ClassName,
                            Track = trackToUpdate
                        };
                        trackToUpdate.RequiredClasses.Add(requiredClassToUpdate);
                    });
                }

                s.Update(trackToUpdate);
                return "Successful!";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Error";
        }

        public static List<SpellView> ReturnAllSpells()
        {
            ISession s = null;
            List<SpellView> spellsView = new List<SpellView>();

            try
            {
                s = DataLayer.GetSession();
                IEnumerable<Spell> spells = s.Query<Spell>().OrderBy(spell => spell.Id);

                foreach (Spell sp in spells)
                {
                    spellsView.Add(new SpellView(sp.Id, TransformText(sp.Name)));
                }
                return spellsView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static SpellView? ReturnSpell(int spellId)
        {
            ISession s = default;
            try
            {
                s = DataLayer.GetSession();
                Spell? spell = s.Query<Spell>()
                    .Where(spell => spell.Id == spellId)
                    .FirstOrDefault();

                if (spell == null)
                {
                    return null;
                }

                SpellView spellView = new SpellView(spell.Id, TransformText(spell.Name));
                return spellView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static string SaveSpell(SpellView spell)
        {
            ISession s = default;
            try
            {
                s = DataLayer.GetSession();
                Spell? spellCheck = s.Query<Spell>()
                    .Where(item => item.Name.Equals(spell.Name.ToUpper()))
                    .FirstOrDefault();

                if (spellCheck != null)
                {
                    return "This spell already exists!";
                }

                Spell spellToSave = new Spell()
                {
                    Name = spell.Name.ToUpper()
                };

                s.Save(spellToSave);
                return "Successful!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Error";
        }

        public static string UpdateSpell(SpellView spell)
        {
            ISession s = default;
            try
            {
                s = DataLayer.GetSession();
                Spell spellToUpdate = s.Query<Spell>()
                    .Where(spell => spell.Id == spell.Id)
                    .FirstOrDefault();

                if (spellToUpdate == null)
                {
                    return "This spell doesn't exist!";
                }

                spellToUpdate.Name = spell.Name != null ? spell.Name.ToUpper() : spellToUpdate.Name;

                s.Update(spellToUpdate);
                return "Successful!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Error";
        }

        public static string RemoveSpell(int spellId)
        {
            ISession s = default;
            try
            {
                s = DataLayer.GetSession();
                Spell spell = s.Query<Spell>()
                    .Where(spell => spell.Id == spellId)
                    .FirstOrDefault();

                if (spell == null)
                {
                    return "This spell doesn't exist!";
                }

                if (spell.CastByWizards.Count > 0)
                {
                    return "Wizards cast this spell, can't remove it!";
                }

                s.Delete(spell);

                if (s.Get<Spell>(spellId) == null)
                    return "Successful";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return "Error";
        }

        public static Transit ReturnTransit(int transitId)
        {
            ISession s = default;
            try
            {
                s = DataLayer.GetSession();
                Transit transit = s.Query<Transit>()
                    .Where(transit => transit.Id == transitId)
                    .FirstOrDefault();

                if (transit == null)
                {
                    return null;
                }

                return transit;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static List<ItemView> PlayerFindsItems(int playerId, int numItems)
        {
            ISession s = default;
            List<ItemView> itemViewList = new List<ItemView>();

            try
            {
                s = DataLayer.GetSession();

                Player player = s.Get<Player>(playerId);

                IEnumerable<Item> items = s.Query<Item>()
                    .Where(item => !item.OwnedByPlayers.Select(owns => owns.Player.Id).Contains(playerId));
                List<Item> validItems = new List<Item>();


                foreach (Item item in items)
                {
                    if (player.Characters.Any(character => item.AllowedRaces.Select(race => race.RaceName).Contains(character.Race)) &&
                        player.Characters.Any(character => item.AllowedClasses.Select(clas => clas.ClassName).Contains(ParseType(character.GetType().ToString()))))
                    {
                        validItems.Add(item);
                        itemViewList.Add(new ItemView(
                            item.Id, TransformText(item.Name), item.BonusPoints, TransformText(item.Description),
                            item.Price, item.ExpNeeded, item.Weapon, item.WeaponType,
                            item.AttackPoints, item.Armour, item.DefensePoints,
                            item.AllowedRaces.Select(allowedRace => new AllowedRaceView(allowedRace.RaceName)).ToList(),
                            item.AllowedClasses.Select(allowedRace => new AllowedClassView(allowedRace.ClassName)).ToList()
                        ));
                    }
                }

                for (int i = 0; i < numItems; i++)
                {
                    Owns owns = new Owns()
                    {
                        Item = validItems[i],
                        Player = player
                    };

                    s.Save(owns);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return itemViewList;
        }

        public static (string, Object) PlayGame(int playerId, string difficulty, int trackId)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();

                Player player = s.Query<Player>().Where(player => player.Id == playerId).FirstOrDefault();

                if (player == null)
                {
                    return ("Player doesn't exist!", null);
                }

                Track track = s.Query<Track>().Where(track => track.Id == trackId).FirstOrDefault();

                if (track == null)
                {
                    return ("Track doesn't exist!", null);
                }

                Team team = null;

                if (difficulty != "Hard" && difficulty != "Medium" && difficulty != "Easy")
                {
                    return ("Difficulty must be one of the following: Hard, Medium or Easy!", null);
                }

                // checks

                if (track.Team == 'F')
                {
                    if (track.RequiredRaces.Count != 0 && !player.Characters.Any(character => track.RequiredRaces.Select(race => race.RaceName).Contains(character.Race)))
                    {
                        return ("Your characters' race isn't compatible!", null);
                    }
                    if (track.RequiredClasses.Count != 0 && !player.Characters.Any(character =>
                        track.RequiredClasses.Select(clas => clas.ClassName)
                        .Contains(ParseType(character.GetType().ToString()))))
                    {
                        return ("Your characters' class isn't compatible!", null);
                    }
                }
                else
                {
                    bool foundRace = false;
                    bool foundClass = false;

                    team = s.Query<Team>().Where(team => team.Id == player.Team.Id).First();

                    if (team.Players.Count < team.MinPlayers)
                        return ("Your team doesn't have enough players!", null);

                    foreach (Player p in team.Players)
                    {
                        if (track.RequiredRaces.Count != 0 && player.Characters.Any(character =>
                        track.RequiredRaces.Select(race => race.RaceName).Contains(character.Race)))
                        {
                            foundRace = true;
                        }
                        if (track.RequiredClasses.Count != 0 && player.Characters.Any(character =>
                            track.RequiredClasses.Select(clas => clas.ClassName)
                            .Contains(ParseType(character.GetType().ToString()))))
                        {
                            foundClass = true;
                        }
                    }

                    if (foundRace == false)
                        return ("Your team characters' races aren't compatible!", null);
                    if (foundClass == false)
                        return ("Your team characters' classes aren't compatible!", null);
                }

                // simulating a game

                Random rnd = new Random();
                int enemiesDefeated = 0, successful = rnd.Next(0, 10);

                switch (difficulty)
                {
                    case "Hard":
                        {
                            enemiesDefeated = rnd.Next(0, 30);
                            _ = (successful < 2) ? successful = 1 : successful = 0;
                        }
                        break;
                    case "Medium":
                        {
                            enemiesDefeated = rnd.Next(0, 60);
                            _ = (successful < 6) ? successful = 1 : successful = 0;
                        }
                        break;
                    case "Easy":
                        {
                            enemiesDefeated = rnd.Next(0, 100);
                            _ = (successful < 9) ? successful = 1 : successful = 0;
                        }
                        break;
                }

                // gained items

                int numItems = rnd.Next(0, 2);
                PlayerFindsItems(playerId, numItems);

                if (successful == 1)
                {
                    player.Characters[0].Gold += enemiesDefeated * 2;
                    player.Characters[0].Experience += enemiesDefeated;
                }
                else
                {

                }

                // transit

                Transit transit = new Transit()
                {
                    EnemiesDefeated = enemiesDefeated,
                    Successful = (successful == 1) ? 'T' : 'F',
                    Track = track
                };

                if (track.Team == 'F')
                {
                    transit.Player = player;
                    transit.Team = null;
                }
                else
                {
                    transit.Team = team;
                    transit.Player = null;
                }

                s.Save(transit);
                s.Update(player);

                return ("Played a game!", new
                {
                    TransitId = transit.Id,
                    EnemiesDefeated = enemiesDefeated,
                    Successful = (successful == 1) ? "True" : "False",
                    Gold = enemiesDefeated * 2,
                    Exp = enemiesDefeated
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return ("Unknown error", null);
        }

        // MISSING
        public static string SaveSession(int playerId, double gold, double points, DateTime startTime, DateTime endTime)
        {
            ISession s = default;

            try
            {
                s = DataLayer.GetSession();

                Player player = s.Get<Player>(playerId);

                foreach (Owns o in player.OwnsItems)
                {
                    points += o.Item.BonusPoints;
                }

                Session session = new Session()
                {
                    Gold = gold,
                    Points = points,
                    StartTime = startTime,
                    EndTime = endTime,
                    Player = player
                };

                s.Save(session);

                return "Session successfully added!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return "Error";
        }

        public static TeamView ReturnTeamForPlayer(int playerId)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                Player player = s.Get<Player>(playerId);

                if (player == null || player.Team == null)
                {
                    return null;
                }

                TeamView teamView = new TeamView()
                {
                    Id = player.Team.Id,
                    Name = player.Team.Name,
                    MinPlayers = player.Team.MinPlayers,
                    MaxPlayers = player.Team.MaxPlayers,
                    BonusPoints = player.Team.BonusPoints,
                    Placement = player.Team.Placement,
                    PlayerCount = player.Team.Players.Count
                };

                return teamView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }

            return null;
        }

        public static List<TeamView> ReturnAllJoinableTeams()
        {
            ISession session = default;

            try
            {
                session = DataLayer.GetSession();
                List<TeamView> teams = new List<TeamView>();
                foreach (Team team in session.Query<Team>()
                    .OrderBy(team => team.Id)
                    .Where(team => team.Players.Count <= team.MaxPlayers))
                {
                    teams.Add(new TeamView()
                    {
                        Id = team.Id,
                        Name = team.Name,
                        MinPlayers = team.MinPlayers,
                        MaxPlayers = team.MaxPlayers,
                        BonusPoints = team.BonusPoints,
                        Placement = team.Placement,
                        PlayerCount = team.Players.Count
                    });
                }
                return teams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                session.Flush();
                session.Close();
            }
            return new List<TeamView>();
        }

        public static string JoinTeam(int playerId, int teamId)
        {
            ISession session = default;
            try
            {
                session = DataLayer.GetSession();
                Player player = session.Get<Player>(playerId);
                Team team = session.Get<Team>(teamId);
                if (player == null)
                    return "Player doesn't exist!";
                if (team == null)
                    return "Team doesn't exist!";
                if (team.Players.Count >= team.MaxPlayers)
                    return "Team is full!";
                player.Team = team;
                session.Save(player);
                return $"Player {player.Name} successfully joined team {team.Name}!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                session.Flush();
                session.Close();
            }
            return "Unknown error";
        }

        public static string LeaveTeam(int playerId)
        {
            ISession session = default;
            try
            {
                session = DataLayer.GetSession();
                Player player = session.Get<Player>(playerId);
                if (player == null)
                {
                    return "Player doesn't exist!";
                }
                Team team = player.Team;
                player.Team = null;
                session.Save(player);
                return $"Player {player.Name} successfully left team {team.Name}!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                session.Flush();
                session.Close();
            }
            return "Unknown error";
        }

        public static string SaveTeam(CompactTeamView saveTeamView)
        {
            ISession s = default;
            try
            {
                s = DataLayer.GetSession();

                Team team = new Team()
                {
                    Name = saveTeamView.Name.ToUpper(),
                    MinPlayers = saveTeamView.MinPlayers,
                    MaxPlayers = saveTeamView.MaxPlayers,
                    BonusPoints = saveTeamView.BonusPoints,
                    Placement = s.Query<Team>().Count() + 1,
                };
                s.Save(team);
                return $"Team successfully created with id {team.Id}!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return "Error";
        }

        public static CharacterView ReturnCharacterForPlayer(int playerId, bool returnMain = true)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                Player player = s.Get<Player>(playerId);
                if (player == null || player.Characters == null)
                {
                    return null;
                }
                Character? mainCharacter;
                if (returnMain)
                    mainCharacter = player.Characters
                        .Where(character => character.Assistant != 'T').FirstOrDefault();
                else
                    mainCharacter = player.Characters
                        .Where(character => character.Assistant == 'T').FirstOrDefault();
                if (mainCharacter == null)
                {
                    return null;
                }
                CharacterView characterView = new CharacterView()
                {
                    Id = mainCharacter.Id,
                    ClassName = ParseType(mainCharacter.GetType().ToString()),
                    RaceName = mainCharacter.Race,
                    Gold = mainCharacter.Gold,
                    Exp = mainCharacter.Experience,
                };
                return characterView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return null;
        }

        public static List<TeamView> ReturnAllFightableTeams(int teamId)
        {
            ISession session = default;
            try
            {
                session = DataLayer.GetSession();
                List<TeamView> teams = new List<TeamView>();
                foreach (Team team in session.Query<Team>().OrderBy(team => team.Id)
                    .Where(team => team.Players.Count >= team.MinPlayers && team.Id != teamId))
                {
                    teams.Add(new TeamView()
                    {
                        Id = team.Id,
                        Name = team.Name,
                        MinPlayers = team.MinPlayers,
                        MaxPlayers = team.MaxPlayers,
                        BonusPoints = team.BonusPoints,
                        Placement = team.Placement,
                        PlayerCount = team.Players.Count
                    });
                }
                return teams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                session.Flush();
                session.Close();
            }
            return new List<TeamView>();
        }

        public static TeamView ReturnTeam(int teamId)
        {
            ISession session = default;
            try
            {
                session = DataLayer.GetSession();
                Team team = session.Get<Team>(teamId);
                if (team == null)
                {
                    return null;
                }
                TeamView teamView = new TeamView()
                {
                    Id = team.Id,
                    Name = team.Name,
                    MinPlayers = team.MinPlayers,
                    MaxPlayers = team.MaxPlayers,
                    BonusPoints = team.BonusPoints,
                    Placement = team.Placement,
                    PlayerCount = team.Players.Count
                };
                return teamView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                session.Flush();
                session.Close();
            }
            return null;
        }

        public static string ScheduleTeamFight(int team1Id, int team2Id, double bonus, DateTime timeHeld)
        {
            ISession session = default;
            try
            {
                session = DataLayer.GetSession();
                if (team1Id == team2Id)
                {
                    return "Team 1 and Team 2 must be different!";
                }
                Team team1 = session.Get<Team>(team1Id);
                if (team1 == null)
                {
                    return "Team 1 doesn't exist!";
                }
                Team team2 = session.Get<Team>(team2Id);
                if (team2 == null)
                {
                    return "Team 2 doesn't exist!";
                }
                Fights fight = new Fights()
                {
                    Team1 = team1,
                    Team2 = team2,
                    Bonus = bonus,
                    TimeHeld = timeHeld,
                    WinningTeam = null
                };
                session.Save(fight);
                return $"Fight successfully scheduled, between teams {team1.Name} and {team2.Name}, at {timeHeld}!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                session.Flush();
                session.Close();
            }
            return "Unknown error";
        }

        public static int ExecuteAllPendingTeamFights()
        {
            ISession session = default;
            try
            {
                session = DataLayer.GetSession();
                List<Fights> fights = session.Query<Fights>()
                    .Where(fight => fight.WinningTeam == null)
                    .Where(fight => fight.TimeHeld <= DateTime.Now)
                    .ToList();
                Random random = new Random();
                foreach (Fights f in fights)
                {
                    f.WinningTeam = random.Next(0, 3);
                    session.Save(f);
                }
                return fights.Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                session.Flush();
                session.Close();
            }
            return 0;
        }

        // missing
        public static string SaveCharacter(Character character, int playerId)
        {
            ISession session = default;
            string errorMessage = "";
            try
            {
                session = DataLayer.GetSession();
                Player player = session.Get<Player>(playerId);
                if (player == null)
                {
                    return "Player doesn't exist!";
                }
                if (player.Characters.Count >= 2)
                {
                    return "Player already has main and assistant character!";
                }
                character.Player = player;
                session.Save(character);
                return $"Character successfully created, with id {character.Id}!";
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                session.Flush();
                session.Close();
            }
            return $"Error: {errorMessage}";
        }

        public static string DeleteCharacters(int playerId)
        {
            ISession session = default;
            try
            {
                session = DataLayer.GetSession();
                Player player = session.Get<Player>(playerId);
                if (player == null || player.Characters.Count == 0)
                {
                    return "Error";
                }
                foreach (Character character in player.Characters)
                {
                    session.Delete(character);
                }
                return "Character successfully deleted!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                session.Flush();
                session.Close();
            }
            return "Error";
        }

        public static bool CheckIfCharacterExists(int playerId)
        {
            ISession session = default;
            try
            {
                session = DataLayer.GetSession();
                Player player = session.Get<Player>(playerId);
                if (player == null || player.Characters.Count == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                session.Flush();
                session.Close();
            }
            return false;
        }

        public static string AddBlessingToPriest(int blessingId, int priestId)
        {
            ISession session = default;
            try
            {
                session = DataLayer.GetSession();
                Priest priest = session.Get<Priest>(priestId);
                if (priest == null)
                {
                    return "Priest doesn't exist!";
                }
                Blessing blessing = session.Get<Blessing>(blessingId);
                if (blessing == null)
                {
                    return "Blessing doesn't exist!";
                }
                UsesBlessing gives = new UsesBlessing()
                {
                    Blessing = blessing,
                    Priest = priest
                };
                blessing.UsedByPriests.Add(gives);
                session.Save(gives);
                return $"Blessing successfully added to priest {priest.Player.Nickname}!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                session.Flush();
                session.Close();
            }
            return "Unknown error";
        }

        public static string AddSpellToWizard(int spellId, int wizardId)
        {
            ISession session = default;
            try
            {
                session = DataLayer.GetSession();
                Wizard wizard = session.Get<Wizard>(wizardId);
                if (wizard == null)
                {
                    return "Wizard doesn't exist!";
                }
                Spell spell = session.Get<Spell>(spellId);
                if (spell == null)
                {
                    return "Spell doesn't exist!";
                }
                CastsSpell casts = new CastsSpell()
                {
                    Spell = spell,
                    Wizard = wizard
                };
                spell.CastByWizards.Add(casts);
                session.Save(casts);
                return $"Spell successfully added to wizard {wizard.Player.Nickname}!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                session.Flush();
                session.Close();
            }
            return "Unknown error";
        }
    }
}
