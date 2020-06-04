﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace TestForCompanies.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Uf { get; set; }
        public string TradingName { get; set; }
        public string Cnpj { get; set; }
        public ICollection<Purveyor> Purveyors { get; set; } = new List<Purveyor>();

        public Company()
        {
        }

        public Company(int id, string uf, string tradingName, string cnpj)
        {
            Id = id;
            Uf = uf;
            TradingName = tradingName;
            Cnpj = cnpj;
        }

        public void AddPurveyor(Purveyor purveyor)
        {
            Purveyors.Add(purveyor);
        }

        public void RemovePurveyor(Purveyor purveyor)
        {
            Purveyors.Remove(purveyor);
        }
    }
}
