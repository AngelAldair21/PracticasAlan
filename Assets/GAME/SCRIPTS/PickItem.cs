using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour, IInteractable
{
    private Inventory inventory;
    public Item obje;

    private void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    public void Interact()
    {
        inventory.AddItem(obje);

        Destroy(this.gameObject);
    }
  
}
