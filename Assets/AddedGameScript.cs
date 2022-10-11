using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AddedGameScript : MonoBehaviour
{

    private int Score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            Score += 10;
            print("test");
        }
    }
}
