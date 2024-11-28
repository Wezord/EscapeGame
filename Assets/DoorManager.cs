using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static DoorManager current;

    public Boolean isOpen;

    private void Awake(){
        if (current == null){
            current = this;
        }
        else {
            Destroy(obj : this);
        }
    }

    public event Action<Boolean> onDoorOpen;
    public void DoorOpen(Boolean newcount){
        onDoorOpen?.Invoke(newcount);
    }

    public Boolean IsOpen{
        get => isOpen;
        set {
            isOpen = value;
            DoorOpen(value);
        }
    }
}
