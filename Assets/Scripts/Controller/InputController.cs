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

            if (Input.GetButtonDown("Action") && Main.Instance.PlayerController.hit.collider != null)
                Main.Instance.PlayerController.Get_Object(Main.Instance.PlayerController.hit);
        }
    }
}

