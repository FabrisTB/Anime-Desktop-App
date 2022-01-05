﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.VisualBasic;

namespace MyAnimeList.ResponseObjects.Forum
{
    [DataContract]
    public class Poll
    {
        public Poll(string id, string question, string closed, List<Option> options)
        {
            this.Id = id;
            this.Question = question;
            this.Closed = closed;
            this.Options = options;
        }

        [DataMember]
        public string Id { get; }

        [DataMember]
        public string Question { get; }

        [DataMember]
        public string Closed { get; }

        [DataMember]
        public IReadOnlyList<Option> Options { get; }

        public override string ToString()
        {
            return $"Id: {Id}, "
                   + $"Question: {Question}"
                   + $"Closed: {Closed}"
                   + $"Options: {(Options != null ? string.Join(" | ", Options) : "N/A")}"
                ;
        }
    }
}