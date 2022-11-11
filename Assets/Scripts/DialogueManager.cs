using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueUI;
    [SerializeField]TextMeshProUGUI textodeldialogo;
    [SerializeField] string[] frasesDialogo;
    [SerializeField] int posicionfrase;
    [SerializeField] TextMeshProUGUI textoboton;
    [SerializeField] bool hastalked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {

        //al entrar activa la ui del dialogo
        if (other.gameObject.CompareTag("npc"))
        {
            frasesDialogo = other.gameObject.GetComponent<NPCBEHAVIOUR>().data.dialogueFrases;
            if (!hastalked)
            {
                
                textodeldialogo.text = "Hola forastero";
                dialogueUI.SetActive(true);
            }
            else
            {
                textodeldialogo.text = "Ya hemos hablado";
                dialogueUI.SetActive(true);
                textoboton.text = "cerrar";
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        //al salir desaparece el dialogo
        if (other.gameObject.CompareTag("npc"))
        {
            dialogueUI.SetActive(false);
        }
    }
    public void nextphrase()
    {
        if (posicionfrase < frasesDialogo.Length)
        {

            textodeldialogo.text = frasesDialogo[0];
            posicionfrase++;
            if (posicionfrase==frasesDialogo.Length)
            {
                textoboton.text = "cerrar";
                
            }
        }
        else
        {
            dialogueUI.SetActive(false);
            hastalked=true;
        }
        
    }
}
