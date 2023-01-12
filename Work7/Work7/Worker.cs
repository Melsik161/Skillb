using System;
using System.Collections.Generic;
using System.Text;

namespace Work7
{
    struct Worker
    {
        //public Worker(int id, DateTime dateCreate, string FIO, byte age, byte height, string birthday, string pBirth)
        //{
        //    this.id = id;
        //    this.dateCreate = dateCreate;
        //    this.FIO = FIO;
        //    this.age = age;
        //    this.height = height;
        //    this.birthday = birthday;
        //    this.pBirth = pBirth;
        //}
        public int id { get; set; }
        public DateTime dateCreate { get; set; }
        public string FIO { get; set; }
        public byte age { get; set; }
        public byte height { get; set; }
        public string birthday { get; set; }
        public string pBirth { get; set; }

    }
}
