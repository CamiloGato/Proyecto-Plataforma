using UnityEngine;

namespace Repaso
{
    public class Personaje
    {
        public int vida;
        private int _score;

        public int Score
        {
            get => _score * 10;
            set => _score = value - 1;
        }
        
        private int _nivel = 3;

        public int Nivel
        {
            get => _nivel;
            set => _nivel = value;
        }

        public void CambiarVida(int cuantaVida, int value)
        {
            int nuevaVariable = 2;
            vida = cuantaVida;
            Score += 10;
            Nivel--;

            Mathf.Asin(10);
        }
        
    }
}