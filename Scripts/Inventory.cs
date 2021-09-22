﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject inventory;
    public GameObject slotHolder;

    private int slots;
    private Transform[] slot;

    private GameObject itemPickedUp;

    public void Start()
    {
        // slots being detected
        slots = slotHolder.transform.childCount;
        slot = new Transform[slots];
        DetectInventorySlots();
    }

    public void Update()
    {
        
    }



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Item>())
        {
            itemPickedUp = other.gameObject;
            AddItem(itemPickedUp);
        }
    }


    public void AddItem(GameObject item)
    {
        for (int i = 0; i < slots; i++)
        {
            if (slot[1].GetComponent<Slot>().empty)
            {
                slot[i].GetComponent<Slot>().item = itemPickedUp;
                slot[i].GetComponent<Slot>().itemIcon = itemPickedUp.GetComponent<Item>().icon;
            }
        }
    }

    public void DetectInventorySlots()
    {
        for (int i = 0; i < slots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i);
            print(slot[i].name);
        }
    }
}
