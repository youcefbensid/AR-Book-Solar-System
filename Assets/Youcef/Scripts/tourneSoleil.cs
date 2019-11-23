using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tourneSoleil : MonoBehaviour
{

    public GameObject soleil;
    public int vitesse;
    bool tuPxTourner = false;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("tourne", 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (tuPxTourner)
        {
            transform.RotateAround(soleil.transform.position, soleil.transform.up, vitesse * Time.deltaTime);
        }
        
    }

    void tourne()
    {
        if (tuPxTourner == false)
        {
            tuPxTourner = true;
        }
        else
        {
            tuPxTourner = false;
        }
    }

}
