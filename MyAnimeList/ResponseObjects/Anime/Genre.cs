﻿using System.Runtime.Serialization;

namespace MyAnimeList.ResponseObjects.Anime
{
    [DataContract]
    public class Genre
    {
        public Genre(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        [DataMember]
        public int Id { get; }

        [DataMember]
        public string Name { get; }
        
        public override string ToString()
        {
            return $"Id: {Id}, "
                   + $"Name: {Name}"
                ;
        }
    }
}