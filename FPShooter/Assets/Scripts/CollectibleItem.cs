using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour {

    public string itemName;//Вводим имена в inspector

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected: " + itemName);
        Destroy(this.gameObject);
        if (itemName == "health")
        {//проверяем, является ли объект здоровьем
            PlayerCharacter player = other.GetComponent<PlayerCharacter>();
            if (player != null)
            {//проверяем, является ли объект PlayerCharacter
                player.ChangeHealth(20);
            }
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
