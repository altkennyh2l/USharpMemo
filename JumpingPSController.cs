
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common;

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
