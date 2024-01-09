using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Heart heart;
    [SerializeField] float moveSpeed;
    Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        transform.Translate(moveInput * Time.deltaTime * moveSpeed);

        
    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.CompareTag("Enemy")){
            
           heart.vida--;
        }
    
}
}
    


