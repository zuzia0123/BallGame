using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
   [SerializeField, Tooltip("dodaj predkosc")]
    private int przyspieszO = 200;

    bool kolizja;
    Rigidbody m_Rigidbody;
   
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if (kolizja)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Debug.Log("ArrowUp");
                m_Rigidbody.AddForce(Vector3.up * przyspieszO);
                kolizja = false;
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(0);
            }
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        kolizja = true;
    }

    void OnCollisionExit(Collision collision)
    {
        kolizja = false;
    }
}
