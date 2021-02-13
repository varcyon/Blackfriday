using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ShoppingCart : ScriptableObject
{
    public float costTotal;

    public List<Item> cart = new List<Item>();

    public void CalculateTotal() {
        costTotal = 0;
        foreach (Item item in cart) {
            costTotal += item.price;
        }
    }

    public void ItemStolen() {
        int randomNum = Random.Range(0, cart.Count - 1);
        Debug.Log("Karen has stolen " + cart[randomNum].name);
        cart.RemoveAt(randomNum);
        CalculateTotal();
    }
}
