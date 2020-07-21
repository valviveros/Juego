using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    public string nickname;
    [TextArea(3, 10)]
    public string[] sentenceList;
    Queue<string> sentences;
    public GameObject dialogueBox;
    public Text nicknameText;
    public Text dialogueText;
    public GameObject nextDialogue;
    string activeSentece;
    public float typingSpeed;
    AudioSource myAudio;
    public AudioClip speakSound;
    public bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        myAudio = GetComponent<AudioSource>();
    }

    void startDialogue()
    {
        sentences.Clear();
        foreach (string sentence in sentenceList)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    void DisplayNextSentence()
    {
        if (sentences.Count < 0)
        {
            dialogueText.text = activeSentece;
            return;
        }
        if (sentences.Count == 1)
        {
            nextDialogue.SetActive(false);
        } else if (sentences.Count > 0)
        {
            nextDialogue.SetActive(true);
        }
        
        activeSentece = sentences.Dequeue();
        dialogueText.text = activeSentece;
        StopAllCoroutines();
        StartCoroutine(TypeTheSentence(activeSentece));
    }

    IEnumerator TypeTheSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            // myAudio.PlayOneShot(speakSound);
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            dialogueBox.SetActive(true);
            nicknameText.text = nickname;
            startDialogue();
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Return) && dialogueText.text == activeSentece)
        {
            DisplayNextSentence();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogueBox.SetActive(false);
            nextDialogue.SetActive(false);
            StopAllCoroutines();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
