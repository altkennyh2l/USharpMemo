using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

/* 
This script is to play 2 particle systems and initiate an animator when interact with the object this script is bounded to.
 */

public class ObejectPSController : UdonSharpBehaviour
{
    public Animator anim;
    public ParticleSystem PS1;
    public ParticleSystem PS2;

    public void ActivatePS()
    {
        anim.SetBool("Activate", true);
        PS1.Play();
        PS2.Play();
    }
}
