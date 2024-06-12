using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public GameObject Player;
    public Sprite OpenDoorImage;
    public Sprite CloseDoorImage;
    public float TSMS;
    public bool PlayerIsAtTheDoor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&& PlayerIsAtTheDoor == true )
            {
            StartCoroutine(_OpenDoor());
        }
    }

    public IEnumerator _OpenDoor()
    {
        transform.GetComponent<SpriteRenderer>().sprite = OpenDoorImage;
        yield return new WaitForSeconds(TSMS);
        Player.SetActive(false);
        yield return new WaitForSeconds(TSMS);
        transform.GetComponent<SpriteRenderer>().sprite = CloseDoorImage;
        yield return new WaitForSeconds(TSMS);
        SceneManager.LoadScene("Level 1");



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerIsAtTheDoor = true;
        }
    }

}
