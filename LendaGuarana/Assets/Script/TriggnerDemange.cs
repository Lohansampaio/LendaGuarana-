using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggnerDemange : MonoBehaviour
{
    public Heart heart;
    
    // Start is called before the first frame update
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.CompareTag("Player")){
           
            heart.vida--;
            
        }
    }
}

