using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; 

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    private bool hovered;
    public bool empty;

    public GameObject item;
    public Texture itemIcon;

    private void Start()
    {
         
    }

    private void Update()
    {
        if (item)
        {
            empty = false;


            itemIcon = item.GetComponent<Item>().icon;
            this.GetComponent<RawImage>().texture = itemIcon;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        hovered = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hovered = false;
    }
}
