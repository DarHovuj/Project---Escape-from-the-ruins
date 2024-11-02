using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int jumpForce = 300;

    public Transform gruondCheck;
    public LayerMask gruondMask;
    private bool gruond = false;
    private float gruondRadius = 0.5f;

    public GameObject gameOver;
    public GameObject endLevel;

   

    public bool stop = false;
    public bool end = false;
    

 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gruond = Physics2D.OverlapCircle(gruondCheck.position, gruondRadius, gruondMask);
        if (Input.GetKeyDown(KeyCode.W) && gruond == true)
        {
            Jump();
        }
        /*
        if (liveScore == 0)
        {
            gameOver.SetActive(true);
        }
        */
        if(stop)
        {
            ObjectMove.speed = 0f;
            gameOver.SetActive(true);
        }

        
        
    }
    private void FixedUpdate()
    {
        if (end)
        {
            ObjectMove.speed = 0f;
            endLevel.SetActive(true);

        }
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {

            stop = true;
            
            
        }

        if (collision.tag == "End")
        {
            end = true;
        }

    }

   

    public void Restart()
    {
        CoinCollect.coinScore = 0;
        SceneManager.LoadScene("Demo");

    }

}
