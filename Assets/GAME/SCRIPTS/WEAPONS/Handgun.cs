using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handgun : Weapon // : MonoBehaivour
{

    public override void Fire()
    {
        Debug.Log($"Pistolita {name} pium pium");
    }

    public override void Aim()
    {
        
    }

    public override void Reload()
    {
        
    }

}
