using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class Main : MonoBehaviour
    {
        public static Main Instance { get; private set;}
        public FlashlightController FlashlightController { get; private set; }
        public InputController InputController { get; private set; }
        public PlayerController PlayerController { get; private set; }

        private void Awake()
        {
            if (Instance) DestroyImmediate(gameObject);
            else Instance = this;
        }

        private void Start()
        {
            FlashlightController = gameObject.AddComponent<FlashlightController>();
            InputController = gameObject.AddComponent<InputController>();
            PlayerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

    }
}

