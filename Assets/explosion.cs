using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public GameObject ExplosionAnimation;
    private int exist = 0;
   
    // Use this for initialization
    void Start()
    {
        
    }

    public float explosionSpeed =1f;
    // Update is called once per frame
    void Update()
    {
        if(exist == 0)
        {
            Instantiate(ExplosionAnimation);
            exist = 1;
        }
        
        transform.localScale *= (1 + (explosionSpeed * Time.deltaTime));
        if (transform.localScale.x > 9f)
        {
            DestroyObject(ExplosionAnimation);
            DestroyObject(this.gameObject);
        }
    }
}
