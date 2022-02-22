using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ballfell : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void reset()
    {
        Debug.Log("You are dead");
        SceneManager.LoadScene(0);
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -8) //The -8 can be any negative vale of your choice
        {
            reset();
        }

    }
}
