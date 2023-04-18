using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
        [SerializeField] float Ddelay = 1f;
        [SerializeField] Color32 hasPackageColor = new Color32 (231, 62, 147, 255);
        [SerializeField] Color32 hasDeliveryColor = new Color32 (255, 208, 0, 255);
        bool hasPackage;
        SpriteRenderer spriteRenderer;

        void Start()  
        {
            spriteRenderer = GetComponent<SpriteRenderer>();   
        }
        void OnCollisionEnter2D(Collision2D other) 
        {
        Debug.Log("Box Collision Bitch!!!!");   
       
        }
    void OnTriggerEnter2D(Collider2D other) 
    {
        // Debug.Log("Trigger Crossed Bitch!!!!");   
        if(other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package Picked Up!!!!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,Ddelay);
        }
        if(other.tag == "Customer" && hasPackage) 
        {
            Debug.Log("Package delivered!!!!");
            hasPackage = false;
            spriteRenderer.color = hasDeliveryColor;
            Destroy(other.gameObject,Ddelay);
        }
         if(other.tag == "Sexy")
        {
            Debug.Log("Yeeeaaah I am feeling this Hottie ~~~~ YUMMY >>>");
        }

        
    }
}
