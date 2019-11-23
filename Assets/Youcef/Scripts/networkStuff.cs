using UnityEngine;
using System.Collections;

public class AddToStadium : MonoBehaviour
{

    void Start()
    {
        GameObject stadium = GameObject.FindGameObjectWithTag("Stadium");
        transform.SetParent(stadium.transform, true);
    }
}