using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leftrightarrows : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.LeftArrow))
       {
        Debug.Log("LeftArrow");
        m_Rigidbody.AddForce(Vector3.left * 200);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("RightArrow");
            m_Rigidbody.AddForce(Vector3.right * 200);
        }
    
         if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("DownArrow");
            m_Rigidbody.AddForce(Vector3.down* 200);
        }  
    }
}