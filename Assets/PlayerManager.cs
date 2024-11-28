using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager current;
    public Boolean isHoldingObject;
    private void Awake(){
        if (current == null){
            current = this;
        }
        else {
            Destroy(obj : this);
        }
    }

    public event Action<Boolean> onHeldObject;
    public void HoldObject(Boolean newBool){
        onHeldObject?.Invoke(newBool);
    }

    public bool IsHoldingObject{
        get=>isHoldingObject;
        set{
            isHoldingObject = value;
            onHeldObject(value);
        }
    }
}
