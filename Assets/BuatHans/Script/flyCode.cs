using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class flyCode : MonoBehaviour
{
    public bool Chase;
    public float speed;
    private GameObject player;
    public Transform startPoint;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) {

            Debug.Log("player tidak ditemukan");
        }

        if(Chase == true)
        {
        chase();

        }
        else
        {
            flip(); 
            ReturnStartPoint();
        }
    }

    private void ReturnStartPoint()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position,speed*Time.deltaTime);
    }

    public void chase()
    {
        transform.position = Vector2.MoveTowards(transform.position,player.transform.position, speed *Time.deltaTime) ;
    }

    public void flip()
    {
        if(transform.position.x>player.transform.position.x)
        {
            transform.rotation = quaternion.Euler(0,0, 0);
        }
        else
        {
            transform.rotation = quaternion.Euler(0, 180, 0);

        }
    }
}
