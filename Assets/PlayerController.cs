using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private SpriteRenderer spriteRenderer;
    private float mytime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playercolor = colorswitch.RED;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        mytime += Time.deltaTime;
        if (mytime >= 5 && mytime <= 10)
        {
            playercolor = colorswitch.YELLOW;
        }
        else
        if (mytime >= 10 && mytime <= 15)
        {
            playercolor = colorswitch.RED;
        }
        else
        if (mytime >= 15 && mytime <= 20)
        {
            playercolor = colorswitch.CYAN;
        }
        else
        if (mytime >= 20 && mytime <= 25)
        {
            playercolor = colorswitch.MAGENTA;
        }
        else
        if (mytime >= 25 && mytime <= 30)
        {
            playercolor = colorswitch.BLUE;
        }



            switch (playercolor)
        {
            case colorswitch.GREEN:
                spriteRenderer.color = Color.green;
                break;

            case colorswitch.RED:
                spriteRenderer.color = Color.red; // Set the player's color to red
                break;
            case colorswitch.BLUE:
                spriteRenderer.color = Color.blue; // Set the player's color to blue
                break;

            case colorswitch.CYAN:
                spriteRenderer.color = Color.cyan; // Set the player's color to cyan
                break;

            case colorswitch.MAGENTA:
                spriteRenderer.color = Color.magenta; // Set the player's color to magenta
                break;

            case colorswitch.YELLOW:
                spriteRenderer.color = Color.yellow; // Set the player's color to yellow
                break;

        };


    }
    void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(horizontal, vertical, 0);
    }
    public enum colorswitch //declaring a new variable type
    {
        RED,
        GREEN,
        BLUE,
        CYAN,
        MAGENTA,
        YELLOW
    }
    
    //an actual instance of the enumerable stateMode we have just defined
    public colorswitch playercolor; //this is an instance stateMode

    private void FixedUpdate()
    {
        

        
    }
}
