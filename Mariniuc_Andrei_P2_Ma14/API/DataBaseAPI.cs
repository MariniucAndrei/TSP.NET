using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public class DataBaseAPI
    {
        public void Create(string table, string name, string date, string path, string isDeleted, int idZone, int idGroup, int idEvent)
        {
            using (PhotosContainer db = new PhotosContainer())
            {
                if (table.Equals("Medias"))
                {
                    var photo = new Medias
                    {
                        NamePhoto = name,
                        Date = date,
                        Path = path,
                        IsDeleted = isDeleted,
                        ZonesId = idZone,
                        PeopleGroupsId = idGroup,
                        EventsId = idEvent
                    };
                    db.Medias.Add(photo);
                    db.SaveChanges();
                }
            }
        }
        public void CreateNew(string table, string name, string id)
        {
            using (var db = new PhotosContainer())
            {
                if (table.Equals("Events"))
                {
                    var events = new Events { EventName = name, IdMedia = id };
                    db.Events.Add(events);
                    db.SaveChanges();
                }
                if (table.Equals("PeopleGroups"))
                {
                    var group = new PeopleGroups { PeopleName = name, IdMedia = id };
                    db.PeopleGroups.Add(group);
                    db.SaveChanges();
                }
                if (table.Equals("Zones"))
                {
                    var zone = new Zones { LocationName = name, IdMedia = id };
                    db.Zones.Add(zone);
                    db.SaveChanges();
                }
            }
        }
        public string Read(string table)
        {
            using (var db = new PhotosContainer())
            {
                if (table.Equals("Medias"))
                {
                    var query = from medias in db.Medias
                                orderby medias.NamePhoto
                                select medias;

                    Console.Write("Photos in database: ");

                    foreach (var item in query)
                    {
                        return item.Path;
                    }
                }
                if (table.Equals("Events"))
                {
                    var query = from events in db.Events
                                orderby events.EventName
                                select events;

                    Console.Write("Events in database: ");

                    foreach (var item in query)
                    {
                        return item.EventName;
                    }
                }
                if (table.Equals("PeopleGroups"))
                {
                    var query = from peoplegroups in db.PeopleGroups
                                orderby peoplegroups.PeopleName
                                select peoplegroups;

                    Console.Write("People in database: ");

                    foreach (var item in query)
                    {
                        return item.PeopleName;
                    }
                }
                if (table.Equals("Zones"))
                {
                    var query = from zones in db.Zones
                                orderby zones.LocationName
                                select zones;

                    Console.Write("Zones in database: ");

                    foreach (var item in query)
                    {
                        return item.LocationName;
                    }
                }
            }
            return "Error";
        }
        public void Update(string name, string NewName)
        {
            using (var db = new PhotosContainer())
            {
                var obj = from medias in db.Medias
                            orderby medias.NamePhoto
                            where medias.NamePhoto == name 
                            select medias;

                foreach (var item in obj)
                {
                    if (item.NamePhoto == name)
                    {
                        item.NamePhoto = NewName;
                    }
                }
                db.SaveChanges();
            }
        }
        public void Delete(string table, string name)
        {
            using (var db = new PhotosContainer())
            {
                if (table.Equals("Medias"))
                {
                    var obj = from medias in db.Medias
                              orderby medias.NamePhoto
                              where medias.NamePhoto == name
                              select medias;

                    foreach (var item in obj)
                    {
                        db.Medias.Remove(item);
                    }
                    db.SaveChanges();
                }
                if (table.Equals("Events"))
                {
                    var obj = from events in db.Events
                              orderby events.EventName
                              where events.EventName == name
                              select events;

                    foreach (var item in obj)
                    {
                        db.Events.Remove(item);
                    }
                    db.SaveChanges();
                }
                if (table.Equals("PeopleGroups"))
                {
                    var obj = from peoplegroups in db.PeopleGroups
                              orderby peoplegroups.PeopleName
                              where peoplegroups.PeopleName == name
                              select peoplegroups;

                    foreach (var item in obj)
                    {
                        db.PeopleGroups.Remove(item);
                    }
                    db.SaveChanges();
                }
                if (table.Equals("Zones"))
                {
                    var obj = from zones in db.Zones
                              orderby zones.LocationName
                              where zones.LocationName == name
                              select zones;

                    foreach (var item in obj)
                    {
                        db.Zones.Remove(item);
                    }
                    db.SaveChanges();
                }
            }
        }
        public string Search(string table, string name)
        {
            using (var db = new PhotosContainer())
            {
                if (table.Equals("Medias"))
                {
                    var obj = from medias in db.Medias
                              orderby medias.NamePhoto
                              where medias.NamePhoto == name
                              select medias;

                    foreach (var item in obj)
                    {
                        return item.Path;
                    }
                }
                if (table.Equals("Events"))
                {
                    var obj = from events in db.Events
                              orderby events.EventName
                              where events.EventName == name
                              select events;
                    
                    foreach (var item in obj)
                    {
                        return item.EventName;
                    }
                }
                if (table.Equals("Zones"))
                {
                    var obj = from zones in db.Zones
                              orderby zones.LocationName
                              where zones.LocationName == name
                              select zones;

                    foreach (var item in obj)
                    {
                        return item.LocationName;
                    }
                }
                if (table.Equals("PeopleGroups"))
                {
                    var obj = from peoplegroups in db.PeopleGroups
                              orderby peoplegroups.PeopleName
                              where peoplegroups.PeopleName == name
                              select peoplegroups;

                    foreach (var item in obj)
                    {
                        return item.PeopleName;
                    }
                }
                return "Error";
            }
        }
        public string Filter(string name, string date, string path, string isDeleted, int idZone, int idGroup, int idEvent)
        {
            using (var db = new PhotosContainer())
            {
                var obj = from medias in db.Medias
                          orderby medias.NamePhoto
                          where medias.NamePhoto == name && 
                          medias.Date == date &&
                          medias.Path == path &&
                          medias.IsDeleted == isDeleted &&
                          medias.ZonesId == idZone &&
                          medias.PeopleGroupsId == idGroup &&
                          medias.EventsId == idEvent
                          select medias;

                foreach (var item in obj)
                {
                    return item.Path;
                }

                return "Error";
            }
        }
        public void Save()
        {
            using (var db = new PhotosContainer())
            {
                db.SaveChanges();
            }
        }
    }
}
