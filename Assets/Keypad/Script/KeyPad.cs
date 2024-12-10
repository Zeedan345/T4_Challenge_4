using UnityEngine;
using UnityEngine.UI;

public class KeypadManager : MonoBehaviour
{
    public string correctCode = "1234"; // Set your desired combination
    private string enteredCode = "";

    public Text displayText; // Reference to the Text field displaying entered numbers
    public GameObject door; // Reference to the door GameObject

    private Animator doorAnimator;

    void Start()
    {
        doorAnimator = door.GetComponent<Animator>();
        ClearDisplay();
    }

    // Called when a button is pressed
    public void AddDigit(string digit)
    {
        if (enteredCode.Length < correctCode.Length)
        {
            enteredCode += digit;
            UpdateDisplay();
        }
    }

    // Called when the "Enter" button is pressed
    public void CheckCode()
    {
        if (enteredCode == correctCode)
        {
            OpenDoor();
        }
        else
        {
            Debug.Log("Incorrect Code!");
            ClearDisplay();
        }
    }

    // Clears the entered code and updates the display
    public void ClearCode()
    {
        enteredCode = ""; // Reset the entered code
        UpdateDisplay();  // Update the display to show an empty string
        Debug.Log("Code cleared!");
    }


    // Opens the door
    private void OpenDoor()
    {
        if (doorAnimator != null)
        {
            doorAnimator.SetTrigger("Open");
        }
        Debug.Log("Door Opened!");
    }

    // Updates the UI display
    private void UpdateDisplay()
    {
        displayText.text = enteredCode;
    }

    // Clears the UI display
    private void ClearDisplay()
    {
        enteredCode = "";
        displayText.text = "";
    }
}

