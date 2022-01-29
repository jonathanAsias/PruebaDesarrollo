using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public Material live, dead;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select stage    
                if (hit.transform.name == "CapsulePokemon")
                {
                    CameraMove camara = GameObject.FindObjectOfType<CameraMove>();
                    if (!camara.activated)
                    {
                        camara.activated = true;
                    }
                    else {
                        camara.activated = false;
                    }
                    
                }
            }
        }
    }
}
