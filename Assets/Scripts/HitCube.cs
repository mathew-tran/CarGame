using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCube : MonoBehaviour
{
    private Color[] OnHitColors = { Color.green, Color.blue, Color.cyan, Color.magenta };

    private bool bCanHit = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (bCanHit)
        {
            if (other.CompareTag("Car"))
            {
                GetComponent<Renderer>().material.color = OnHitColors[Random.Range(0, OnHitColors.Length)];
                bCanHit = false;
            }
        }
     
    }
}
