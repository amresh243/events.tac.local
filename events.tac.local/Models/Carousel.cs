﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace events.tac.local.Models
{
  public class Carousel
  {
    public string Image { get; set; }
    public string Title { get; set; }
    public string Intro { get; set; }
    public string Url { get; set; }
    public bool IsActive { get; set; }
  }
}