using UnityEngine;

public class LockButton : MonoBehaviour
{
    public KeypadManager keypadManager; // Reference to the KeypadManager script
    public string buttonAction; // Define the action: "digit", "enter", or "clear"
    public string digit; // For "digit" action, specify the number (e.g., "1", "2", etc.)

    private void OnTriggerEnter(Collider other)
    {
        // Trigger action on any collision
        switch (buttonAction.ToLower())
        {
            case "digit":
                keypadManager.AddDigit(digit);
                break;

            case "enter":
                keypadManager.CheckCode();
                break;

            case "clear":
                keypadManager.ClearCode();
                break;
        }

        // Optional: Add visual or audio feedback
        Debug.Log($"{buttonAction} button activated!");
    }
}