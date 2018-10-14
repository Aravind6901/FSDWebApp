using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FSDWebApp.Models;

namespace FSDWebApp.ViewModels
{
    public class GigFromViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}