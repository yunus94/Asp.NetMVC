using Asp.NetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.NetMVC.ViewsModels
{
    public class HomePageViewModel
    {
        public Person Persons { get; set; }
        public Address Addresss { get; set; }

    }
}