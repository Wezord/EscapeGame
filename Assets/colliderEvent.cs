using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderEvent : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triger");
        // Vérifie si l'objet entrant a le tag "Item"
        if (other.CompareTag("Item"))
        {
            // Met l'objet comme enfant du collider principal
            other.transform.SetParent(transform);
            other.transform.position = transform.position;
            Destroy(other.GetComponent<Rigidbody>());
            Debug.Log(other.gameObject.name + " est maintenant un enfant de " + gameObject.name);

            PlayerManager.current.IsHoldingObject = false;
        }
    }
}
