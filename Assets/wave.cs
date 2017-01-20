using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour
{
    public GameObject explosion;
    public float delaytime = 1;
    private float deltatime = 0;
    // Use this for initialization
    void Start()
    {

    }
   
    // Update is called once per frame
    void Update()
    {
        deltatime += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && deltatime >= delaytime)
        {
            GameObject waveCopy = null;
            waveCopy = Instantiate(explosion, transform.position, new Quaternion(0, 0, 0, 0));
            deltatime = 0;
        }
    }
}
