using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FärgSwitchColl : MonoBehaviour {
   
    //Välj antalfärger i inspector
    public Color[] DMGcollors;
    private float colortime = 1f;
    private bool dmg = false;
    
    private void Update()
    {
        if (dmg)
        {
            colortime -= Time.deltaTime;
            if (colortime <= 0)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.white;
                colortime = 1;
                dmg = false;
            }
        }       
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Fiende")
        {
            if (gameObject.tag != "Fiende")
            {
                gameObject.GetComponent<Renderer>().material.color = DMGcollors[Random.Range(0, DMGcollors.Length)];
                dmg = true;
            }
        }
        else if (coll.gameObject.tag == "Main")
        {
            gameObject.GetComponent<Renderer>().material.color = DMGcollors[Random.Range(0, DMGcollors.Length)];
            dmg = true;
        }
    }
}
