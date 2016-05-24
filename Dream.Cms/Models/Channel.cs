using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Dream.Cms
{
    public class Channel : EntityBase
    {
        [Display(Name = "频道名称")]
        public string ChannelName { get; set; }
    }
}
