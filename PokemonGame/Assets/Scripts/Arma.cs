using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arma : MonoBehaviour
{
    public float velocidadBala = 60f;
    public GameObject bala;
    public bool activo;
 

    // Update is called once per frame
    void Update()
    {
        if (activo) {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Disparar();
            }
        }
        
    }


    public void Disparar() {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        GameObject balaClon = (GameObject)Instantiate(bala, mouseRay.origin, Quaternion.identity);
        Rigidbody rb = balaClon.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = mouseRay.direction * velocidadBala;
        }
        Destroy(balaClon.gameObject, 2f);
    }
}
