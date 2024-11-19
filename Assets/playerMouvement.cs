using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMouvement : MonoBehaviour
{

    public InputAction mouvementLeft;
    public InputAction mouvementRight;
    public InputAction mouvementUp;
    public InputAction mouvementDown;   
    // Start is called before the first frame update
    void Start()
    {
        mouvementLeft.Enable();
        mouvementRight.Enable();
        mouvementUp.Enable();
        mouvementDown.Enable();

        mouvementLeft.performed += ctx => {
            transform.position += new Vector3(-1, 0, 0);
        };
        mouvementRight.performed += ctx => {
            transform.position += new Vector3(1, 0, 0);
        };
        mouvementUp.performed += ctx => {
            transform.position += new Vector3(0, 0, 1);
        };
        mouvementDown.performed += ctx => {
            transform.position += new Vector3(0, 0, -1);
        };
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
