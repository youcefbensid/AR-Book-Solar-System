using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lune : MonoBehaviour
{
    public GameObject terre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Lune tourne sur elle meme
        transform.Rotate(0, 25 * Time.deltaTime, 0, Space.Self);
        //Lune tourne autour de la terre
        transform.RotateAround(terre.transform.position, terre.transform.up, 50 * Time.deltaTime);

    }
}
