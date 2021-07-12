using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common;

/* 
This script is to play a particle system when a player jumps.
Since VRCInstantiate cannot summon a particle system directly so it will be put under a PSParent.
Currently, VRCInstantiate has some syncing limitation, the following script is local.
 */

public class JumpingPSController : UdonSharpBehaviour
{
    public GameObject PSParent;
    public override void InputJump(bool value, UdonInputEventArgs args)
    {
        GameObject SpawnedPSParent = VRCInstantiate(PSParent);
        Vector3 SpawnedPSParentPos = Networking.LocalPlayer.GetPosition();
        SpawnedPSParentPos.y = 0;
        SpawnedPSParent.transform.position = SpawnedPSParentPos;
        SpawnedPSParent.SetActive(true);
        Destroy(SpawnedPSParent, 1);
    }
}
