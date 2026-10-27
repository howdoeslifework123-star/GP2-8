using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class SimpleInventory : MonoBehaviour
{
    //1. Generic List Declaration
    private List<string> playerInventory = new List<string>();
    public TextMeshProUGUI inventoryText;

    void Start()
    {
        //2. Create(Adding Items)
        playerInventory.Add("Sword of Jesus");
        playerInventory.Add("Potion of Mining Fatigue");
        
      
    }

    public void RemoveItem(string itemName)
    {
        //3. Remove
        if (playerInventory.Remove(itemName))
        {
            Debug.Log("Item Removed sucka");
        }
        else
        {
            Debug.LogWarning("Can't find that item, king");
        }
        UpdateUI();
    }

    public void RemoveItemDrop()
    {
        //loop backwards
        for (int n = playerInventory.Count - 1; n >= 0; n--)
        {
            if (playerInventory[n].Contains("Potion of Mining Fatigue"))
            {
                playerInventory.RemoveAt(n);
            }
        }
        UpdateUI();
    }

    public void AddItem(string itemName)
    {
        playerInventory.Add(itemName);
        UpdateUI();

    }

    private void UpdateUI()
    {
        //Update 
        inventoryText.text = "Inventory Contents: \n";
        for (int n = 0; n < playerInventory.Count; n++)
        {
            inventoryText.text += $"- {playerInventory[n]}\n";
        }
    }
}
