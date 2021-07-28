using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DialogManager : MonoBehaviour {

    public Text NameText;
    public Text phrasesText;
    public Image iconPersonnage;
    public FloatObject playerSpeed;
    public Image Press_Button;

    public float waitTime = 3;
    private bool isWait = true;

    private Queue<Phrases> phrases;
    private bool dialogueIsStarted;
    private float revertSpeed;

    public Animator UiAnimator;

    private int hashDialogueStarted;

    private UnityEvent endEvent;


    private void Awake() {
        phrases = new Queue<Phrases>();
        hashDialogueStarted = Animator.StringToHash("DialogueStarted");
    }

    public void StartDialogue(Phrases[] dialogue, UnityEvent e){
        endEvent = e;
        UiAnimator.SetBool(hashDialogueStarted, true);
        Debug.Log("Start Dialog");
        revertSpeed = playerSpeed.number;
        playerSpeed.number = 0;
        dialogueIsStarted = true;

        phrases.Clear();

        foreach(Phrases phrase in dialogue){
            phrases.Enqueue(phrase);
        }

        StartCoroutine(AfficherLaProchainePhrase());
    }

    public IEnumerator AfficherLaProchainePhrase(){
        Press_Button.gameObject.SetActive(false);
        if (phrases.Count == 0){
            EndDialogue();
            yield break;
        }
        isWait = false;

        Phrases phrase = phrases.Dequeue();
        NameText.text = phrase.personnage.nom;
        phrasesText.text = phrase.phrases;
        iconPersonnage.sprite = phrase.personnage.Icon;
        phrase.Action.Invoke();

        Debug.Log(phrase.personnage);
        Debug.Log(phrase.phrases);
        yield return new WaitForSeconds(waitTime);
        Press_Button.gameObject.SetActive(true);
        isWait = true;
        yield break;
    }

    void EndDialogue(){
        if(endEvent != null){
            endEvent.Invoke();
        }
        UiAnimator.SetBool(hashDialogueStarted, false);
        Debug.Log("End of conversation");
        dialogueIsStarted = false;
        playerSpeed.number = revertSpeed;
    }

    private void Update() {
        if(dialogueIsStarted && Input.GetButtonDown("Submit") && isWait){
            StartCoroutine(AfficherLaProchainePhrase());
        }
    }

}