using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class detectionItem : MonoBehaviour
{
    public Shader ShaderToApply;
    public LayerMask layerMask;
    public TextMeshProUGUI pressEText;
    private GameObject currentObject;
    private Renderer objectRenderer;
    private Material currentMaterial;
    private Coroutine rayCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        rayCoroutine = StartCoroutine(raycastRoutine());
    }

    private IEnumerator raycastRoutine(){
        while(true){
            yield return new WaitForSeconds(0.1f);
            detectObject();
        }
    }

    void detectObject(){
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 100, layerMask)){
            Debug.Log(hit.transform.name);
            pressEText.gameObject.SetActive(true);
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);
        }
        else {
            pressEText.gameObject.SetActive(false);
        }
        /*else {
            if(currentObject != null){
                Debug.Log("Resetting material");
                objectRenderer.material = currentMaterial;
            }
        }*/
    }
}
