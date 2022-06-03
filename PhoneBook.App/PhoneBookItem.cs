﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{
    internal class PhoneBookItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Addres> Addresses { get; set; }
        public List<string> Groups { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PhoneBookItem()
        {
            Phones = new List<Phone>();
            Addresses = new List<Addres>();
            Groups = new List<string>();
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="patronymic"></param>
        /// <param name="phones"></param>
        /// <param name="addresses"></param>
        /// <param name="groups"></param>
        public PhoneBookItem(string firstName, string lastName, string patronymic, List<Phone> phones, List<Addres> addresses, List<string> groups)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Phones = phones;
            Addresses = addresses;
            Groups = groups;
        }
        

    }
}
