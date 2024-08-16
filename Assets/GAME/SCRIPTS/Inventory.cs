using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Inventory : MonoBehaviour
{

    [SerializeField] internal List<Item> inventory;
    [SerializeField] private int itemsInInventory; 
    [SerializeField] private int maxCapacity; 


    public void AddItem(Item item)
    {
        if(itemsInInventory < maxCapacity)
        {
            inventory.Add(item);
            itemsInInventory++;
        }
        else
        {
            Debug.Log("No hay espacio en el inventario");
        }
    }

    public void RemoveItem(Item item)
    {
        if (inventory.Contains(item))
        {
            inventory.Remove(item);
            itemsInInventory--;
        }
        else
        {
            Debug.Log("Ese objeto no se encuentra en el inventario");
        }
    }

    public bool ContainsItem(Item item)
    {
        return inventory.Contains(item);
    }


}
