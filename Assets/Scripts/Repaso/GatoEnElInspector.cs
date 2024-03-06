using System;
using UnityEngine;

namespace Repaso
{
    public class GatoEnElInspector : MonoBehaviour
    {
        public Rigidbody2D _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            
            GatitoMalo gatitoMalito = new GatitoMalo( _rb );
            GatitoMalo gatitoMalo2 = new GatitoMalo( _rb );
            gatitoMalito.AgregarFuerza();
        }
    }
}