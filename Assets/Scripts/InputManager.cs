using UnityEngine;
using System;
using UnityEngine.Events;
public class InputManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnSpacePressed = new UnityEvent();
    public UnityEvent OnResetPressed = new UnityEvent();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }
        
        Vector2 input = Vector2.zero;
        if(Input.GetKey(KeyCode.D)){
            input += Vector2.right;
        }
        if(Input.GetKey(KeyCode.A)){
            input += Vector2.left;
        }
        OnMove?.Invoke(input);

        if(Input.GetKeyDown(KeyCode.R)){
            OnResetPressed?.Invoke();
        }
    }
}
