using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

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
