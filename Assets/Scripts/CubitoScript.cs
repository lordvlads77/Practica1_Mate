using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubitoScript : MonoBehaviour
{
    bool Subir = false;
    bool Bajar = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Subir)
        {

            transform.localScale = new Vector3(transform.localScale.x + (3 * Time.deltaTime), transform.localScale.y + (3 * Time.deltaTime));
            transform.position += new Vector3(0, 3 * Time.deltaTime, 0);
            
        }

        if (Bajar)
        {

            transform.localScale = new Vector3(transform.localScale.x - (3 * Time.deltaTime), transform.localScale.y - (3 * Time.deltaTime));
            transform.position -= new Vector3(0, 3 * Time.deltaTime, 0);

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Subir = true;
            Bajar = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Bajar = true;
            Subir = false;
        }

    }
}
