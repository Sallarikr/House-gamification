using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ovenhallintakoodi : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Oven haku ja avaaminen jos pelaaja törmää collideriin
        if (other.name.Equals("Pelaaja")) { 
            GameObject.Find("Etuovi").GetComponent<Animator>().SetInteger("Ovitila1", 1);
        } // if
    } // OnTriggerEnter

    private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("Pelaaja")) {
            GameObject.Find("Etuovi").GetComponent<Animator>().SetInteger("Ovitila1", 0);
        } // if
    } // OnTriggerExit
} // class
