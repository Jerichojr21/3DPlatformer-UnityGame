using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreLevel2 : MonoBehaviour
{
    public float score;
    public Text scoreUI;
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
        if(collision.collider.CompareTag("virus"))
        {
            score += 10;
            scoreUI.text = "Score : " + score.ToString();
            Destroy(collision.collider.gameObject);

            if(score >= 500)
            {
                SceneManager.LoadScene(4);
            }
        }
    }
}
