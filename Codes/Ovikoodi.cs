using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ovikoodi : MonoBehaviour
{
    void Start()
    {
        
    } // Start

    void Update()
    {
        // Ovi auki A-näppäimellä
        if(Input.GetKeyDown(KeyCode.O)) {
            this.GetComponent<Animator>().SetInteger("Ovitila1", 1);
        } // if

        // Ovi kiinni K-näppäimellä
        if (Input.GetKeyDown(KeyCode.K))
        {
            this.GetComponent<Animator>().SetInteger("Ovitila1", 0);
        } // if
    } // Update
} // class
