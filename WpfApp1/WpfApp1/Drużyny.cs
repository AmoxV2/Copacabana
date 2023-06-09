﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Drużyna
    {
        protected static int generatorId = 0;
        public string Nazwa { get; private set; }
        public int Id { get; private set; }
        
        protected int GenerujId()
        {
            return generatorId++;
        }
        public Drużyna(string nazwa)
        {
            Nazwa = nazwa;
            Id = GenerujId();
        }

        public override string ToString()
        {
            return Nazwa;
        }

    }

    public class RejestrDrużyn
    {
        private List<Drużyna> drużyny;
        public RejestrDrużyn()
        {
            drużyny = new List<Drużyna>();
        }
        public void DodajDrużyne(Drużyna nowaDrużyna) => drużyny.Add(nowaDrużyna);
        public void UsuńDrużyne(int idDrużyny)
        {
            foreach (Drużyna d in drużyny)
            {
                if (d.Id == idDrużyny)
                {
                    drużyny.Remove(d);
                    return;
                }
            }
        }
        public Drużyna GetDrużyna(int idDrużyny)
        {
            foreach (Drużyna d in drużyny)
            {
                if (d.Id == idDrużyny)
                {
                    return d;
                }
            }

            return null;
        }
        public List<Drużyna> GetListaDrużyn()
        {
            return drużyny;
        }
        public int IlośćDrużyn()
        {
            return drużyny.Count;
        }
    }
}


