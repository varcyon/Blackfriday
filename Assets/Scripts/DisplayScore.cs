using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayScore : MonoBehaviour
{
    public ShoppingCart shoppingCart;
    public TMP_Text score;


    private void Start() {
        shoppingCart.costTotal = 0;
        shoppingCart.cart = new List<Item>();
    }
    void Update()
    {
        score.text = shoppingCart.costTotal.ToString();
    }
}
