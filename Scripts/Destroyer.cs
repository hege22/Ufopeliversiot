using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    public float lifetime;

    private void Start()
    {
        Destroy(gameObject, lifetime); //tuhoaa gameobjectit, etteivät ne jää lojumaan ja kuormittamaan peliä.
    }

}