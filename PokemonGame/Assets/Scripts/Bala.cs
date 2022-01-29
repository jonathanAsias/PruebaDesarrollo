using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "CapsulePokemon") {
            player = collision.gameObject;
            player.GetComponent<MeshRenderer>().material = player.GetComponent<Pokemon>().dead;
            StartCoroutine(revivir());
        }
    }

    IEnumerator revivir() {
        yield return new WaitForSeconds(1f);
        player.GetComponent<MeshRenderer>().material = player.GetComponent<Pokemon>().live;
        Arma arma = GameObject.FindObjectOfType<Arma>();
        Card card = GameObject.FindObjectOfType<Card>();
        arma.activo = false;
        card.atacar.interactable = true;

    }
}
