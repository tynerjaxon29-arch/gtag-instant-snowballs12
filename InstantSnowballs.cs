using BepInEx;
using UnityEngine;
using GorillaLocomotion;
using System.Collections;

[BepInPlugin("com.tynerjaxon29.instantSnowballs", "Instant Snowballs", "1.0.0")]
public class InstantSnowballs : BaseUnityPlugin
{
    private float throwRate = 0.05f; // Super fast = almost instant
    private bool canThrow = true;

    void Update()
    {
        // Right trigger to throw snowballs super fast
        if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.7f && canThrow)
        {
            ThrowInstantSnowball();
            canThrow = false;
            StartCoroutine(ResetThrow());
        }
    }

    private IEnumerator ResetThrow()
    {
        yield return new WaitForSeconds(throwRate);
        canThrow = true;
    }

    void ThrowInstantSnowball()
    {
        // This is a basic version - real instant snowball mods usually patch the game's cooldown
        Debug.Log("[InstantSnowballs] Throwing snowball!");

        // You can improve this later with Harmony patches if you want zero cooldown
        
    }
}
