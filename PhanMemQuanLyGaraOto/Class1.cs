﻿using System.Collections.Generic;

namespace PhanMemQuanLyGaraOto
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class ListUser
    {
        public bool isCheckd { get; set; }
        public int SelectedIndex { get; set; }
        public List<User> ListU { get; set; }

    }
}
