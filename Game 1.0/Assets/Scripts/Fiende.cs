using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fiende : MonoBehaviour {

    private int x;

    private void Start()
    {
        int Sdirection = Random.Range(-1, 1);

        if (Sdirection < 0)
            x = 1;
        else
            x = -1;       
    }

    private void Update()
    {
        Move(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (x == 1)
            x = -1;
        else if (x == -1)
            x = 1;
    }

    public void Move(GameObject Fiende, float speed = 3)
    {     
        Vector3 direction = new Vector3(x, 0, 0); 
        direction = direction.normalized * speed; 
        Fiende.GetComponent<Rigidbody2D>().velocity = direction;
    }
}
