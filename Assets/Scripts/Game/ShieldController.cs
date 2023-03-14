using System.Collections;
using UnityEngine;
using Constants;

public class ShieldController : MonoBehaviour
{
    public float fadeTime = 1f; // In seconds
    public float minAlpha = 0f;
    public float maxAlpha = 0.8f;
    private bool isActive = false;

    void Start()
    {
        SetOpacity(0);
    }

    /// <summary>
    ///  Activates the shield for a given duration.
    /// </summary>
    /// <param name="activationTime">Time the shield should remain active.</param>
    public void Activate(float activationTime)
    {
        if (isActive)
        {
            CancelInvoke();
        }
        Show();
        Invoke(nameof(Hide), activationTime);
    }

    private void Show()
    {
        StartCoroutine(ActivateAndShow());
    }

    private void Hide()
    {
        StartCoroutine(HideAndDeactivate());
    }

    private IEnumerator ActivateAndShow()
    {
        isActive = true;
        yield return FadeIn();
    }

    private IEnumerator HideAndDeactivate()
    {
        yield return FadeOut();
        isActive = false;
    }

    private IEnumerator FadeIn()
    {
        var spriteRenderer = GetComponent<SpriteRenderer>();
        Color color = spriteRenderer.color;
        while (color.a < maxAlpha)
        {
            color.a += Time.deltaTime / fadeTime;
            spriteRenderer.color = color;
            yield return null; // Pause until next frame
        }
    }

    private IEnumerator FadeOut()
    {
        var spriteRenderer = GetComponent<SpriteRenderer>();
        Color color = spriteRenderer.color;
        while (color.a > minAlpha)
        {
            color.a -= Time.deltaTime / fadeTime;
            spriteRenderer.color = color;
            yield return null; // Pause until next frame
        }
    }

     private void SetOpacity(float opacity)
    {
        var objectColor = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = new Color(
            objectColor.r,
            objectColor.g,
            objectColor.b,
            opacity
        );
    }

   void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(isActive);
        if (!isActive)
        {
            return;
        }
        GameObject hitObject = hitInfo.gameObject;
        if (hitObject.layer == (int)GameLayer.Satellite || hitObject.layer == (int)GameLayer.Meteorite)
        {
            Destroy(hitObject);
            Debug.Log("Destroyed");
        }
    }
}
