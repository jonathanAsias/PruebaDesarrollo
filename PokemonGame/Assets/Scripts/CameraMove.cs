using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float sensibilidadMouse;
    public float rotacionX;
    public float rotacionY;
    public Transform pokemon;
    public float distanciaZ;
    public Vector3 rotacionActual;
    public Vector3 vectorSuavidad;
    public float suavidadMovimiento;
    public bool activated;
    
    void Update()
    {
        if (activated) {
            float mouseX = Input.GetAxis("Mouse X") * sensibilidadMouse;
            float mouseY = Input.GetAxis("Mouse Y") * sensibilidadMouse;

            rotacionX += mouseY;
            rotacionY += mouseX;

            rotacionX = Mathf.Clamp(rotacionX, -40, 40);

            Vector3 nextRotacion = new Vector3(rotacionX, rotacionY, 0);
            rotacionActual = Vector3.SmoothDamp(rotacionActual, nextRotacion, ref vectorSuavidad, suavidadMovimiento);
            transform.localEulerAngles = rotacionActual;

            transform.position = pokemon.position - transform.forward * distanciaZ;
        }
        
    }
}

