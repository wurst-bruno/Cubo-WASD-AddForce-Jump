using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogeManager : MonoBehaviour
{
    int counter = 0;
    [SerializeField] bool hasTalked;
    [SerializeField] TextMeshProUGUI textbtn;
    public TextMeshProUGUI text;
    [SerializeField] GameObject dialogueUI;
    [SerializeField] string[] dialogue = new string[6] {"Hola, forastero", "Hola, vaquero", "Que puedo ofrecerle?", "Sabe si hay una gasolinera por aquí?", "No, no conozco", "Gracias"};

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
        //Al entrar activa la UI de dialogo
        if (other.gameObject.CompareTag("NPC"))
        {
            dialogue = other.gameObject.GetComponent<NPCBeheaviour>().data.dialogueFrases;
            if (!hasTalked)
            {
                text.text = "...";
                dialogueUI.SetActive(true);
            }
            else
            {
                text.text = "Ya hemos hablado...";
                dialogueUI.SetActive(true);
                textbtn.text = "Cerrar";
            }
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            dialogueUI.SetActive(false);
        }
    }

    public void NextFrase()
    {
        text.text = dialogue[0];
        if (counter < dialogue.Length)
        {
            text.text = dialogue[counter];
            counter++;
            if (counter == dialogue.Length - 1)
            {
                textbtn.text = "Cerrar";
            }
        }
        else
        {
            dialogueUI.SetActive(false);
            hasTalked = true;
        }
    }
}
