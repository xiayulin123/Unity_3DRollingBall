using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject Win;
    public GameObject play_again;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Clicked()
    {
        SceneManager.LoadScene("SampleScene");
        Win.SetActive(false);
        play_again.SetActive(false);
    }
}
