using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Represents a collectible item that increases the player's jump height when collected.
/// </summary>
public class Jump : Collectible
{
    /// <summary>
    /// The amount by which the player's jump height is increased.
    /// </summary>
    public float jumpIncrease = 5.0f;

    /// <summary>
    /// Called when the player collects the item. Increases the player's jump height.
    /// </summary>
    /// <param name="thePlayer">The player who collected the item.</param>
    public override void Collected(Player thePlayer)
    {
        base.Collected(thePlayer);
        thePlayer.GetComponent<StarterAssets.FirstPersonController>().JumpHeight += jumpIncrease;
        Debug.Log(thePlayer.GetComponent<StarterAssets.FirstPersonController>().JumpHeight);

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
