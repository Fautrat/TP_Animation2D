using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private bool firstJump;
    public float speed = 10;
    public float jumpIntensity = 5;

    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        firstJump = true;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Menu.GetComponent<MenuManagement>().gameIsStarted)
            animator.SetBool("gameStarted", true);

        if(Input.GetButtonDown("Jump") && animator.GetBool("cannotJump") == false)
        {
            if(firstJump == false)
            {
                animator.SetBool("cannotJump", true);
                rb.AddForce(Vector2.up * jumpIntensity, ForceMode2D.Impulse);
            }
            else if(rb.velocity.y == 0)
            {
                rb.AddForce(Vector2.up * jumpIntensity, ForceMode2D.Impulse);
                firstJump = false;
            }
        }
        else if(rb.velocity.y == 0 )
        {
            firstJump = true;
            animator.SetBool("cannotJump", false);
        }

        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
