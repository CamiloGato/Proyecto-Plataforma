using System;
using UnityEngine;

namespace Repaso
{
    public abstract class Raza
    {
        private event Action<string, string> OnEvento;
        
        public void F1(string a, string b) {}
        public void F2(string c, string d){}

        public int Suma(float n1, float n2) => (int) n1 + (int) n2;
        public int Multi(float n1, float n2) => (int) n1 * (int) n2;
        public int Resta(float n1, float n2) => (int) n1 - (int) n2;
        
        public string Nombre;

        private int _score;
        public int Score
        {
            get => _score * 3;
            set => _score = value - 1;
        }

        public void DecirNombre()
        {
            OnEvento += F1;
            OnEvento += F2;
            OnEvento += OtroInvitado;
            OnEvento += EjecutarAlgo;
            
            OnEvento?.Invoke("Inicia la", "Fiesta");
            
        }

        private void EjecutarAlgo(string arg1, string arg2)
        {
            
        }

        private void OtroInvitado(string arg1, string arg2)
        {
            
        }

        public abstract void Atacar();

    }

    public class Humanos : Raza
    {
        
        public void Saludar()
        {
            Score = 5;
            Score = 2;
            Nombre = "Chocoflow";
            
            Debug.Log($"{Score}");
            Debug.Log($"Klk wawawa soy {Nombre}");
            
        }

        public override void Atacar()
        {
            
        }
    }
}

