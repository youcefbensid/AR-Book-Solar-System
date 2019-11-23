using UnityEngine;
using System.Collections;

public class network : MonoBehaviour
{

    void Start()
    {
        GameObject stadium = GameObject.FindGameObjectWithTag("Stadium");
        transform.SetParent(stadium.transform, false);
    }
}