using Unity.VisualScripting;
using UnityEngine;

namespace Repaso
{
    public class Raza
    {
        public string Nombre;

        private int _score;
        public int Score
        {
            get => _score * 3;
            set => _score = value - 1;
        }

        public void Start()
        {
            // algo
            Debug.Log("algo");
        }
        
    }

    public class Humanos : Raza
    {

        public Rigidbody Rb;
        
        public void Saludar()
        {
            Score = 5;
            Score = 2;
            Nombre = "Chocoflow";
            
            Rb.AddForce(Vector3.up);
            Rb.position = Vector3.zero;
            
            Debug.Log($"{Score}");
            Debug.Log($"Klk wawawa soy {Nombre}");
        }
    }
    
}