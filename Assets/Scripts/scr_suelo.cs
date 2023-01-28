using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_suelo : MonoBehaviour
{
    public GameObject suelo1;
    public GameObject suelo2;
    public GameObject suelo3;
    public GameObject suelo4;
    public GameObject suelo5;
    public GameObject suelo6;
    public GameObject suelo7;

    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        suelo1.transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);
        suelo2.transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);
        suelo3.transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);
        suelo4.transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);
        suelo5.transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);
        suelo6.transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);
        suelo7.transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);

        if (suelo1.transform.position.x <= -12)
        {
            suelo1.transform.position = new Vector3(suelo7.transform.position.x + 3.35f, suelo7.transform.position.y, -2);
        }
        if (suelo2.transform.position.x <= -12)
        {
            suelo2.transform.position = new Vector3(suelo1.transform.position.x + 3.35f, suelo1.transform.position.y, -2);
        }
        if (suelo3.transform.position.x <= -12)
        {
            suelo3.transform.position = new Vector3(suelo2.transform.position.x + 3.35f, suelo2.transform.position.y, -2);
        }
        if (suelo4.transform.position.x <= -12)
        {
            suelo4.transform.position = new Vector3(suelo3.transform.position.x + 3.35f, suelo3.transform.position.y, -2);
        }
        if (suelo5.transform.position.x <= -12)
        {
            suelo5.transform.position = new Vector3(suelo4.transform.position.x + 3.35f, suelo4.transform.position.y, -2);
        }
        if (suelo6.transform.position.x <= -12)
        {
            suelo6.transform.position = new Vector3(suelo5.transform.position.x + 3.35f, suelo5.transform.position.y, -2);
        }
        if (suelo7.transform.position.x <= -12)
        {
            suelo7.transform.position = new Vector3(suelo6.transform.position.x + 3.35f, suelo6.transform.position.y, -2);
        }
    }
}
