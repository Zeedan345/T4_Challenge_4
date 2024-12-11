using UnityEngine;

public class LockButton : MonoBehaviour
{
    public KeypadManager keypadManager; // Reference to the KeypadManager
    public string digit; // Assign this in the Inspector for each button

    private void OnTriggerEnter(Collider other)
    {
        // Detect controller or hand interaction
        if (other.CompareTag("Controller") || other.CompareTag("Hand"))
        {
            keypadManager.AddDigit(digit); // Add the digit to the code
            Debug.Log($"Button {digit} pressed!");
        }
    }
}
