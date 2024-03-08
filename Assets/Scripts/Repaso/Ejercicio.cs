using System;
using System.Collections.Generic;
using Repaso;
using UnityEngine;

namespace Exam
{
    public abstract class Raza
    {
        
        private int _id;
        public int Id
        {
            get => _id + 1;
            set => _id = value;
        }
        
        public abstract void Move();
        public abstract void Attack();

        public virtual void Die()
        {
            Debug.Log($"The Entity has Die!");
        }
        
    }
    
    public class Human : Raza, IDestroyable
    {
        
        private int _age;
        private string _name;

        public Human(int age, string name)
        {
            _age = age;
            _name = name;
        }

        public override void Move()
        {
            Debug.Log("Human Moves");
        }
        
        public override void Attack()
        {
            Debug.Log("Humans Attack");
        }
        
        public override void Die()
        {
            base.Die();
            Debug.Log("Has gone.");
        }

        public void Scary(Aggressiveness aggressiveness)
        {
            string message;
            switch (aggressiveness)
            {
                case Aggressiveness.Null:
                    message = "Do u wanna be my friend?";
                    break;
                case Aggressiveness.Medium:
                    message = "Hey dog, i'm your friend";
                    break;
                case Aggressiveness.High:
                    message = "Oh no calm down!";
                    break;
                case Aggressiveness.Dangerous:
                    message = "Oh sh** sorry!!";
                    break;
                default:
                    message = "";
                    break;
            }
            Debug.Log(message);
        }

        public void Destroy()
        {
            Debug.Log("I'm die");
        }
    }

    public abstract class Undead : Raza
    {
        private int _damageAmount;
        public int DamageAmount
        {
            get => _damageAmount * 5;
            set => _damageAmount = value;
        }
        
        public abstract void UnDead();

        public override void Move()
        {
            Debug.Log("The Undead is Moving");
        }

        public override void Die()
        {
            Debug.Log("Dont Die, its Unable.");
        }
        
        public void RunAway(Aggressiveness aggressiveness)
        {
            if (aggressiveness == Aggressiveness.Dangerous)
            {
                Debug.Log("The Undead go away!");
            }
        }
    }

    public class Zombie : Undead
    {
        public override void Attack()
        {
            Debug.Log("Zombie is eating your brain.");
        }

        public override void UnDead()
        {
            Debug.Log("Zombie has revive.");
        }
        
        public void RunAway(Aggressiveness aggressiveness)
        {
            if (aggressiveness == Aggressiveness.Dangerous)
            {
                Debug.Log("The Zombie go away!");
            }
        }
    }

    public class Skeleton : Undead
    {
        public override void Move()
        {
            Debug.Log("Skeleton is moving.");
        }

        public override void Attack()
        {
            Debug.Log("Skeleton is shooting with an arrow!");
        }

        public override void UnDead()
        {
            Debug.Log("Skeleton is taking his own bones.");
        }
    }

    public class Dog : Raza
    {
        public event Action<Aggressiveness> OnDogBark;
        
        public override void Move()
        {
            Debug.Log("Dog's moving");
        }

        public override void Attack()
        {
            Debug.Log("Dog beat.");
        }

        public void Bark(Aggressiveness aggressiveness)
        {
            Debug.Log("The dog Bark");
            OnDogBark?.Invoke(aggressiveness);
        }
    }

    public enum Aggressiveness
    {
        Null,
        Medium,
        High,
        Dangerous,
    }

    public class Block : IDestroyable
    {
        public int Id;
        public string Name;
        
        public void Destroy()
        {
            Debug.Log("Destroy Block");
        }
    }

    public interface IDestroyable
    {
        void Destroy();
    }

    public abstract class Licor
    {
        private int _cantidadSal;
        private int _cantidadAzucar;
        private int _cantidadAlcohol;
        private float _cantidadAgua;

        public Licor( int cantidadSal, int cantidadAzucar,
            int cantidadAlcohol, float cantidadAgua )
        {
            _cantidadSal = cantidadSal;
            _cantidadAzucar = cantidadAzucar;
            _cantidadAlcohol = cantidadAlcohol;
            _cantidadAgua = cantidadAgua;
        }
        
        public abstract void Tomar();
    }
    
    public class Guaro : Licor
    {

        public Guaro( float cantidad ) 
            : base(0, 30, 24, cantidad)
        {}
        
        public override void Tomar()
        {
            Debug.Log("Mareo ecstraordinarioas");
        }
    }

    public class Ron : Licor
    {
        private int _cantidadDeMadera;

        public Ron(float cantidad, int cantidadDeMadera)
            : base(0, 50, 35, cantidad)
        {
            _cantidadDeMadera = cantidadDeMadera;
        }
        
        public override void Tomar()
        {
            Debug.Log("Se le va la gripa");
        }
    }

    public class Chamber : Licor
    {
        private float _cantidadFrutino;

        public Chamber(int cantidad, float cantidadFrutino)
            : base(2, 50, cantidad, 0)
        {
            _cantidadFrutino = cantidadFrutino;
        }
        
        public override void Tomar()
        {
            Debug.Log("Se mata X.X");
        }
    }

    public class Granisao
    {
        public List<Licor> licores;
    }
    
    public class Test
    {
        public void Main()
        {
            IDestroyable block = new Block();
            IDestroyable human = new Human(12, "Juan");
            
            Guaro antioqueno = new Guaro(750);
            Ron viejoDeCaldas = new Ron(200, 12);
            Ron ronDeMedellin = new Ron(750, 0);
            Chamber chamberDelMigue = new Chamber(100, 52);

            Granisao granisaoEspecialDelMigue = new Granisao();
            granisaoEspecialDelMigue.licores.Add(antioqueno);
            granisaoEspecialDelMigue.licores.Add(chamberDelMigue);
            
            
        }
    }
}
