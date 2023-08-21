using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bola : MonoBehaviour
{

    public float velocidadeDaBola=400;
    public Rigidbody2D oRigidbody2D;

    public AudioSource somDaBola;

    // Start is called before the first frame update
    void Start()
    {
        oRigidbody2D.velocity = new Vector2(velocidadeDaBola,velocidadeDaBola )*Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        somDaBola.Play();
    }      

    
}
