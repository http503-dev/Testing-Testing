using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class JumpBoost : Collectible
{
    public float jumpHeightIncrease = 10.0f;

    public override void Collected(Player thePlayer)
    {
        base.Collected(thePlayer);
        thePlayer.GetComponent<FirstPersonController>().JumpHeight += jumpHeightIncrease;
        Debug.Log(thePlayer.GetComponent<FirstPersonController>().JumpHeight);
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
