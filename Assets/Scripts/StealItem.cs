using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealItem : MonoBehaviour
{
    public ShoppingCart shoppingCart;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            //stun
            shoppingCart.ItemStolen();
        }
    }
}
