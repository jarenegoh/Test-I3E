using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Represents a collectible item that increases the player's speed when collected.
/// </summary>
public class Speed : Collectible
{
    /// <summary>
    /// The amount by which the player's speed is increased.
    /// </summary>
    public float speedIncrease = 5.0f;

    /// <summary>
    /// Called when the player collects the item. Increases the player's speed.
    /// </summary>
    /// <param name="thePlayer">The player who collected the item.</param>
    public override void Collected(Player thePlayer)
    {
        base.Collected(thePlayer);
        thePlayer.GetComponent<StarterAssets.FirstPersonController>().MoveSpeed += speedIncrease;
        Debug.Log(thePlayer.GetComponent<StarterAssets.FirstPersonController>().MoveSpeed);

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
