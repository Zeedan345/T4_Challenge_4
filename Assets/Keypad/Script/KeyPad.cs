using UnityEngine;
using UnityEngine.UI; // Include if using regular UI Text
using TMPro; // Include if using TextMeshPro

public class KeypadManager : MonoBehaviour
{
    public string correctCode = "123"; // The correct code to unlock
    private string enteredCode = "";

    // Reference to the UI Text or TextMeshPro component
    public Text displayText; // For Unity UI Text
    // public TextMeshProUGUI displayText; // Uncomment if using TextMeshPro

    // Reference for teleportation
    public Transform teleportDestination; // Set the destination Transform
    public GameObject player; // The player GameObject to teleport

    public void AddDigit(string digit)
    {
        if (enteredCode.Length < 3) // Allow only 3 digits
        {
            enteredCode += digit;
            UpdateDisplay();

            if (enteredCode.Length == 3) // Reset after 3 digits
            {
                CheckCode();
            }
        }
    }

    public void CheckCode()
    {
        if (enteredCode == correctCode)
        {
            Debug.Log("Correct code entered! Teleporting player...");
            TeleportPlayer();
        }
        else
        {
            Debug.Log("Incorrect code! Resetting...");
            ResetCode();
        }
    }

    public void ClearCode()
    {
        Debug.Log("Code cleared manually.");
        ResetCode();
    }

    private void ResetCode()
    {
        enteredCode = "";
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        if (displayText != null)
        {
            displayText.text = enteredCode; // Update the displayed text
        }
    }

    private void TeleportPlayer()
    {
        if (player != null && teleportDestination != null)
        {
            player.transform.position = teleportDestination.position;
            Debug.Log("Player teleported to destination.");
        }
        else
        {
            Debug.LogWarning("Player or Teleport Destination is not set!");
        }

        ResetCode(); // Reset the keypad after teleporting
    }
}
