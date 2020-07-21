using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
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
    public bool getItem = false;
    ReceiveItems receiveItems;
    PlayerItems PlayerItems;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        myAudio = GetComponent<AudioSource>();
        receiveItems = GetComponent<ReceiveItems>();
        PlayerItems = GameObject.FindObjectOfType<PlayerItems>();
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
        if (sentences.Count == 0)
        {
            if (receiveItems.haveItem)
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    Debug.Log("item");
                    dialogueBox.SetActive(false);
                    StartCoroutine(WaitItem());
                }
            }
        } 
        if (sentences.Count > 0)
        {
            nextDialogue.SetActive(true);
        } 
        if (!receiveItems.haveItem && sentences.Count == 1)
        {
            nextDialogue.SetActive(false);
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

    IEnumerator WaitItem()
    {
        yield return new WaitForSeconds(0.6f);
        receiveItems.banner.SetActive(true);
        getItem = true;
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
        if (getItem && Input.GetKeyDown(KeyCode.Return) && receiveItems.haveItem == true)
        {
            receiveItems.banner.SetActive(false);
            StopAllCoroutines();
            if (receiveItems.whichItem == "map")
            {
                Debug.Log(receiveItems.whichItem);
                PlayerItems.map = true;
            } else if (receiveItems.whichItem == "heart")
            {
                Debug.Log(receiveItems.whichItem);
                PlayerItems.heart = true;
            }
            receiveItems.haveItem = false;
        }
    }
}
