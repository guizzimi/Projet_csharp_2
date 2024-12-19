using System;

namespace Projet_csharp_2.entity
{
    internal class Agence
    {
        static int nextid = 1;
        protected int Id { get; set; }
        protected string Code { get; set; }
        protected string Libelle { get; set; }

        public Agence(string code)
        {
            this.Id = nextid++;
            this.Code = code;
            this.Libelle = GenerLibelle(code);
        }

        private string GenerLibelle(string code)
        {
            string prefix = code.Length >= 3 ? code.Substring(0, 3) : code; 
            return $"{Id} - {prefix}";
        }

        public int GetId()
        {
            return this.Id;
        }

        public string GetCode()
        {
            return this.Code;
        }

        public void SetCode(string code)
        {
            this.Code = code;
        }

        public string GetLibelle()
        {
            return this.Libelle;
        }

        public void SetLibelle(string libelle)
        {
            this.Libelle = libelle;
        }

        public override string ToString()
        {
            return $"Agence [ID: {Id}, Code: {Code}, Libelle: {Libelle}]";
        }
    }
}
