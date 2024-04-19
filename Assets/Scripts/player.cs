using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class player : MonoBehaviour
{

    public float speed;

    Rigidbody rb;

    float xInput;
    float yInput;

    int score = 0;
    public int winScore = 5;
    public TMP_Text scoreText;

    public GameObject Win;
    public GameObject play_again;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5f)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        rb.AddForce(xInput * speed, 0, yInput * speed);


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "goal")
        {
            other.gameObject.SetActive(false);

            score++;
            scoreText.text = score.ToString();

            if (score == winScore)
            {
                Win.SetActive(true);
                play_again.SetActive(true);
            }
        }
    }
}
