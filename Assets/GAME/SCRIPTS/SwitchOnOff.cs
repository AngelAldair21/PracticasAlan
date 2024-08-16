using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnOff : MonoBehaviour, IInteractable
{

    [SerializeField] bool on = false;
    private MeshRenderer mesh;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    public void Interact()
    {
        on = !on;
        mesh.enabled = on;
    }

}
