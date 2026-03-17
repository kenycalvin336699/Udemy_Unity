using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
   [SerializeField] float currentSpeed = 10f;
   [SerializeField] float streerSpeed = 200f;
   [SerializeField] float boostSpeed = 15f;
    [SerializeField] float regularSpeed = 10f;

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boost"))
        {
            currentSpeed = boostSpeed;
            Destroy(collision.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        currentSpeed = regularSpeed;
    }

    void Update()
    {
        float move = 0f;
        float streer = 0f;

        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;

            if (Keyboard.current.aKey.isPressed)
            {
                streer = 1f;
            }
        
            else if (Keyboard.current.dKey.isPressed)
            {
                streer = -1f;
            }
        }
        
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;

            if (Keyboard.current.aKey.isPressed)
            {
                streer = 1f;
            }
        
            else if (Keyboard.current.dKey.isPressed)
            {
                streer = -1f;
            }
        }

        float moveAmount = move * currentSpeed * Time.deltaTime; 
        float streerAmount = streer * streerSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, streerAmount);
    }
}
