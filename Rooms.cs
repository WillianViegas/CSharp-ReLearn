using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Rooms
    {
        private string Nome { get; set; }
        private string Email { get; set; }
        private int Quarto { get; set; }

        public Rooms()
        {
        }

        public Rooms(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return Quarto
                + ": "
                + Nome
                + ", "
                + Email;
        }
    }
}
