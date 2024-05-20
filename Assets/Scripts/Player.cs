using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    GameObject collTextBox;

    int currentScore = 0;

    Interactable currentInteractable;
        
    public void IncreaseScore(int scoreToAdd)
    {
        // Need to make this appear after a certain condition
        // Make the textbox GameObject appear
        coolTextBox.SetActive(true);

        currentScore += scoreToAdd;
        scoreText.text = currentScore.ToString();
        Debug.Log(currentScore);
    }

    public void UpdateInteractable(Interactable newInteractable)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
