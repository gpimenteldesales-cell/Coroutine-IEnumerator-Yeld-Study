using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Coroutine : MonoBehaviour
{
    public InputAction clickControl;
    private SpriteRenderer spritePlayer;
    public GameObject textObject;
    public TextMeshProUGUI textTexto;

    public int scoreTime = 0;

    void OnEnable()
    {
        clickControl.Enable();
        clickControl.performed += ClickCountTime;
    }
    void OnDisable()
    {
        clickControl.Disable();
    }

    void Start()
    {
        spritePlayer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

    }

    void ClickCountTime(InputAction.CallbackContext context)
    {
        scoreTime++;
        textTexto.text = "Clicks:" + scoreTime.ToString();
        spritePlayer.color = Color.red;
    }
}
