using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AddedGameScript : MonoBehaviour
{
    public GameObject Character;
    public GameObject particleprefabs;
    public Text timertext;
    public Text scoretext;
    private int Score;

    private float timer = 30f;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timertext.GetComponent<Text>().text = "Time left: " + Mathf.Round(timer);
        scoretext.GetComponent<Text>().text = "Score: " + Score;

        if (Score == 80)
        {
            SceneManager.LoadScene("GameWin");
        }
        if (Character.transform.position.y < -2)
        {
            SceneManager.LoadScene("GameLose");
        }
        if (timer <= 0)
        {
            SceneManager.LoadScene("GameLose");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Instantiate(particleprefabs, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Score += 10;
        }
    }
}
