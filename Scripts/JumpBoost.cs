using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : Collectible
{
    public float jumpHeightIncrease = 10.0f;

    public override void Collected(Player thePlayer)
    {
        base.Collected(thePlayer);
        StarterAssets.FirstPersonController controller = thePlayer.GetComponent<StarterAssets.FirstPersonController>();
        if (controller != null)
        {
            controller.JumpHeight += jumpHeightIncrease;
            Debug.Log("Player jump height increased");
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
