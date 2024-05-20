using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : Collectible
{
    public float speedIncrease = 10.0f;

    public override void Collected(Player thePlayer)
    {
        base.Collected(thePlayer);
        StarterAssets.FirstPersonController controller = thePlayer.GetComponent<StarterAssets.FirstPersonController>();
        if (controller != null)
        {
            controller.MoveSpeed += speedIncrease;
            Debug.Log("Player speed increased");
        }
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
