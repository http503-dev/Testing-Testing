using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class SpeedBoost : Collectible
{
    public float speedIncrease = 10.0f;

    public override void Collected(Player thePlayer)
    {
        base.Collected(thePlayer);
        thePlayer.GetComponent<FirstPersonController>().MoveSpeed += speedIncrease;
        Debug.Log(thePlayer.GetComponent<FirstPersonController>().MoveSpeed);
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
