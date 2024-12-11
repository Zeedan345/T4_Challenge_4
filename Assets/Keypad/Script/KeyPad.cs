using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeypadManager : MonoBehaviour
{
    public string correctCode = "1234";
    private string enteredCode = "";

    public TextMeshProUGUI displayText; // For UI display in case you want to show entered numbers

    // Adds a digit to the entered code
    public void AddDigit(string digit)
    {
        if (enteredCode.Length < correctCode.Length)
        {
            enteredCode += digit;
            UpdateDisplay();
        }
    }

    // Checks if the entered code matches the correct code
    public void CheckCode()
    {
        if (enteredCode == correctCode)
        {
            Debug.Log("Correct code! Door opens.");
            // Add your door-opening logic here
        }
        else
        {
            Debug.Log("Incorrect code!");
            ClearCode();
        }
    }

    // Clears the entered code
    public void ClearCode()
    {
        enteredCode = "";
        UpdateDisplay();
    }

    // Updates the display (optional)
    private void UpdateDisplay()
    {
        if (displayText != null)
        {
            displayText.text = enteredCode;
        }
    }
}
