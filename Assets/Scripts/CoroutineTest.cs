using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class CoroutineTest : MonoBehaviour
{
    /// 
    /// 
    ///
    public InputAction keysControl;
    public InputAction clickControl;
    private SpriteRenderer spritePlayer;
    public GameObject textObject;
    public TextMeshProUGUI textTexto;
    public Coroutine coroutineChange;

    public int scoreTime = 0;
    ///
    ///
    ///

    void OnEnable()
    {
        clickControl.Enable();
        clickControl.performed += ClickCountTime;
        keysControl.Enable();
        keysControl.performed += BreakCoroutine;
    }
    void OnDisable()
    {
        clickControl.Disable();
        keysControl.Disable();
    }
    void Start()
    {
        spritePlayer = GetComponent<SpriteRenderer>();
        coroutineChange = StartCoroutine(Changes());
    }

    void Update()
    {

    }
    IEnumerator Changes()
    {
        spritePlayer.color = Color.green;
        yield return new WaitForSeconds(3f);
        spritePlayer.flipX = true;
    }
    void ClickCountTime(InputAction.CallbackContext context)
    {
        scoreTime++;
        textTexto.text = "Clicks:" + scoreTime.ToString();
        spritePlayer.color = Color.red;
    }
    void BreakCoroutine(InputAction.CallbackContext context)
    {
        StopCoroutine(coroutineChange);
        Debug.Log("Parou! :D");
    }
}