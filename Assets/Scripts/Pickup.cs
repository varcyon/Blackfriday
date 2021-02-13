using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public ShoppingCart shoppingCart;
    public Item item;


    void Awake() {
        GetComponent<SpriteRenderer>().sprite = item.itemSprite;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(other.name);
        if (other.CompareTag("Player")) {
            shoppingCart.costTotal += item.price;
        }
        Destroy(this.gameObject);
        
    }

}
