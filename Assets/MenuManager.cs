using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{

    public InputAction clickAction;
    public Canvas canva;

    void OnEnable()
    {
        clickAction.performed += OnClickPerformed;
        clickAction.Enable();
    }
    
    void OnDisable()
    {
        clickAction.performed -= OnClickPerformed;
    }
    
    private void OnClickPerformed(InputAction.CallbackContext ctx)
    {
        Debug.Log("Active ?");
        if (canva.isActiveAndEnabled)
        {
            Debug.Log("Active ! ");
            canva.gameObject.SetActive(false);
        }
        else
        {
            canva.gameObject.SetActive(true);
        }
    }
}
