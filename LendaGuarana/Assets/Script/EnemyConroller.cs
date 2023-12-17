using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyConroller : MonoBehaviour
{
    [SerializeField] float speed;
    GameObject player;
    bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if(player != null && isAlive){
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.CompareTag("Bullet")){
            isAlive = false;
            Destroy(gameObject, 0.2f);
        }
    }
}
