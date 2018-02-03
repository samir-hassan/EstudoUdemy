using _02_;
using _02_.Modelo;
using System;
using System.Collections.Generic;

namespace _02_Generics
{
    internal class Generics
    {
        internal void Execute()
        {
            Carro carro = new Carro { marca = "Fiat", modelo = "Uno" };
            Carro carroAA = new Carro { marca = "Honda", modelo = "Civic" };

            Casa casa = new Casa { Cidade = "São Paulo", Endereco = "Rua Plinio Colas" };
            Usuario usuario = new Usuario { Email = "samir@live", Nome = "Samir", Senha = "123" };

            List<Carro> ListaCarro = new List<Carro>();
            ListaCarro.Add(carro);
            ListaCarro.Add(carroAA);

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);
            Serializador.Serializar(ListaCarro);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();
            List<Carro> ListaCarro2 = Serializador.Deserializar<List<Carro>>();
        }
    }
}