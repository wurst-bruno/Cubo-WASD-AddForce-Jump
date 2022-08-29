using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueUI;
    TextMeshProUGUI textodeldialogo;
    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            textodeldialogo.text = "Hola Forastero!";

            dialogueUI.SetActive(true);
        }

        //al entrar activa la ui de dialogo 
    }

    void OnTriggerExit(Collider other)
    {
        //al salir desactiva la ui de dialogo
        if (other.gameObject.CompareTag("NPC"))
        {
            dialogueUI.SetActive(false);
        }
    }


}
