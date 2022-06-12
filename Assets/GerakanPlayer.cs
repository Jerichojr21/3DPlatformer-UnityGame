using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerakanPlayer : MonoBehaviour
{
    public float kecepatan;
    Rigidbody rb;
    Animator anim;
    public float jumpForce = 5.0f;
    public bool isOnGround = true;
    public Text scoreUI;
    public Transform playerPutaran;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Bergerak();
    }

    void Bergerak()
    {
        float gerak = Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * gerak * kecepatan;
        anim.SetFloat("Kecepatan", Mathf.Abs(gerak), 0.1f, Time.deltaTime);
        playerPutaran.localEulerAngles = new Vector3(0, gerak * 90, 0);

        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("virus"))
        {
            Time.timeScale = 0;
            scoreUI.text = "GAME OVER! PRESS R TO PLAY AGAIN!";
            Destroy(gameObject);
        }

        if(collision.collider.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
