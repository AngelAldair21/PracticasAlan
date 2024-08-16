using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private Transform grid;

    [SerializeField] private GameObject[] items = new GameObject[12];

    private Inventory inventoryRef;

    // Busco el inventario para ya tener acceso a la informacion antes de tener
    // que encender el canvas, evitando el start
    private void Awake()
    {
        inventoryRef = FindObjectOfType<Inventory>();
    }

    private void OnEnable()
    {
        inventoryRef.inventory.AsReadOnly();

        for (int i = 0; i < items.Length; i++)
        {
           Debug.Log(i + ": " + items[i].name); 
           
        }
    }

}
