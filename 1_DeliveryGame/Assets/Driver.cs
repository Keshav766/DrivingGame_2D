using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300.0f;
    [SerializeField] float moveSpeed = 10.0f;
    // [SerializeField] float slowSpeed = 5.0f;
    [SerializeField] float boostSpeed = 20.0f;
    bool bost;
    // void Start()
    // {
        
    // }

    
    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            Debug.Log("Boost!!!!");
            bost = true;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(bost)
        {
            Debug.Log("Boost Gone BITCH!!!");
            moveSpeed = 10.0f;
        }
            
    }
}
