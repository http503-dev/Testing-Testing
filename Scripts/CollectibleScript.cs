using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : Interactable
{
    int score = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            UpdatePlayerInteractable(collision.gameObject.GetComponent<Player>());
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            RemovePlayerInteractable(collision.gameObject.GetComponent<Player>());
        }
    }



    public override void Interact(Player thePlayer)
    {
        base.Interact(thePlayer);
        thePlayer.IncreaseScore(score);
        Destroy(gameObject);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
