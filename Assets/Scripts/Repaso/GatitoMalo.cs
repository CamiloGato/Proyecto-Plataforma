using UnityEngine;

namespace Repaso
{
    public class GatitoMalo
    {
        private Rigidbody2D _rb;

        public GatitoMalo( Rigidbody2D rigidbody )
        {
            _rb = rigidbody;
        }

        public void AgregarFuerza()
        {
            _rb.AddForce(Vector2.up * 10000f);
        }
        
    }
}