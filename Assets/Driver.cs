using UnityEngine;
using UnityEngine.InputSystem;
public class Driver : MonoBehaviour
{
   [SerializeField] float moveSpeed = 0.1f;
   [SerializeField] float streerSpeed = 0.5f;

    void Update()
    {
        float move = 0f;
        float streer = 0f;

        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        
        if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }
        
        if (Keyboard.current.aKey.isPressed)
        {
            streer = 1f;
        }
        
        if (Keyboard.current.dKey.isPressed)
        {
            streer = -1f;
        }

        float moveAmount = move * moveSpeed * Time.deltaTime;
        float streerAmount = streer * streerSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, streerAmount);
    }
}
