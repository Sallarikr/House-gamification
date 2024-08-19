using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pariovienhallintakoodi : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Oven haku ja avaaminen jos pelaaja törmää collideriin
        if (other.name.Equals("Pelaaja"))
        {
            GameObject.Find("Pariovi1").GetComponent<Animator>().SetInteger("Pariovi1tila", 1);
            GameObject.Find("Pariovi2").GetComponent<Animator>().SetInteger("Pariovi2tila", 1);
        } // if
    } // OnTriggerEnter

    private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("Pelaaja"))
        {
            GameObject.Find("Pariovi1").GetComponent<Animator>().SetInteger("Pariovi1tila", 0);
            GameObject.Find("Pariovi2").GetComponent<Animator>().SetInteger("Pariovi2tila", 0);
        } // if
    } // OnTriggerExit
} // class
