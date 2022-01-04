using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkillsCooldown : MonoBehaviour
{
    [SerializeField]
    private Image imageCooldown;
    [SerializeField]
    private TMP_Text textCooldownn;

    public bool isCooldown = false;
    public float cooldownTime = 15.0f;
    public float cooldownTimer = 15.0f;
    void Start()
    {
        textCooldownn.gameObject.SetActive(false);
        imageCooldown.fillAmount = 0.0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UseSpell();
            if (isCooldown)
            {
                applyCooldown();
            }
        }
        else
        {

        }

    }
    public void applyCooldown()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer < 0.0f)
        {
            isCooldown = false;
            textCooldownn.gameObject.SetActive(false);
            imageCooldown.fillAmount = 0.0f;
        }
        else
        {
            textCooldownn.gameObject.SetActive(true);
            textCooldownn.text = Mathf.RoundToInt(cooldownTimer).ToString();
            imageCooldown.fillAmount = cooldownTimer / cooldownTime;
        }
    }

    public void UseSpell()
    {
        if (isCooldown)
        {

        }
        else
        {
            isCooldown = true;
            textCooldownn.gameObject.SetActive(true);
            cooldownTimer = cooldownTime;
        }
    }
}
