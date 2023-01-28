using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_spawner : MonoBehaviour
{
    public GameObject pipe;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn()
    {
        if (GameObject.Find("pajarillo").GetComponent<Scr_player>().volando)
        {
            Instantiate(pipe, new Vector3(14, Random.Range(-1.89f, 3.34f), -1), Quaternion.Euler(0, 0, 0));
        }
    }
}
