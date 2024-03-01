using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class UIManager : MonoBehaviour
    {
        public UITest ui;
        public PlayerVariables variables;
        public LifeController lifeController;
        private void Start()
        {
            variables.Initialize();
            ui.Initialize(lifeController, variables);
            ui.Subscribe();
            variables.SetUp();
        }
    }
}