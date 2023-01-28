using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_pipes : MonoBehaviour
{
    public float velocidadpipe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(velocidadpipe * Time.deltaTime, 0, 0);
        if (transform.position.x <= -14)
        {
            Destroy(gameObject);
        }
    }
}
