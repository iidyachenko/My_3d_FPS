using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class InputController : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetButtonDown("SwitchFlashlight"))
                Main.Instance.FlashlightController.SwitchFlashlight();
        }
    }
}

