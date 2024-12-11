using UnityEngine;

public class LockButton : MonoBehaviour
{
    public KeypadManager keypadManager; // Reference to the KeypadManager
    public string digit; // Assign this in the Inspector for each button

    private void OnTriggerEnter(Collider other)
    {
        keypadManager.AddDigit(digit);
        Debug.Log($"Button {digit} pressed!");
    }
}
